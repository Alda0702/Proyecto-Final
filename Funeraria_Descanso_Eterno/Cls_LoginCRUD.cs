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
        public static bool AutenticarUsuario(string usuario, string contraseña)
        {
            SQLiteConnection conn = Cls_ConexionDB.Instancia.ObtenerConexion();

            try
            {
                string query = $"SELECT COUNT(*) FROM tabla_loguin WHERE Usuario = '{usuario}' AND Pass = '{contraseña}'";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
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
