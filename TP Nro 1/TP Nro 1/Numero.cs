using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;
        public Numero()
        {
           
            this.numero = 0;
        }
        public Numero(double numero)
        {
            //this.numero = numero;
        }
        public Numero(string strNumero)
        {
           //this.numero= ValidarNumero(strNumero);
        }
        private static double ValidarNumero(string strNumero)
        {
            double num;
            if(!(double.TryParse(strNumero, out num)))
            {
                num = 0;
            }

            return num;
        }

        //public string setNumero { get; set; }
        //public  string SetNumero(string strNumero)
        //{
        //    get
        //    set Numero.ValidarNumero(strNumero);
            
        //    return "texto";
        //}
    }
}
