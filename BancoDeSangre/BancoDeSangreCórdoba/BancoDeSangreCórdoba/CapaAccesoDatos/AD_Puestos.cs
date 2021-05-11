using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeSangreCórdoba.CapaAccesoDatos
{
    public class AD_Puestos
    {
        public static DataTable GetListadoPuestos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();



                //cambiamos la consutla de todos los datos de la entidad usaurios
                string consulta = "GetListaTodosPuestos";

                //limpia parametros

                //comando tipo texto en este caso
                //le paso el comando
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                //abrir conexion y asignar comand la conexion
                cn.Open();
                cmd.Connection = cn;

                //creo la tabla
                DataTable tabla = new DataTable();

                //ejecuta la consulta sql a la tabla
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
            }

            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                //importante cerrar la conexion para evitar probelmas de acceso
                cn.Close();
            }
        }

        public static bool modificarPuesto(string letraN, int id)
        {
            {

                bool resultado = false;
                string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
                SqlConnection cn = new SqlConnection(cadenaConexion);
                try
                {
                    //probar Hacer con id
                    SqlCommand cmd = new SqlCommand();
                    string consulta = "ModificarPuesto";
                    cmd.Parameters.AddWithValue("@let", letraN);
                    cmd.Parameters.AddWithValue("@id", id);
                    

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = consulta;

                    cn.Open();
                    cmd.Connection = cn;
                    //no hubo excepciones en la consulta
                    cmd.ExecuteNonQuery();
                    resultado = true;
                }
                catch (Exception)
                {

                    throw;
                }
                return resultado;
            }
        }


            public static bool eliminarPuesto(string letra)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "BorrarPuesto";
                cmd.Parameters.AddWithValue("@let", letra);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                //no hubo excepciones en la consulta
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }

        public static bool insertarPuesto(char letra)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "InsertNuevoPuesto";
                cmd.Parameters.AddWithValue("@let", letra);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                //no hubo excepciones en la consulta
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }

        public static DataTable GetFiltroPuesto(char let)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();



                //cambiamos la consutla de todos los datos de la entidad usaurios
                string consulta = "GetFiltroPuest";

                //limpia parametros

                //comando tipo texto en este caso
                //le paso el comando
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@let", let);
                
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                //abrir conexion y asignar comand la conexion
                cn.Open();
                cmd.Connection = cn;

                //creo la tabla
                DataTable tabla = new DataTable();

                //ejecuta la consulta sql a la tabla
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
            }

            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                //importante cerrar la conexion para evitar probelmas de acceso
                cn.Close();
            }
        }
    }
}
