using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Venta
    {
        string articulos;
        float importeTotal;

        /// <summary>
        /// Constructor inicializa atributos de objeto Venta
        /// </summary>
        /// <param name="articulos"></param>
        /// <param name="importeTotal"></param>
        public Venta(string articulos, float importeTotal)
        {
            this.Articulos = articulos;
            this.ImporteTotal = importeTotal;
        }
        /// <summary>
        /// propiedades las cuales permiten a otros metodos accesar los atributos del objeto venta
        /// </summary>
        public string Articulos 
        {
            get => articulos;
            set => articulos = value; 
        }
        public float ImporteTotal 
        {
            get => importeTotal;
            set => importeTotal = value; 
        }
        /// <summary>
        /// Metodo mostar Venta muesta los articulos que fueron vendidos en esa operacion y el importe final. Utilizado para imprimir Recivo
        /// </summary>
        /// <returns></returns>
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.articulos);
            sb.AppendLine($"Importe Total : {this.ImporteTotal.ToString()}");
            return sb.ToString();
        }
        /// <summary>
        /// hace publico el metodo mostrar del objeto Venta
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Mostrar();
        }
    }
}
