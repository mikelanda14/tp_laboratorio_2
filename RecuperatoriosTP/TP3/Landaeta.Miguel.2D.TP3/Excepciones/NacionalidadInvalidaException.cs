using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NacionalidadInvalidaException:Exception
    {
        /// <summary>
        /// Devuelve mensaje de error Valor DNi no coincide con parametros.
        /// </summary>
        public NacionalidadInvalidaException():base("Valor de DNI no coincide con parametro de nacionalidad")
        {

        }
        
    }
}
