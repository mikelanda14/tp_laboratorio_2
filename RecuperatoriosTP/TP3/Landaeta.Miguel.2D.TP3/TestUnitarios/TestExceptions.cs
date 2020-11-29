using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using Clases_Instanciables;
using EntidadesAbstractas;
using System.Collections.Generic;

namespace TestUnitarios
{
    [TestClass]
    public class TestExceptions
    {
        /// <summary>
        /// Verifica que la Execption sea del tipo AlumnoRepetidoExecption.
        /// </summary>
        [TestMethod]
        public void TestAlumnoRepetidoException()
        {
            try
            {
                Universidad universidad = new Universidad();

                Alumno alumno = new Alumno(1, "Tod", "Matter", "95111222", Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio);
                Profesor instructor = new Profesor(2, "Albert", "Einstain", "95233444", Persona.ENacionalidad.Extranjero);
                Jornada jornada = new Jornada(Universidad.EClases.Laboratorio, instructor);
                jornada += alumno;
                jornada += alumno;
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(AlumnoRepetidoException));
            }


        }
        /// <summary>
        /// Verifica que NacionalidadInvalidaExecption no es del mismo tipo DniInvalidoException
        /// </summary>
        [TestMethod]
        public void TestNotDniInvalidoException()
        {

            try
            {
                Universidad utn = new Universidad();
                Alumno alumno = new Alumno(1, "Jackson", "Storm", "25333000",
               EntidadesAbstractas.Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio,
               Alumno.EEstadoCuenta.AlDia);
                utn += alumno;
            }
            catch (NacionalidadInvalidaException e)
            {
                Assert.IsNotInstanceOfType(e, typeof(DniInvalidoException));
            }
        }
        /// <summary>
        /// Test el tipo de Exception sea DniInvalidoException forzado por el valor DNi en el objeto alumno
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void TestDniException()
        {


            Alumno alumno = new Alumno(1, "Luis", "Perez", "999999999999999999999 ", Persona.ENacionalidad.Argentino, Universidad.EClases.Legislacion);


        }
    }
}

