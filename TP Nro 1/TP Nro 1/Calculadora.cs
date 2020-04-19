using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public class Calculadora
    {
                private static string ValidarOperador(string operador)
                {
                if (operador.ToString()== string.Empty)
            {
                operador = "+";
            }
            //switch (operador)
            //{
            //    case "+":
            //    case "-":
            //    case "*":
            //    case "/":
            //        return operador;
            //        // break;
            //    default:
            //        operador = "+";
            //        return operador;
            //        //break;
            //}

            //if (!(operador != "+" || operador != "-" || operador != "*" || operador != "/"))
            //        { 
            //            operador = "+"; 
            //          }
                
              return operador;

            
                }
                public static double Operar(double num1, double num2,string operador)
                {
                    operador = ValidarOperador(operador);
                    double resultado=0;
                    switch (operador)
                    {
                        case "+":
                            resultado = num1 + num2;
                            return resultado;
                        // break;
                        case "-":
                            resultado = num1 - num2;
                            return resultado;
                        //  break;
                        case "*":
                            resultado = num1 * num2;
                            return resultado;
                        // break;
                        case "/":
                           // if (Calculadora.Validar(num2))
                         //   {
                                resultado = num1 / num2;
                                return resultado;
                           // }
                            //else
                            //{
                            //    Console.WriteLine("No se puede dividir entre 0");
                            //    return 0;
                            //}
                        //  break;
                        default:
                            return resultado;
                    }
                }
    }
}
