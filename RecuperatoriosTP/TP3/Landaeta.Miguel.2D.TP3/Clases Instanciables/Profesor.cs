using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using Clases_Instanciables;

namespace Clases_Instanciables
{
   public sealed class Profesor:Universitario
    {
        #region Atributos
        private Queue<Universidad.EClases> clasesDelDia;
        private static Random random;
        #endregion

        #region Metodos
        /// <summary>
        /// agrega una clase aleatoreamente a atributo clase del dia
        /// </summary>
        
        private void _ramdomClases()
        {
            for (int i = 0; i < 2; i++)
            {
                if (this.clasesDelDia.Count < 1)
                {
                    this.clasesDelDia.Enqueue((Universidad.EClases)random.Next(0, 3));
                }
            }

           
        }
        /// <summary>
        /// Muesta agrega DAtos de la base pertenecientes al profesro y agrega la clase que esta dando.
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.AppendLine(this.ParticiparEnClase());
            
            return sb.ToString() ;
        }
        /// <summary>
        /// busca la calse que el profesor y la retorna en un string
        /// </summary>
        /// <returns></returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"CLASES DEL DIA ");
            foreach (var item in clasesDelDia)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
        /// <summary>
        /// hace publico el metodo mostrar datos sobre escribiendo el metodo ToString para el objeto Profesor.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {

            return this.MostrarDatos();
        }
        #endregion

        #region Sobrecargas de operadores

        /// <summary>
        /// compara el profero da la clase del dia
        /// </summary>
        /// <param name="i"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator ==(Profesor i,Universidad.EClases clase)
        {
            
                return (i.clasesDelDia.Contains(clase));
        }
        /// <summary>
        /// compara el profero da la clase del dia
        /// </summary>
        /// <param name="i"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return !(i==clase);
        }
        #endregion
        
        #region Constructor

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Profesor()
        {

        }
        /// <summary>
        /// constructor statico para inicializar el objeto random usado por el metodo _rambomClases
        /// </summary>
        static Profesor()
        {
            Profesor.random = new Random();
        }
        /// <summary>
        /// Construcor que inicializa los atributos de profesor y utiliza el constructor de la clase base.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Profesor(int id,string nombre,string apellido,string dni,ENacionalidad  nacionalidad):base(id,nombre,apellido,dni,nacionalidad)
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            this._ramdomClases();
        }

        #endregion

       
    }
}
