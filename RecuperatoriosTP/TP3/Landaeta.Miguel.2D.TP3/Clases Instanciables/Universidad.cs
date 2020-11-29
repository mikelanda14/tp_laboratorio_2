using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using System.Xml.Serialization;
using System.Xml;
using EntidadesAbstractas;
using Excepciones;

namespace Clases_Instanciables
{
    public  class Universidad
    {
        [Serializable]

        #region Atributos

        
        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD
        }

        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;
        #endregion

        #region Constructor

        /// <summary>
        /// constructor por defecto inicializa las listas alumnos , jornada y profesores
        /// </summary>
        public Universidad()
        {
            alumnos = new List<Alumno>();
            jornada = new List<Jornada>();
            profesores = new List<Profesor>();
        }
        #endregion

        #region Atributos

        /// <summary>
        /// devuelve o setea un alumno en una lista de alumnos
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
        /// devuelve o setea un profesor en la lista de profesores
        /// </summary>
        public List<Profesor> Instructores
        {
            get
            {
                return this.profesores;
            }
            set
            {
                this.profesores = value;
            }
        }

        /// <summary>
        /// devuelve o setea una jornada en la lista de jornada de la universidad
        /// </summary>
        public List<Jornada> Jornadas
        {
            get
            {
                return this.jornada;
            }
            set
            {
                this.jornada = value;
            }

        }
        /// <summary>
        /// busca o sete una jornada utilizando un indexador
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public Jornada this[int i]
        {
            get
            {
                return this.jornada[i];
            }


            set
            {
                this.jornada[i] = value;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// metodo utilizado para guardar el objeto univerisdad en un xml retorna confirmacion si logro guardar o noi
        /// </summary>
        /// <param name="uni"></param>
        /// <returns></returns>
        
        public static bool Guardar(Universidad uni)
        {
            bool guardo = false;
            Xml<Universidad> guadarXML = new Xml<Universidad>();
            guardo = guadarXML.Guardar(AppDomain.CurrentDomain.BaseDirectory + "@Universidad.xml", uni);
            return guardo;
        }
        /// <summary>
        /// Lee archivo xml objeto universidad previamente serizalado
        /// </summary>
        /// <returns></returns>
        public Universidad Leer()
        {
            Xml<Universidad> leerXML = new Xml<Universidad>();
            leerXML.Leer(AppDomain.CurrentDomain.BaseDirectory + "@Universidad.xml", out Universidad auxUni);
            return auxUni;

        }
        /// <summary>
        /// metodo que muestra las jornadas registradas en universidad
        /// </summary>
        /// <param name="uni"></param>
        /// <returns></returns>
        private string MostrarDatos(Universidad uni)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("JORNADA:");

            foreach (Jornada item in uni.Jornadas)
            {
                sb.AppendLine(item.ToString());

            }

            return sb.ToString();
        }
        /// <summary>
        /// metodo que sobre escrive el metodo ToString del objeto univerdida para hacerlo publico
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatos(this);
        }
        #endregion

        #region Sobrecarga de operadores

        /// <summary>
        /// sobregarga operador !=  para las instancias de objetos universida y alumno.  compara si el alumno ya esta prenste en la lista de alumnos en universidad
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g==a);
        }
        /// <summary>
        /// compara si el profesor ya esta presnete en la lista de profesores de unveridad
        /// </summary>
        /// <param name="g"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g==i);
        }
        /// <summary>
        /// compara si algun profesro puede o no dar la clase en la jornada.
        /// </summary>
        /// <param name="u"></param>
        /// <param name="clases"></param>
        /// <returns></returns>
        public static Profesor operator !=(Universidad u, EClases clases)
        {


            foreach (Profesor item in u.profesores)
            {
                if (item != clases)
                {
                    return item;

                }

            }
            throw new SinProfesorException();
        }
        /// <summary>
        /// sobrecarga de operador que agrega una jornada con la clase y el profesor que puede dar la clase
        /// </summary>
        /// <param name="g"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static Universidad operator +(Universidad g, EClases clase)
        {
            Profesor profesor = (g == clase);
            Jornada jornada = new Jornada(clase, profesor);
            foreach (Alumno item  in g.Alumnos)
            {
                if (item == clase)
                {
                    jornada.Alumnos.Add(item);
                }
            }
            g.Jornadas.Add(jornada);
           return g;
           
        } 
        /// <summary>
        /// Agrega un alumno a la universida si este no esta ya presente en la lista de alumnos
        /// </summary>
        /// <param name="u"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Universidad operator +(Universidad u,Alumno a)
        {
            if (u != a)
            {
                u.Alumnos.Add(a);
            }
            else
            {
                throw new AlumnoRepetidoException();
            }
                
            return u;
        }
        /// <summary>
        /// Agrega prosores a la lista de profesores.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static Universidad operator +(Universidad g, Profesor i)
        {
            if (g != i)
            {
                g.Instructores.Add(i);
            }
       

            return g;
        }

        /// <summary>
        /// sobregarga operador !=  para las instancias de objetos universida y alumno.  compara si el alumno ya esta prenste en la lista de alumnos en universidad
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Universidad g, Alumno a)
        {
            bool alumnoRepetido = false;
            foreach (Alumno item in g.alumnos)
            {
                if (item == a)
                {
                    alumnoRepetido = true;
                    break;
                }
            }
            return alumnoRepetido;
        }
        /// <summary>
        /// compara si el profesor ya esta presnete en la lista de profesores de unveridad
        /// </summary>
        /// <param name="g"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static bool operator ==(Universidad g,Profesor i)
        {
            bool profesorRegistrado = false;
            foreach (Profesor item in g.profesores)
            {
                if (item.DNI == i.DNI)
                {
                    profesorRegistrado = true;
                    break;
                }
            }
                return profesorRegistrado;

        }
        /// <summary>
        /// compara si algun profesro puede o no dar la clase en la jornada.
        /// </summary>
        /// <param name="u"></param>
        /// <param name="clases"></param>
        /// <returns></returns>
        public static Profesor operator ==(Universidad u,EClases clase)
        {
            
            foreach (Profesor item in u.profesores)
            {
                if (item==clase)
                {
                    return item;

                }
               
            }
            throw new SinProfesorException();
        }
        #endregion
    }
}
