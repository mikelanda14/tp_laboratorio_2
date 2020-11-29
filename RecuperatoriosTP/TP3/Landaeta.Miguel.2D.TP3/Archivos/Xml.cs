using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Archivos
{
    public class Xml<T>:IArchivo <T>    
    {
        /// <summary>
        /// Implementacion de clase IArchivo, metodo generico Guarduar formato Xml serializado.
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns>confirmacion de guardado</returns>
       public bool Guardar(string archivo, T datos)
        {
            bool guardo = false;
            try
            {
                XmlSerializer archivoXml = new XmlSerializer(typeof(T));

                using (XmlTextWriter newTextWriter = new XmlTextWriter(archivo, Encoding.UTF8))
                {
                    archivoXml.Serialize(newTextWriter, datos);
                    guardo = true;

                }

            }
            catch (Exception )
            {

                throw new ArchivosException();

            }

            return guardo;
        }
        /// <summary>
        /// Implementacion de clase IArchivo, metodo generico leer formato Xml serializado.
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns> confirmacion de lectura</returns>
        public bool Leer(string archivo, out T datos)
        {
            bool leido = false;

         

            try
            {

                XmlSerializer nuevoXml = new XmlSerializer(typeof(T));

                using (XmlTextReader newTextReader = new XmlTextReader(archivo))
                {
                    datos = (T)nuevoXml.Deserialize(newTextReader);
                    leido = true;
                }
            }
            catch (Exception )
            {
                throw new ArchivosException();
            }

            return leido;

        }
    }
}
