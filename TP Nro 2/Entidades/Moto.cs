using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   
    public class Moto :Vehiculo
    {
        #region Constructores

        
        /// <summary>
        /// Moto Constructor
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Moto(EMarca marca, string chasis, ConsoleColor color):base(chasis,marca,color)
        {
        }
        #endregion

        #region Propiedades

        
        /// <summary>
        /// Propiedades Tamano solo lectura y devuelve Las motos son chicas.
        /// </summary>

        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
        }
        #endregion

        #region Metodos


        /// <summary>
        /// Override del metodo Mostrar 
        /// </summary>
        /// <returns>Retorna un string incluendo el agregado del metodo Mostrat Base.</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("MOTO");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"TAMAÑO : {this.Tamanio}");
            
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
