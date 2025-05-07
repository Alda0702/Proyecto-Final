using Finisar.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Funeraria_Descanso_Eterno.Cls_EmpleadoCRUD;
using System.Windows.Forms;

namespace Funeraria_Descanso_Eterno
{
    public class Cls_UsuariosCRUD
    {


        public class usuariodb
        {
            SQLiteConnection conexion_sqlite;
            SQLiteCommand cmd_sqlite;
            private ClsEmpleado clsempleado;

            public void CrearTablaUsuario()
            {
                try
                {
                    SQLiteConnection conexion_sqlite = ConexionSQLite.Instancia.ObtenerConexion();
                    SQLiteCommand cmd_sqlite = conexion_sqlite.CreateCommand();

                    cmd_sqlite.CommandText = @"
            CREATE TABLE tabla_loguin (
                CodigoLoguin INTEGER PRIMARY KEY,
                Usuario TEXT NOT NULL UNIQUE,
                Pass TEXT NOT NULL,
                RolEmpleado TEXT
            );";

                    cmd_sqlite.ExecuteNonQuery();
                    MessageBox.Show("Tabla Usuario creada correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al crear la tabla Usuario: " + ex.Message);
                }



            }


            public void InsertarUsuario(ClsLogin usr, string idEmpleado)
            {
                try
                {
                    SQLiteConnection conexion_sqlite = ConexionSQLite.Instancia.ObtenerConexion();
                    SQLiteCommand cmd_sqlite = conexion_sqlite.CreateCommand();

                    // Asegúrate de que los nombres de columnas no sean palabras reservadas o ponlos entre comillas dobles
                    cmd_sqlite.CommandText = $@"
            INSERT INTO tabla_loguin 
            (""Usuario"", ""Pass"", ""RolEmpleado"")
            VALUES ('{usr.Usuario}', '{usr.Contraseña}', '{idEmpleado}');";

                    // Puedes mostrar esto como depuración tempora
                    cmd_sqlite.ExecuteNonQuery();

                    MessageBox.Show($"Usuario registrado correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar usuario: " + ex.Message);
                }
            }


        }
    }
}









































