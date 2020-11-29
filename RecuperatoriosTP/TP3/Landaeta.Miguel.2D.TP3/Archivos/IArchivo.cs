using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{

    interface IArchivo<T>
    {
        /// <summary>
        /// Metodo de clase interfas IArchivo generico guardar
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns>bool para confirmar si fue o no guardado</returns>
        bool Guardar(string archivo, T datos);
        /// <summary>
        /// Metodo de la clase interfas IArchivo generico para leer
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns>bool para confirmar si lee o no del archivo</returns>
        bool Leer(string archivo, out T datos);
        

    }
}
