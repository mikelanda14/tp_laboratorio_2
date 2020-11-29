using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class SinProfesorException:Exception
    {
       /// <summary>
       /// devuelve mensaje de error no hay profesor para la clase
       /// </summary>
        public SinProfesorException():base("No hay profesor para la clase")
        {
        
        }
        /// <summary>
        /// pasa el mensaje de error a la case base.
        /// </summary>
        /// <param name="e"></param>
        public SinProfesorException(string e):base(e)
        {
        
        }

    }
}
