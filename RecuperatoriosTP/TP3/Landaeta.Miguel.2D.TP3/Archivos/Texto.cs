using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;
namespace Archivos
{
    public class Texto : IArchivo<String>
    {
        /// <summary>
        /// Inplementacion de los metodos la clase interfas IArchivo, utilizado para guardar archivo formato txt tipo string. 
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns>bool para confirmar la lectura</returns>
        public bool Guardar(string archivo, string datos)
        {
            bool aux = false;

            try
            {
                using (StreamWriter texto = new StreamWriter(archivo))
                    texto.Write(datos);
                aux = true;
            }
            catch (Exception)
            {

                throw new ArchivosException();
            }

            return aux;
        }
        /// <summary>
        /// Inplementacion de los metodos la clase interfas IArchivo, utilizado para leer archivo formato txt tipo string. 
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns>bool para confirmar la lectura</returns>
        public bool Leer(string archivo, out string datos)
        {
            bool aux = false;

            try
            {
                using (StreamReader texto = new StreamReader(archivo))

                    datos = texto.ReadToEnd();
                aux = true;

            }
            catch (Exception)
            {

                throw new ArchivosException();
            }
            return aux;
        }
    }
}
