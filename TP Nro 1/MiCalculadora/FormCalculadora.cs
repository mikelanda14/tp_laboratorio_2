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
namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        #region Constructores
        /// <summary>
        /// Constructor por defecto de la clase FormCalculadora.
        /// </summary>

        public FormCalculadora()
        {
            InitializeComponent();
        }

        #endregion

        #region Botones

        /// <summary>
        /// Consulta al usuario mediante un messageBox si realmente desea cerrar la aplicacion y de ser afirmativo terminal el front del programa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de cerrar?", "KILLX", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        /// <summary>
        /// ejecuta el metodo Limpiar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimbiar_Click(object sender, EventArgs e)
        {
            Limpiar();

        }
        /// <summary>
        ///  Ejecuta el metodo estatico operar tomando los valores de los campos txtNumero1, txtNumero2 y cmbOperador.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado = FormCalculadora.Operar(txtNumero1.Text.ToString(), txtNumero2.Text.ToString(), cmbOperador.Text.ToString());
            lblResultado.Text = (resultado.ToString());
        }
        /// <summary>
        /// convierte el la cadena de texto en el lblResultado a binario previa validacion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Numero numAbinario = new Numero();
            lblResultado.Text = numAbinario.BinarioDecimal(lblResultado.Text);
        }


        /// <summary>
        /// Boton convierte de binario a decimal el texto contenido en lblResultado si este textuo es un numero binario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero numAdecimal = new Numero();
            lblResultado.Text = numAdecimal.DecimalBinario(lblResultado.Text);
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Limpia todos los datos presentes en los campos txtNumero1,txtNumero2, lblResultado,cmbOperador
        /// </summary>
        private void Limpiar()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            cmbOperador.Text = " ";
            lblResultado.Text = " ";
        }
        /// <summary>
        /// Recive los datos , crea los objetos y los envia a la clase MIcalculadora
        /// </summary>
        /// <param name="numero1">el string en el campo txtNumero1</param>
        /// <param name="numero2">el string en el campo txtNumero1</param>
        /// <param name="operador">el Char en el Combobox cmbOperador</param>
        /// <returns></returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);
            return Calculadora.Operar(num1, num2, operador);
        }
        #endregion
    }

}
