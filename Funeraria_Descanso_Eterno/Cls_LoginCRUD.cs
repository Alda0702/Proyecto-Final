using Finisar.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funeraria_Descanso_Eterno
{

    public class Cls_LoginCRUD
    {
        public static bool AutenticarUsuario(string usuario, string contraseña, out string rol)
        {
            rol = "";
            SQLiteConnection conn = Cls_ConexionDB.Instancia.ObtenerConexion();

            try
            {
                string query = $"SELECT RolEmpleado FROM tabla_loguin WHERE Usuario = '{usuario}' AND Pass = '{contraseña}'";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        rol = result.ToString();
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al autenticar: " + ex.Message);
                return false;
            }
        }
        public string Mostrarlogin1()
        {
            SQLiteDataReader reader = null;
            StringBuilder resultado = new StringBuilder();
            SQLiteConnection conexion_sqlite;
            SQLiteCommand cmd_sqlite;

            try
            {
                conexion_sqlite = Cls_ConexionDB.Instancia.ObtenerConexion();
                cmd_sqlite = conexion_sqlite.CreateCommand();
                cmd_sqlite.CommandText = "SELECT * FROM tabla_loguin";

                reader = cmd_sqlite.ExecuteReader();

                while (reader.Read())
                {
                    List<string> campos = new List<string>();

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        campos.Add(reader[i].ToString());
                    }

                    resultado.AppendLine(string.Join(";", campos));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar el login: " + ex.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                    reader.Close();


            }

            return resultado.ToString();
        }

        public string MostrarRol1()
        {
            SQLiteDataReader reader = null;
            StringBuilder resultado = new StringBuilder();
            SQLiteConnection conexion_sqlite;
            SQLiteCommand cmd_sqlite;

            try
            {
                conexion_sqlite = Cls_ConexionDB.Instancia.ObtenerConexion();
                cmd_sqlite = conexion_sqlite.CreateCommand();
                cmd_sqlite.CommandText = "SELECT * FROM tabla_rol";

                reader = cmd_sqlite.ExecuteReader();

                while (reader.Read())
                {
                    List<string> campos = new List<string>();

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        campos.Add(reader[i].ToString());
                    }

                    resultado.AppendLine(string.Join(";", campos));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar el rol: " + ex.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                    reader.Close();


            }

            return resultado.ToString();
        }

    }
}
