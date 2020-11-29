using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniInvalidoException:Exception
    {
       /// <summary>
       /// Devuelve mensaje Valor Dni fuera de parametros
       /// </summary>
        public DniInvalidoException() : base("valor Dni fuera de parametros")
        {

        }
        /// <summary>
        /// devuelve mensaje de error InnerException y donde ocurre
        /// </summary>
        /// <param name="e"></param>
        public DniInvalidoException(Exception e) : base(e.InnerException.Message)
        {
            
        }
        /// <summary>
        /// Mensaje de Error de Dni no valido pasado a la clase base
        /// </summary>
        /// <param name="mensage"></param>
        public DniInvalidoException(string mensage) : base(mensage)
        {
            
        }
        /// <summary>
        /// Mesaje de error excepcion tipo invalido.
        /// </summary>
        /// <param name="mensage"></param>
        /// <param name="e"></param>
        public DniInvalidoException(string mensage,Exception e) : base(mensage, e.InnerException)
        {

        }
    }
}
