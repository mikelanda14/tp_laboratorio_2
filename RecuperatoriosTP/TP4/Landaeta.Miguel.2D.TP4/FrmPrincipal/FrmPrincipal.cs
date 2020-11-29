using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.Threading;

namespace FrmPrincipal
{
    /// <summary>
    /// Declaracion delagado Simulacion
    /// </summary>
    public delegate void Simulation();
    public partial class FrmPrincipal : Form
    {
        /// <summary>
        /// Inicializacion del delegado simCobrar
        /// </summary>
        public event Simulation simCobrar;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
           
            CargarProductos();
        }
        /// <summary>
        /// private void CargarProductos(): carga la lista de productos buscandola en la BD y mostarndola en el DG Productos
        /// </summary>
        private void CargarProductos()
        {

            Dbo<Venta>.GetMenu();

            DgListaProductos.RowHeadersVisible = false;
            DgListaProductos.DataSource = null;
            DgListaProductos.DataSource = Deposito.viewProductos();

            //Xml<List<Producto>> archivoXML = new Xml<List<Producto>>();
            //archivoXML.Guardar( Deposito.viewProductos());
        }

        /// <summary>
        /// private void Venta(object sender, DataGridViewCellMouseEventArgs e): se encarga de tomar los datos en la lista producto y pasarla a la lista venta luego la mustra en el dg venta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Venta(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                Deposito deposito = new Deposito();
                Deposito.AgregarVenta(int.Parse(DgListaProductos.Rows[e.RowIndex].Cells["Codigo"].FormattedValue.ToString()), DgListaProductos.Rows[e.RowIndex].Cells["Descripcion"].FormattedValue.ToString(), float.Parse(DgListaProductos.Rows[e.RowIndex].Cells["Precio"].FormattedValue.ToString()));
                DgVenta.RowHeadersVisible = false;
                DgVenta.DataSource = null;
                DgVenta.DataSource = Deposito.viewVentas();
                this.LblImporte.Text = ExtensionDeposito.ExtensionCalculoImporte(deposito).ToString();

            }
            catch (Exception)
            {

            }

        }
        /// <summary>
        /// evento de boton el cual llama al metodo Venta()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgListaProductos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Venta(sender, e);
        }
        /// <summary>
        /// Evento de boton el cual llama al metodo Cobrar()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCobrar_Click(object sender, EventArgs e)
        {
            
            Cobrar();
        }
        /// <summary>
        /// private void Cobrar() se encarga de generar nueva venta y llama a metodo que vacia la lista ventas luego ejecuta accion en Dg venta.
        /// </summary>
        private void Cobrar()
        {
            if (Deposito.viewVentas().Count > 0)
            {
                Deposito.GenerarVenta(new Venta(Deposito.Articulos(), Deposito.CalculoImporte()));
                Deposito.LimpiarVentas();
                DgVenta.Invoke(new Action(() => DgVenta.DataSource = null));
                this.LblImporte.Invoke(new Action(() => this.LblImporte.Text = "0"));
            }
        }
        /// <summary>
        /// Evento de boton el cual llama al metodo ComienzaHiloSim
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSim_Click(object sender, EventArgs e)
        {
            ComienzaHiloSim();

        }
        /// <summary>
        /// Clase 23 – Hilos
        /// private void ComienzaHiloSim(): comienza un hilo de proceso aparte del el formulario.
        /// </summary>
        private void ComienzaHiloSim()
        {
            Thread thread = new Thread(Simulacion);
            thread.IsBackground = true;
            thread.Start();
        }
        /// <summary>
        /// Clase 24 – Eventos
        /// private void Simulacion():Utiliza el evento simCobrar +=Cobrar; para ejectuar el metodo Cobrar y completar la transaccion simulada.
        /// </summary>
        private void Simulacion()
        {
            Deposito deposito = new Deposito();
            Cliente c1 = new Cliente();
            if (c1.viewCarrito().Count < 1)
            {
                
                Random random = new Random();
                

                for (int i = 0; i < 5; i++)
                {
                    foreach (Producto item in Deposito.viewProductos())
                    {
                        if (item.Codigo == random.Next(0, 5))
                        {
                            c1 += item;
                        }
                    }
                }
                
                
            }
            

            Cliente axuCliente = new Cliente();

            foreach (Producto item in c1.viewCarrito())
            {
               Deposito.AgregarVenta(item);
                DgVenta.RowHeadersVisible = false;
               DgVenta.Invoke(new Action(() => DgVenta.DataSource = null));
                DgVenta.Invoke(new Action(() => DgVenta.DataSource = Deposito.viewVentas()));
                this.LblImporte.Invoke(new Action(() => this.LblImporte.Text = ExtensionDeposito.ExtensionCalculoImporte(deposito).ToString()));
                Thread.Sleep(1000);
            }
             simCobrar +=Cobrar;
             simCobrar.Invoke();
        }

        private void BtnListaXml_Click(object sender, EventArgs e)
        {
            CargarListaXml();
        }

        private void CargarListaXml()
        {
            Deposito.CargarXML();
            DgListaProductos.DataSource = null;
            DgListaProductos.DataSource = Deposito.viewProductos();
        }
    }
}
