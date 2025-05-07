using Finisar.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
