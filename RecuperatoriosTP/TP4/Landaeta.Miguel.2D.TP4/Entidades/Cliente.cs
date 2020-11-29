using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
       private List<Producto> carrito;

        /// <summary>
        /// Contructor del tipo cliente inicializa una lista de productos llamada carrito
        /// </summary>
        public Cliente()
        {
            carrito = new List<Producto>();
        }

        /// <summary>
        /// Sobrecarga operador + utilizado para agregar productos en la lista carrito
        /// </summary>
        /// <param name="c"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Cliente operator +(Cliente c,Producto p)
        {
            

           c.carrito.Add(p);   
            return c;
        }
        /// <summary>
        /// Metodo vieCarrito la cual devuelve la lista de productos contenidos en carrito del cliente.
        /// </summary>
        /// <returns></returns>
        public  List<Producto> viewCarrito()
        {
           
            return carrito;
        }
        /// <summary>
        /// Clase 15-Excepciones
        /// Valida si una lista tipo producto esta vacia. lanza una excepcion tipo CarritoVacioExecption
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static List<Producto> CarritoVacio(List<Producto> p)
        {
            List<Producto> carrito = new List<Producto>();
            if (p.Count > 0)
            {
                carrito = p;
            }
            else
            {
                throw new CarritoVacioExecption();
            }
            return carrito;
        }
    }
}
