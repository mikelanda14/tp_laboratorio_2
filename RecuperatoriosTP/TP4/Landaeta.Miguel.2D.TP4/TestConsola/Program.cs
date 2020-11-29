using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace TestConsola
{
    class Program
    {
        static void Main(string[] args)
        {

            Deposito deposito = new Deposito();
            Dbo<Venta>.GetMenu();
            Console.WriteLine("Primer Cliente entra en caja ");
            Cliente c1 = new Cliente();
            if (c1.viewCarrito().Count == 0)
            {

                Random random = new Random();


                for (int i = 0; i < 5; i++)
                {
                    foreach (Producto item in Deposito.viewProductos())
                    {
                        if (item.Codigo == random.Next(0, 5))
                        {
                            c1 += item;
                        }
                    }
                }


            }


            Cliente axuCliente = new Cliente();

            foreach (Producto item in c1.viewCarrito())
            {
                Deposito.AgregarVenta(item);
               

            }
            Console.WriteLine("Articulos de esta Venta");
            Console.WriteLine(Deposito.Articulos());
            Console.WriteLine("Monto Total a Pagar :"+Deposito.CalculoImporte().ToString());
            Deposito.GenerarVenta(new Venta(Deposito.Articulos(), Deposito.CalculoImporte()));
            Console.WriteLine("recibo impreso");
            Console.WriteLine("<------------------------------------------>");
            Console.ReadKey();
            try
            {
                Console.WriteLine("segundo Cliente entra en caja ");
                Cliente c2 = new Cliente();
                Cliente.CarritoVacio(c2.viewCarrito());
            }
            catch (CarritoVacioExecption e)
            {
                Console.WriteLine(e.Message);
               
            }
            Console.ReadKey();

        }
    }
}
