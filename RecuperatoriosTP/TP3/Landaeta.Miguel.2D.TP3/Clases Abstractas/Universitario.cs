using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Universitario : Persona 
    {
        #region Atributo

        
        private int legajo;
        #endregion

        #region Constructores

        
        /// <summary>
        /// Constructor por defecto 
        /// </summary>
        public Universitario()
        {

        }
        /// <summary>
        /// Constructor que inicializa legajo y transfiere a base los atributos heredados de persona.
        /// </summary>
        /// <param name="legajo"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Universitario(int legajo,string nombre,string apellido,string dni,ENacionalidad nacionalidad):base(nombre,apellido,dni,nacionalidad)
        {
            this.legajo = legajo;
        }

        #endregion

        #region Metodos

        
        /// <summary>
        /// override de Equals objeto
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return this.GetType()== obj.GetType();
        }
        /// <summary>
        ///  metodo mostardatos muestra los atributos devolviendolos en un string
        /// </summary>
        /// <returns></returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.ToString()}");
            sb.AppendLine("");
            sb.AppendLine($"LEGAJO NUMERO: {this.legajo.ToString()}");
           // sb.AppendLine("");
            return sb.ToString();
        }
        /// <summary>
        /// declaracion demetodo abstracto Participante, no toma parametros pero devuelve un string.
        /// </summary>
        /// <returns></returns>
        protected abstract string ParticiparEnClase();

        #endregion

        #region Sobrecarga de operadores


        /// <summary>
        /// Sobrecarga de operdador == objetos universitarios
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns></returns> 

        public static bool operator ==(Universitario pg1,Universitario pg2)
        {
            return  ( pg1.Equals(pg2) && pg1.legajo == pg2.legajo ||pg1.DNI==pg2.DNI ) ;
        }
        /// <summary>
        /// sonbrecarga de operador != objetos universitarios
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns></returns>
        public static bool operator !=(Universitario pg1,Universitario pg2)
        {
            return !(pg1== pg2);
        }
        #endregion
       

    }
}
