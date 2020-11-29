using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clases_Instanciables;
using EntidadesAbstractas;
using System.Collections.Generic;


namespace TestUnitarios
{
    [TestClass]
    public class TestCollections
    {
        /// <summary>
        /// Testea la coleccion de alumnos en universidad no sea nulo
        /// </summary>
        [TestMethod]
        public void TestCollectionsAlumnos()
        {
            Universidad universidad = new Universidad();
            
            Alumno alumno = new Alumno(1, "Ron", "Wizlly", "96733244", Persona.ENacionalidad.Extranjero, Universidad.EClases.Programacion);
            universidad += alumno;
            Assert.IsNotNull(universidad.Alumnos);
            
        }
        /// <summary>
        /// Test que la collection de instructores en univarisdad no sea nula
        /// </summary>
        [TestMethod]
        
        public void TestCollectionInstrutores()
        {
            Universidad universidad = new Universidad();
            Profesor instructor = new Profesor(1, "Rocky", "Balboa", "11000111",
           EntidadesAbstractas.Persona.ENacionalidad.Argentino);
            universidad += instructor;
          
            Assert.IsNotNull(universidad.Instructores);
        }
    }
}
