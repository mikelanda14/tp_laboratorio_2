using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace Entidades
{
    public class Xml<T> : IArchivo<T>
    {
        /// <summary>
        /// Clase 18 – Interfaces:
        /// Clase 19 - Archivos y serialización
        /// Implemtacion de la Ingerfas IArchivo, metodo Guardar. Guarda en un archivo tipo Xml
        /// </summary>
        /// <param name="datos"></param>
        public void Guardar(T datos)
        {

            try
            {


                using (XmlTextWriter newTextWriter = new XmlTextWriter(AppDomain.CurrentDomain.BaseDirectory+@"ListaProductos.xml", Encoding.UTF8))
                {
                    XmlSerializer archivoXml = new XmlSerializer(typeof(T));
                    archivoXml.Serialize(newTextWriter, datos);


                }

            }
            catch (Exception e)
            {

                throw new ArchivoExeption(e);

            }


        }
        /// <summary>
        /// 
        /// Clase 19 - Archivos y serialización
        /// public T Leer(string archivo, T datos): En caso de una falla de conexion con la BD. lee en un archivo tipo Xml con la lista de productos.
        /// </summary>
        /// <param name="datos"></param>
        public T Leer(string archivo, T datos)
        {

            try
            {


                using (XmlTextReader textReader = new XmlTextReader(archivo))
                {
                    XmlSerializer archivoXml = new XmlSerializer(typeof(T));
                    datos = (T)archivoXml.Deserialize(textReader);
                }


                return datos;
            }
            catch (Exception e)
            {

                throw new ArchivoExeption(e);
            }
            
        }
    }
}
