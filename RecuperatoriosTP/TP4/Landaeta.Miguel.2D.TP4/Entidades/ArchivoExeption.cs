using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase 15-Excepciones
    /// ArchivoExeption: Excepcion de tipo archivo, muestra un mensage de error y el origen.
    /// </summary>
    public class ArchivoExeption : Exception
    {
        public ArchivoExeption(Exception innerException) : base(innerException.Message)
        {

        }
    }
}
