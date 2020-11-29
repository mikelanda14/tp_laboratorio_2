using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {

        #region Atributos


        int codigo;
        string nombreProducto;
        float precio;
        #endregion

        #region Costructor
        public Producto()
        {

        }
        /// <summary>
        /// Inicializa con los parametros el objeto producto
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="descripcion"></param>
        /// <param name="precio"></param>
        public Producto(int codigo, string descripcion, float precio)
        {
            this.codigo = codigo;
            this.nombreProducto = descripcion;
            this.precio = precio;
        }
        #endregion

        #region Propiedades

        /// <summary>
        /// Propiedades generadas para que pueda mostrar en la lista de productos
        /// </summary>
        public int Codigo 
        {
            get => codigo;
            set => codigo = value; 
        }
        public string Descripcion 
        {
            get => nombreProducto; 
            set => nombreProducto = value;
        }
        public float Precio { 
            get => precio; 
            set => precio = value;
        }

        #endregion

        #region Metodos
        /// <summary>
        /// Muestra  los parametros contenidos en el objeto producto 
        /// </summary>
        /// <returns>retorna un string</returns>
       
        private string MostarProducto()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Codigo.ToString()} {this.Descripcion.ToString()} {this.Precio.ToString()}");
            return sb.ToString();
        }
        /// <summary>
        /// Hace publico el metodo mostrar producto sobrescribiendo el metodo ToString para el objeto Producto.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return MostarProducto();
        }
        #endregion
    }
}
