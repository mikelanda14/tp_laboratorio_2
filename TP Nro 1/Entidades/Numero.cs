using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{



    public class Numero
    {
        private double numero;

        #region Contructores

        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }
        /// <summary>
        /// constructor toma valor numerico y lo asigna	
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero)
        {
            this.numero = numero;//revisar
        }
        /// <summary>
        /// toma string y utilzando propiedad setNumero para asingarle valor.
        /// </summary>
        /// <param name="strNumero"> string  con vaslor numerico</param>
        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;

        }
        #endregion

        #region Propiedades

        /// <summary>
        /// propiedad del objeto numero que asigna el valor numerico previamente validado.
        /// </summary>
        public string SetNumero
        {

            set
            {

                this.numero = ValidarNumero(value);

            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Valida que sea un valor binario solo 0 y 1, recoriendo la cadena con un foreach.
        /// </summary>
        /// <param name="binario">string con valor numerico tipo binario</param>
        /// <returns></returns>

        private bool EsBinario(string binario)
        {
            foreach (var item in binario)
            {
                if (item != '0' && item != '1')
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Transforma valor numerico de binario a sistema decimal.
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        public string BinarioDecimal(string binario)
        {
            string binarioDecimal;


            if (binario != "valor invalido" && binario != string.Empty)
            {
                binarioDecimal = Convert.ToString((int)Math.Round(Math.Abs(double.Parse(binario))), 2);

                return binarioDecimal;

            }
            else
            {
                //
                return "valor invalido";
            }

        }
        /// <summary>
        ///  transforma valor numerico de sistema decimal a binario
        /// </summary>
        /// <param name="decimalBinario">string con valor decimal previamente validado</param>
        /// <returns></returns>
        public string DecimalBinario(string decimalBinario)
        {
            string decimalAbinario;
            if (!EsBinario(decimalBinario))
            {
                return "valor invalido";
            }
            else
            {
                decimalAbinario = Convert.ToInt32(decimalBinario, 2).ToString();
                return decimalAbinario;

            }
        }
        /// <summary>
        /// Valida que el string contenga un valor numerico y no otro tipo de caracteres.
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
        private double ValidarNumero(string strNumero)
        {
            double numeroValido;


            if (!double.TryParse(strNumero, out numeroValido))
            {
                numeroValido = 0;
            }

            return numeroValido;
        }

        #endregion

        #region Sobrecargas
        /// <summary>
        /// Sobrecarga al operador + permitira que los objetos sumen los atributos apropiados.
        /// </summary>
        /// <param name="n1">objeto tipo numero</param>
        /// <param name="n2">objeto tipo numero</param>
        /// <returns></returns>

        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }
        /// <summary>
        /// Sobrecarga al operador - permitira que los objetos resten los atributos apropiados.
        /// </summary>
        /// <param name="n1">objeto tipo numero</param>
        /// <param name="n2">objeto tipo numero</param>
        /// <returns></returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }
        /// <summary>
        /// Sobrecarga al operador * permitira que los objetos multipliquen los atributos apropiados.
        /// </summary>
        /// <param name="n1">objeto tipo numero</param>
        /// <param name="n2">objeto tipo numero</param>
        /// <returns></returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }
        /// <summary>
        /// Sobrecarga al operador / permitira que los objetos dividan los atributos apropiados.
        /// </summary>
        /// <param name="n1">objeto tipo numero</param>
        /// <param name="n2">objeto tipo numero</param>
        /// <returns></returns>
        public static double operator /(Numero n1, Numero n2)
        {
            if (n2.numero != 0)
            {
                return n1.numero / n2.numero;
            }
            else
            {
                return double.MinValue;
            }
        }
        #endregion



    }
}
