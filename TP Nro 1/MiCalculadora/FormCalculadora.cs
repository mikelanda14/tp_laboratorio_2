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
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void button_Operar_Click(object sender, EventArgs e)
        {
            if (txtNumero1.Text.ToString()!= string.Empty && txtNumero2.Text.ToString() != string.Empty && comboBox_Oper.SelectedIndex != -1)
            {
                txtResultado.Text = Calculadora.Operar(double.Parse(txtNumero1.Text.ToString()), double.Parse(txtNumero2.Text.ToString()), comboBox_Oper.SelectedItem.ToString()).ToString();
            }
            
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtResultado.Text = string.Empty;
            comboBox_Oper.Text = string.Empty;

        }

        private void button_Conv_Deci_Click(object sender, EventArgs e)
        {

            if (txtResultado.Text.ToString()!=string.Empty) {
                int toBin = int.Parse(txtResultado.Text);
                int deci = Convert.ToInt32(toBin.ToString(), 2);
                txtResultado.Text = deci.ToString();
                
            }
        }

        private void txtNumero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && (chr != 8 )&& (chr != 46 )|| chr == 46 && txtNumero1.Text.Contains("."))
            {
                e.Handled = true;
               
            }
        }

        private void txtNumero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && (chr != 8) && (chr != 46) || chr == 46 && txtNumero2.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void comboBox_Oper_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (chr != 8)
            {
                e.Handled = true;
            }
        }

        private void btnConBin_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.ToString() != string.Empty )
            {
               
                txtResultado.Text = Convert.ToString((int)Math.Round(Math.Abs(double.Parse(txtResultado.Text))), 2);
               
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de cerrar?", "KILLX", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

       
    }
}
