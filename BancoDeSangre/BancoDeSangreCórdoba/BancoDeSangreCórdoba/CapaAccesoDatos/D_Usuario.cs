using BancoDeSangreCórdoba.CapaLógica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeSangreCórdoba.CapaAccesoDatos
{
    public class D_Usuario
    {
        public static Usuario GetUsuario(string nickname, string password)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cnn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ObtenerUsuario";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nickname", nickname);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cnn.Open();
                cmd.Connection = cnn;
                SqlDataReader lector = cmd.ExecuteReader();
                if (lector != null && lector.Read())
                {
                    bool esAdministrador = bool.Parse(lector["es_administrador"].ToString());
                    int legajoUsuario = int.Parse(lector["legajo_empleado"].ToString());
                    Usuario usuario = new Usuario(nickname, password, esAdministrador, legajoUsuario);
                    return usuario;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cnn.Close();
            }
        }

        public static bool ValidarUsuario(string nickname, string password)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cnn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;
                SqlCommand cmd = new SqlCommand();
                string consulta = "ObtenerUsuario";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nickname", nickname);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cnn.Open();
                cmd.Connection = cnn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                if (tabla.Rows.Count == 1)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }
                return resultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cnn.Close();
            }
        }

        public static bool ValidarNickname(string nickname)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cnn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;
                SqlCommand cmd = new SqlCommand();
                string consulta = "ObtenerUsuarioPorNombre";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nickname", nickname);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cnn.Open();
                cmd.Connection = cnn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                if (tabla.Rows.Count == 1)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }
                return resultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cnn.Close();
            }
        }

        public static bool RegistrarUsuario(string nickname, string password, int legajo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cnn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "RegistrarUsuario";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nickname", nickname);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@esAdministrador", false);
                cmd.Parameters.AddWithValue("@legajoEmpleado", legajo);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cnn.Open();
                cmd.Connection = cnn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cnn.Close();
            }
            return resultado;
        }

        public static Usuario GetUsuario(int legajo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cnn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ObtenerUsuarioPorLegajo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@legajo", legajo);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cnn.Open();
                cmd.Connection = cnn;
                SqlDataReader lector = cmd.ExecuteReader();
                if (lector != null && lector.Read())
                {
                    string nickname = lector["nombre_usuario"].ToString();
                    string password = lector["password"].ToString();
                    bool esAdministrador = bool.Parse(lector["es_administrador"].ToString());
                    Usuario usuario = new Usuario(nickname, password, esAdministrador, legajo);
                    return usuario;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cnn.Close();
            }
        }

        public static bool ActualizarUsuario(int legajo, string nickname, string password)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cnn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ActualizarUsuario";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nickname", nickname);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@legajo", legajo);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cnn.Open();
                cmd.Connection = cnn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cnn.Close();
            }
            return resultado;
        }

        public static bool ActualizarPasswordUsuario(int legajo, string password)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cnn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ActualizarPasswordUsuario";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@legajo", legajo);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cnn.Open();
                cmd.Connection = cnn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cnn.Close();
            }
            return resultado;
        }
    }
}
