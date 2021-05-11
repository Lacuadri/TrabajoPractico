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
    public class D_Empleado
    {
        public static Empleado GetNombreApellido(int legajo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cnn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "ObtenerNombreApellidoEmpleado";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@legajo", legajo);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = consulta;

                cnn.Open();
                cmd.Connection = cnn;
                SqlDataReader lector = cmd.ExecuteReader();
                if (lector != null && lector.Read())
                {
                    string apellido = lector["apellido"].ToString();
                    string nombre = lector["nombre"].ToString();
                    Empleado empleado = new Empleado(nombre, apellido);
                    return empleado;
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

        public static bool ValidarLegajo(int legajo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cnn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;
                SqlCommand cmd = new SqlCommand();
                string consulta = "ObtenerEmpleadoPorLegajo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@legajo", legajo);
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
    }
}
