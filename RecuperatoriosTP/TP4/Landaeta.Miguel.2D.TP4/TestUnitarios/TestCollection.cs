using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Entidades;

namespace TestUnitarios
{
    /// <summary>
    /// Clase 16 - Test Unitarios:
    /// TestCarrito:Testea que la lista de productos en el objeto cliente no sea null.
    /// </summary>
    [TestClass]
    public class TestCollection
    {
        [TestMethod]
        public void TestCarrito()
        {
            Cliente cliente = new Cliente();
            cliente +=( new Producto(1,"productox",9F));

            Assert.IsNotNull(cliente.viewCarrito());

        }

        /// <summary>
        /// Clase 16 - Test Unitarios:
        /// TestProductos:Testea que la lista de productos en la clase Deposito no sea null.
        /// </summary>
        [TestMethod]
        public void TestProductos()
        {
            Deposito deposito = new Deposito();
           Producto producto=new Producto(7, "Producto Test7", 7.75F);
            Deposito.AgregarVenta(producto);
            Assert.IsNotNull(Deposito.viewVentas());

        }
    }
}
