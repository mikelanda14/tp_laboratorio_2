using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IArchivo<T>
    {
        /// <summary>
        /// Clase 18 – Interfaces:
        /// Clase 17 - Tipos Genéricos:
        /// void Guardar( T datos): Metodo de interfas recibe Tipo Generico en su firma.
        /// </summary>
        /// <param name="datos"></param>
        void Guardar( T datos);
    }
}
