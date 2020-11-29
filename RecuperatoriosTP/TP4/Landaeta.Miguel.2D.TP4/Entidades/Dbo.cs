using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    public  class Dbo<T>: IArchivo<T> where T : Venta
    {
        static SqlConnection conexionDB;
        /// <summary>
        /// Clase 22 - Bases de datos
        /// Constructro que inicializa la conexion par la BD
        /// </summary>
        static Dbo()
        {

            conexionDB = new SqlConnection("Data Source=localhost\\MSSQLSERVER01; Initial Catalog = Tp4MiguelLandaeta2d ; Integrated security = true ");
        }
        /// <summary>
        /// Clase 21 – SQL
        /// public static void GetMenu() Metodo el cual conecta con la base de datos ejecuta el SELECT * from Productos
        /// </summary>
        public static void GetMenu()
        {
            try
            {
                SqlCommand comandoSql = new SqlCommand();
                comandoSql.Connection = conexionDB;
                comandoSql.CommandType = CommandType.Text;
                comandoSql.CommandText = "SELECT * from Productos";
                if (conexionDB.State != ConnectionState.Open)
                {
                    conexionDB.Open();
                }
                SqlDataReader datosTablaProductos = comandoSql.ExecuteReader();
                while (datosTablaProductos.Read())
                {
                    Deposito.AgregarProductos(int.Parse(datosTablaProductos["ID"].ToString()), datosTablaProductos["NombreProducto"].ToString(), float.Parse(datosTablaProductos["Precio"].ToString()));
                }
            }
            catch (Exception e)
            {

                e.Message.ToString();


            }
            finally
            {
                

                    if (conexionDB.State == ConnectionState.Open)
                    {
                        conexionDB.Close();
                    }
                
            }


        }


        /// <summary>
        /// Clase 17 - Tipos Genéricos:
        /// Clase 18 – Interfaces:
        /// Clase 21 – SQL
        /// public void Guardar( T datos):Guarda los datos utilizando comando SQL Insert into Ventas(Articulos,ImporteTotal) values(@descripcion,@precio
        /// </summary>
        /// <param name="datos"></param>
        public void Guardar( T datos)
        {
            try
            {

                SqlCommand comandoSql = new SqlCommand();
                comandoSql.Connection = conexionDB;
                comandoSql.CommandType = CommandType.Text;
                comandoSql.CommandText = "Insert into Ventas(Articulos,ImporteTotal) values(@descripcion,@precio)";
                comandoSql.Parameters.AddWithValue("@descripcion", datos.Articulos);
                comandoSql.Parameters.AddWithValue("@precio", datos.ImporteTotal);

                if (conexionDB.State != ConnectionState.Open)
                {
                    conexionDB.Open();
                }

                comandoSql.ExecuteReader();

            }
            catch (Exception e)
            {
                e.Message.ToString();


            }
            finally
            {
                
                    if (conexionDB.State == ConnectionState.Open)
                    {
                        conexionDB.Close();
                    }
                
            }
        }

    }
}
