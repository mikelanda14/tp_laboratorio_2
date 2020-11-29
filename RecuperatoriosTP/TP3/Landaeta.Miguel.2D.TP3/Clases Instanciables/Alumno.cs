using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;


namespace Clases_Instanciables
{
    public sealed class Alumno : Universitario
    {
        #region Atributos

        
        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;
        public enum EEstadoCuenta
            {
            AlDia,
            Deudor,
            Becado
            }
        #endregion

        #region Construtores
        /// <summary>
        /// Constructor por defecto Alumno
        /// </summary>

        public Alumno()
        {

        }
        /// <summary>
        /// Contructor inicializa clase que toma y utiliza contructor de base para los otro atributos
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="claseQueToma"></param>
        public Alumno(int id,string nombre,string apellido,string dni,ENacionalidad nacionalidad,Universidad.EClases claseQueToma):base(id,nombre,apellido,dni,nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }
        /// <summary>
        /// sobrecarga de contructor alumno el cual inicializa estado de cuenta.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="claseQueToma"></param>
        /// <param name="estadoCuenta"></param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta):this(id,nombre,apellido,dni,nacionalidad,claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Muestra los datos de Alumno y base.
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"ESTADO DE CUENTA: {this.estadoCuenta.ToString()}");
            sb.Append(this.ParticiparEnClase());
        
            
            return sb.ToString();
        }
        #endregion

        #region Sobrecargas

        /// <summary>
        /// valida si el alumno toma la calse y el estado de cuenta no e deudor
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator ==(Alumno a,Universidad.EClases clase)
        {
            return (a.claseQueToma == clase && a.estadoCuenta != EEstadoCuenta.Deudor);
        }
        /// <summary>
        /// valida si el alumno toma la calse y el estado de cuenta no e deudor
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator !=(Alumno a,Universidad.EClases clase)
        {
            return !(a.claseQueToma == clase);
        }
        /// <summary>
        /// Sobre escribe el metodo participar en clase agrega al string TOMA Case DE  mas atributo
        /// </summary>
        /// <returns></returns>
        protected override string ParticiparEnClase()
        {
            return ("TOMA CLASE DE " + this.claseQueToma.ToString());
        }
        public override string ToString()
        {


            return this.MostrarDatos();

            
        }
        #endregion
    }
}
