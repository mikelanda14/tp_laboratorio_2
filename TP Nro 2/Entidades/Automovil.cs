using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Automovil:Vehiculo
    {
        public enum ETipo { Monovolumen, Sedan }
        private ETipo tipo;

        #region Constructores

        
        /// <summary>
        /// Por defecto, TIPO será Monovolumen
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Automovil(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
           
        } 
        /// <summary>
        /// Constructor Automobil sobrecarga al por defecto y establece el Tipo
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        /// <param name="tipo"></param>
        public Automovil(EMarca marca, string chasis, ConsoleColor color,ETipo tipo)
            :this(marca, chasis, color)
        {
            if (tipo.ToString() == "Sedan")
            {
                this.tipo = ETipo.Sedan;
            }
            else { 
            this.tipo = ETipo.Monovolumen;
            }
        }
        #endregion

        #region Propiedades

        
        /// <summary>
        /// Los automoviles son medianos
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Override Mostrar 
        /// </summary>
        /// <returns>Retorna string agregando  tipo y tamanio al string. utiliza mostar de la clase Base.</returns>

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("AUTOMOVIL");
            sb.AppendLine(base.Mostrar());
            sb.Append($"TAMAÑO : {this.Tamanio}");
            sb.Append(" TIPO : " + this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
