
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finisar.SQLite;

namespace Funeraria_Descanso_Eterno
{
    internal class Cls_ConexionDB
    {
        SQLiteConnection Cls_Conexion;
        SQLiteCommand cmd_sqlite;

        private static Cls_ConexionDB instancia;
        private SQLiteConnection conexion;

        private Cls_ConexionDB()
        {
            try
            {
                string cadenaConexion = "Data Source=DBFunebre.db;Version=3;Compress=True;";
                conexion = new SQLiteConnection(cadenaConexion);
                conexion.Open();
                // MessageBox.Show("Conectado a la base de datos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
            }
        }

        public static Cls_ConexionDB Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Cls_ConexionDB();
                }

                return instancia;
            }
        }

        public SQLiteConnection ObtenerConexion()
        {
            return conexion;
           
        }
    }
}
