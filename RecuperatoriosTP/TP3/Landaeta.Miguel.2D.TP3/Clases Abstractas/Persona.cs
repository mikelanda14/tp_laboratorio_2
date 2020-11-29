using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;


namespace EntidadesAbstractas
{
    public  abstract class Persona
    {
        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }
        #region Atributos
            private string apellido;
            private int dni;
            private ENacionalidad nacionalidad;
            private string nombre;
        #endregion

        #region Constructores

        /// <summary>
        /// constructor tipo persona por defecto
        /// </summary>
        public Persona()
        {

        }
        /// <summary>
        /// constructor que inicializa los atributos de persona, utilizado por todas las clases que heredan.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido,ENacionalidad nacionalidad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacionalidad = nacionalidad;
        }
        /// <summary>
        /// sobrecarga de constructor utiliza porpiedad DNI para inisializar atributo dni
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido,int dni,ENacionalidad nacionalidad):this(nombre,apellido,nacionalidad)
        {
            this.DNI =  dni;
        }
        /// <summary>
        /// sobrecarga constructor persona utiliza propiedad StringToDNI para inicializar atributo dni previamente validado el valor
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }
        #endregion


        #region Propiedades
        /// <summary>
        /// Propiedad que devuelve o setea el apellido de la persona
        /// </summary>
        public string Apellido 
        { 
            get 
            { 
                return this.apellido;
            }

            set
            {
                this.apellido = this.ValidarNombreApellido(value);
            } 
        
        
        }
        /// <summary>
        /// propieadad que devuelve o setea el DNi de la persona
        /// </summary>
        public int DNI
        { 
            get { 
                
                return this.dni;
            } 
            set 
            {
                this.dni = this.ValidarDni(nacionalidad, value); 
            }
        }
        /// <summary>
        /// Devuelve o setea la nacionalidad
        /// </summary>
        public ENacionalidad Nacionalidad {
            get 
            { 
                return this.nacionalidad;
            } 
            set 
            {
                this.nacionalidad=value; 
            }
        }
        /// <summary>
        /// devuleve o setea el nombre
        /// </summary>
        public string Nombre 
        {
            get 
            {
                return this.nombre; 
            } 
            set 
            {
                this.nombre = this.ValidarNombreApellido(value);
            } 
        }
        /// <summary>
        /// setea el Dni de la persona utilizando el metodo Validar
        /// </summary>
        public string StringToDNI
        { 
            set 
            {
              this.dni=  this.ValidarDni(this.nacionalidad, value); 
            } 
        }
        #endregion

        #region Metodos
        /// <summary>
        /// sobre escribe metodo ToString para el objeto pesona haciendo publico sus atributos atraves de el retorno de un string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"NOMBRE COMPLETO:{this.Apellido}, {this.Nombre}");
            sb.AppendLine($"NACIONALIDAD:{this.Nacionalidad}");
            return sb.ToString();
        }
        /// <summary>
        /// metodo previo a validar Dni transforma el dato de int a string asi lo toma validar dni 
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns></returns>
        
        private int ValidarDni(ENacionalidad nacionalidad,int dato)
        {
            return this.ValidarDni(nacionalidad, dato.ToString());
        }
        /// <summary>
        /// Metodo se encarga de validar el Dni de la persona corresponda con la nacionalidad y sea un valor dentro de los paramentros 1 y 99999999
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns></returns>
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int retorno = 0;
            //int aux;
            if (int.TryParse(dato.ToString(),out int aux) && dato.Length <= 11 && dato.Length >= 4)
            {
                if (nacionalidad == ENacionalidad.Argentino && (aux > 1 && aux <= 89999999))
                {
                    retorno = aux;
                } 
                else if (nacionalidad == ENacionalidad.Extranjero && (aux >= 89999999 && aux <= 99999999))
                {
                    retorno = aux;
                }
                else
                {
                    throw new NacionalidadInvalidaException();
                }

            }
            else
            {
                throw new DniInvalidoException();
            }
            return retorno;

           
        }
        /// <summary>
        /// verifica que el nombre no contenga numeros u otros caracteres que no sean del alfabeto
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>
        private string ValidarNombreApellido(string dato)
        {
            foreach (char item in dato)
            {
                if (!char.IsLetter(item))
                {
                    dato = "";
                    break;
                }
            }

            return dato;
        }
        #endregion
    }

}
