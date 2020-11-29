using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Entidades;
namespace TestUnitarios
{
    [TestClass]
    public class TestExeption
    {
        /// <summary>
        /// Clase 16 - Test Unitarios:
        /// TestArchivoExeption:Testea que al buscar el archivo y no encontrarlo se envie una Exceotion tipo ArchivoExeption .
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArchivoExeption))]
        public void TestArchivoExeption()
        {
            List<Producto> recuperarPedidos = new List<Producto>();
            Xml<List<Producto>> archivoXML = new Xml<List<Producto>>();
            List<Producto> productos = new List<Producto>();
            productos = archivoXML.Leer( @"ArchivoIncorrecto", recuperarPedidos);
        }
    }
}
