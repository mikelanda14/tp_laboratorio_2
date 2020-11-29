using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase 15-Excepciones
    /// CarritoVacioExecption: Excepcion de tipo Lista de compra vacia, muestra un mensage 'Carrito Vacio , Vuelva pronto'.
    /// </summary>
    public class CarritoVacioExecption:Exception
    {
        /// <summary>
        /// Excepcion de tipo carrito Vacio , muestra el mensaje y el origen.
        /// </summary>
        private string mensaje;
        public CarritoVacioExecption():base("Carrito Vacio , Vuelva pronto")
        {

        }
        /// <summary>
        /// Excepcion de tipo carrito Vacio , muestra el mensaje de tipo InnerException
        /// </summary>
        public CarritoVacioExecption(Exception e) : base(e.InnerException.Message)
        {

        }
        /// <summary>
        /// Excepcion de tipo carrito Vacio , muestra el mensaje por parametro
        /// </summary>
        public CarritoVacioExecption (string mensaje) : base(mensaje)
        {
            this.mensaje = mensaje;
        }

        
    }
}
