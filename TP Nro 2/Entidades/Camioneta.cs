using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camioneta:Vehiculo
    {
        #region Constructores

        /// <summary>
        /// Constructor clase Camioneta, utiliza el constructor de la clase Base.
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Camioneta(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
        }
        #endregion

        #region Propiedades

        
        /// <summary>
        /// Las camionetas son grandes
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Override de Mostrar
        /// </summary>
        /// <returns>Retorna un String con agregando el tamano y Mostart del metodo BAse</returns>
        
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CAMIONETA");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"TAMAÑO : {this.Tamanio}");
           
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
