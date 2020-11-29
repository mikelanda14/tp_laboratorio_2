using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ExtensionDeposito
    {
        /// <summary>
        /// Clase 25 - Métodos de extensión
        /// public static float ExtensionCalculoImporte(this Deposito deposito):extiende la funcionalbilidad de la clase Deposito, Redondea a solo dos numeros el punto floante. (los ultimos dos decimales)
        /// </summary>
        /// <param name="deposito"></param>
        /// <returns></returns>
        public static float ExtensionCalculoImporte(this Deposito deposito)
        {

            double aux = Deposito.CalculoImporte();
            float auxImporte = (float)(Math.Round(aux, 2));
            return auxImporte;


        }

    }
}

