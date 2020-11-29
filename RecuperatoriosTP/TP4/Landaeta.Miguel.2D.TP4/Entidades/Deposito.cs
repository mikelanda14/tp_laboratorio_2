using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Deposito
    {
        static List<Producto> ventas;
        static List<Producto> productos;


        /// <summary>
        /// Constructor por defecto utilizado para serializar la lista de productos
        /// </summary>
        public Deposito()
        {

        }
        /// <summary>
        /// Constructor statico utilizado para inicializar listas productos y ventas. 
        /// </summary>
        static Deposito()
        {
            ventas = new List<Producto>();
            productos = new List<Producto>();
        }

        /// <summary>
        /// Metodo agrega productos a la lista productos
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="descripcion"></param>
        /// <param name="precio"></param>
        public static void AgregarProductos(int codigo, string descripcion, float precio)
        {
            productos.Add(new Producto(codigo, descripcion, precio));
        }
        /// <summary>
        /// devuelve la lista productos .
        /// </summary>
        /// <returns></returns>
        public static List<Producto> viewProductos()
        {
            return productos;
        }
        /// <summary>
        /// Agrega productos a la lista venta.
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="descripcion"></param>
        /// <param name="precio"></param>
        public static void AgregarVenta(int codigo, string descripcion, float precio)
        {
           ventas.Add(new Producto(codigo, descripcion, precio));
        }
        /// <summary>
        /// sobrecarga agrega producto reciviendolo como objeto.
        /// </summary>
        /// <param name="producto"></param>
        public static void AgregarVenta(Producto producto)
        {
           ventas.Add(producto);
        }
        /// <summary>
        /// devuelve la lista venta con sus productos contenidos.
        /// </summary>
        /// <returns></returns>
        public static List<Producto> viewVentas()
        {
            return ventas;
        }
        /// <summary>
        /// Vacia la lista ventas.
        /// </summary>
        public static void LimpiarVentas()
        {
            ventas.Clear();
        }
        /// <summary>
        /// Clacula el monto total a abonar por el cliente utiliza el metodo ViewVentas.
        /// </summary>
        /// <returns></returns>
        public static float CalculoImporte()
        {
            float ImporteTotal = 0;
            foreach (Producto item in Deposito.viewVentas())
            {
                ImporteTotal = item.Precio + ImporteTotal;

            }
            return ImporteTotal;
        }
        /// <summary>
        ///  genera lista de articulos contenido en lista ventas.
        /// </summary>
        /// <returns>retorna string con lista de productos</returns>
        public static string Articulos()
        {
            StringBuilder sb = new StringBuilder();
                
            foreach (Producto item in Deposito.ventas)
            {
                sb.AppendLine($"{item.Codigo.ToString()}  { item.Descripcion}");
            }

            return sb.ToString();
        }
        /// <summary>
        /// Concreta la venta imprime el recivo y respalda la venta en la BD
        /// </summary>
        /// <param name="venta"></param>
        public static void GenerarVenta(Venta venta)
        {
            Dbo<Venta> dbo = new Dbo<Venta>();
            Texto texto = new Texto();
            texto.Guardar(venta.ToString());
            dbo.Guardar(venta);
        }
        /// <summary>
        /// Lee la lista de productos previamente serializada en un archivo.
        /// </summary>
        public static void CargarXML()
        {
            try
            {
                productos.Clear();
                List<Producto> recuperarPedidos = new List<Producto>();
                Xml<List<Producto>> archivoXML = new Xml<List<Producto>>();

                productos = archivoXML.Leer(AppDomain.CurrentDomain.BaseDirectory + @"ListaProductos.xml", recuperarPedidos);




            }
            catch (Exception e)
            {

                throw e;
            }


        }

        
    }
}
