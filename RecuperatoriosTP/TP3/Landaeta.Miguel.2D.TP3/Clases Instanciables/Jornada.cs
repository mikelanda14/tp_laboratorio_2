using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Archivos;
using System.IO;
namespace Clases_Instanciables
{
     public  class Jornada
    {
        #region Atributos

        
        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;
        #endregion

        #region Propiedades

        /// <summary>
        /// devuelve la lista de alumnos o setea la lista de alumnos
        /// </summary>
        public List<Alumno> Alumnos 
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }
        /// <summary>
        /// devuelve la clase o setea la calse
        /// </summary>
        public Universidad.EClases Clases 
        {
            get 
            {
                return this.clase;
            }
            set
            {
                this.clase = value;
            }
                
        }
        /// <summary>
        /// devuelve el instructor o setea el instructor
        /// </summary>
        public Profesor Instructor 
        {
            get 
            {
                return this.instructor;
            }
            set 
            {
                this.instructor = value;
            }
        }
        #endregion
       

        #region Constructores

        /// <summary>
        /// constructor por defecto de Jornada inicializa la lista alumnos
        /// </summary>
        public Jornada() 
        {
            this.alumnos = new List<Alumno>();
        }
        /// <summary>
        /// sobrecarga del constructor jornada inicializa listas atributo instructor y clase con el uso de las propiedades
        /// </summary>
        /// <param name="clase"></param>
        /// <param name="instructor"></param>
        public Jornada(Universidad.EClases clase,Profesor instructor):this()
        {
            this.Instructor = instructor;
            this.Clases = clase;
        }
        #endregion

        
        #region Sobrecargas de operadores

        /// <summary>
        /// sobrecarga del operador == verifica si el alumno esta o no en la jornada
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool  operator ==(Jornada j, Alumno a)
        {
            bool contenido=false;
            foreach (Alumno item in j.alumnos)
            {
                if (item == a)
                {
                    contenido = true;
                }
            }
            
            
            
            return contenido;
        }
        /// <summary>
        /// sobrecarga del operador == verifica si el alumno esta o no en la jornada
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j==a);
        }
        /// <summary>
        /// agrega un alumno a la jornada si este no esta ya presente o lanza AlumnoRepetidoException en caso de que este ya este prensetne en la lista 
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Jornada operator +(Jornada j, Alumno a)
        {
            
            if (!(j==a))
            {
                j.alumnos.Add(a);
                
                
            }
            else
            {
                throw new AlumnoRepetidoException();
            }
            return j;
        }
        #endregion

        #region Metodos

        /// <summary>
        /// "Guarda la jornade en archivo e texto
        /// </summary>
        /// <param name="jornada"></param>
        /// <returns></returns>
        public static bool Guardar(Jornada jornada)
        {

            Texto guardarTexto = new Texto();
            return guardarTexto.Guardar(AppDomain.CurrentDomain.BaseDirectory + "@jornada.txt", jornada.ToString());

        }
        /// <summary>
        /// lee la jornada de un archivo de texto 
        /// </summary>
        /// <returns></returns>
        public static string Leer()
        {
            DirectoryInfo directory = new DirectoryInfo(".");
            Texto LeerTexto = new Texto();
            string datos;

            LeerTexto.Leer(AppDomain.CurrentDomain.BaseDirectory + "@jornada.txt", out datos);
            return datos;
        }
        /// <summary>
        /// sobreescribe el metodo ToString para el objeto Jornada retornando un string con todos los atributos.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"CLASE DE {this.Clases.ToString()} POR {this.Instructor.ToString()}");
            sb.AppendLine($"ALUMNOS: ");
            foreach (Alumno item in alumnos)
            {
                
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("<---------------------------------------------------------------------------->");
            return sb.ToString();
        }
        #endregion
    }
}
