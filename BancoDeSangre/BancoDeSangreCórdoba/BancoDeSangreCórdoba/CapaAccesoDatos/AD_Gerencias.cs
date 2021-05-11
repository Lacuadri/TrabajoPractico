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
    class AD_Gerencias
    {
        public static DataTable GetListadoGerencias()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SPGetListaGerencias";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static DataTable ObtenerIdDireccion()
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "SPGetIdDireccion";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
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
                cn.Close();

            }
        }
       public static bool InsertarGerencia(Gerencias ger)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SPInsertarGerencia";
                cmd.Parameters.AddWithValue("@nombre", ger.Nombre);
                cmd.Parameters.AddWithValue("@dir", ger.IdDir);
                cmd.Parameters.AddWithValue("@leg", ger.LegSup);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
            return resultado;
        }
        public static bool ActualizarGerencias(int iddir, Gerencias ger)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SPActualizarGerencias";
                cmd.Parameters.AddWithValue("@iddir", iddir);
                cmd.Parameters.AddWithValue("@nombre", ger.Nombre);
                cmd.Parameters.AddWithValue("@leg", ger.LegSup);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;
                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();

            }
            return resultado;
        }
    }
}
