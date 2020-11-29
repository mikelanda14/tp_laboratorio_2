using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    
    
        public class Texto : IArchivo<string>
        {
        /// <summary>
        /// Clase 18 – Interfaces:
        /// Clase 19 - Archivos y serialización
        /// public void Guardar( string datos):Implemtacion de la Ingerfas IArchivo, metodo Guardar. Guarda en un archivo tipo Txt
        /// </summary>
        /// <param name="datos"></param>
        public void Guardar( string datos)
            {
            
                try
                {
                string[] numeroArchivos = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory+ "\\..\\..\\..\\Impresora\\", "*.txt"); 
 
                 string archivo = (AppDomain.CurrentDomain.BaseDirectory + "\\..\\..\\..\\Impresora\\" + @"Recivo"+(numeroArchivos.Length+1).ToString()+".txt").ToString();
                using (StreamWriter venta = new StreamWriter(archivo))
                    {
                        venta.Write(datos);
                    }
                }
                catch (Exception e)
                {

                    throw new ArchivoExeption(e);
                }
            }


            
        }
    }

