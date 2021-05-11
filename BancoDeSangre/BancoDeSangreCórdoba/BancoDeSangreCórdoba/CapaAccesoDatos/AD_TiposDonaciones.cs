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
    public class AD_TiposDonaciones
    {
        public static DataTable GetListadoTipoDonaciones()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SPGetListaTipoDonaciones";

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
        public static bool insertarTipoDonacion(string nombre)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SPInsertarNuevoTipoDonacion";
                cmd.Parameters.AddWithValue("@tipoDonacion", nombre);
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
            return resultado;
        }
        public static bool EditarTipoDonacion(string nombre, int id)
        {
            {

                bool resultado = false;
                string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
                SqlConnection cn = new SqlConnection(cadenaConexion);
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    string consulta = "SPActualizarTipoDonaciones";
                    cmd.Parameters.AddWithValue("@nuevoNombre", nombre);
                    cmd.Parameters.AddWithValue("@id", id);


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
                return resultado;
            }
        }
        public static bool EliminarTipoDonacion(string nombre)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SPEliminarTipoDonacion";
                cmd.Parameters.AddWithValue("@nombre", nombre);
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
            return resultado;
        }
        public static DataTable GetFiltroTipoDonacion(string nombre)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SPFiltrarTipoDonacion";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", nombre);

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
    }
}
