using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestUnitarios
{
    [TestClass]
    public class TestNumerico
    {
        /// <summary>
        /// Clase 16 - Test Unitarios:
        /// TestValorNumerico:Testea que el tipo de valor sea una instancia de tipo float en el objeto producto.
        /// </summary>
        [TestMethod]
        public void TestValorNumerico()
        {
            Producto producto = new Producto(1, "ProductoX", 1F);

            Assert.IsInstanceOfType(producto.Precio, typeof( float));
           
        }
    }
}
