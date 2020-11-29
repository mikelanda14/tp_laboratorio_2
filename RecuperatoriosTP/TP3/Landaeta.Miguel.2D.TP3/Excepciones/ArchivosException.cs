using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ArchivosException : Exception
    {
        /// <summary>
        /// Execeptio de tipo ArchivoExeption
        /// </summary>
        public ArchivosException()
        {

        }
        /// <summary>
        /// Devuelve mensaje de error de la exception. 
        /// </summary>
        /// <param name="mensaje"></param>
        public ArchivosException(Exception mensaje) : base(mensaje.Message)
        { 
        
        }
            
        
    }
}
