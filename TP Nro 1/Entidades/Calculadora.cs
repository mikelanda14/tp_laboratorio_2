using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        #region Metodos

        /// <summary>
        /// con el string operador valida que sea uno de los 4 operadores validos para operaciones, de lo contrario devuelve valor +
        /// </summary>
        /// <param name="operador">valor que vuelve de el cmbOperador</param>
        /// <returns></returns>
        private static string ValidarOperador(string operador)
        {
            string operadorValido = "+";
            if (operador == "+" || operador == "-" || operador == "/" || operador == "*")
            {
                operadorValido = operador;

            }
            return operadorValido;
        }
        /// <summary>
        /// metodo operar ejecuta alguna de las operaciones + - * / , encaso de no ser uno de los 4 operadores validos ejecutara la suma.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        public static double Operar(Numero num1, Numero num2, String operador)
        {
            switch (ValidarOperador(operador))
            {
                case "+":
                    return num1 + num2;
                //break;
                case "-":
                    return num1 - num2;
                //break;
                case "*":
                    return num1 * num2;
                //break;
                case "/":
                    return num1 / num2;
                //break;
                default:
                    return num1 + num2;
                    //break;
            }
        }
        #endregion
    }
}
