using Finisar.SQLite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace Funeraria_Descanso_Eterno
{
    public class ConexionSQLite
    {
        private static ConexionSQLite instancia;
        private SQLiteConnection conexion;

        // Bandera que indica si la conexión está abierta
        private bool conexionAbierta = false;

        // Constructor privado para que nadie pueda crear instancias directamente
        private ConexionSQLite() { }

        // Propiedad pública para obtener la instancia única de la clase
        public static ConexionSQLite Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new ConexionSQLite();
                return instancia;
            }
        }

        // Método para obtener una conexión abierta a la base de datos
        public SQLiteConnection ObtenerConexion()
        {
            if (conexion == null || conexion.State != ConnectionState.Open)
            {
                // Cadena de conexión a la base de datos SQLite
                string cadenaConexion = "Data Source=DBFunebre.db;Version=3;Compress=True;";

                // Crear nueva conexión
                conexion = new SQLiteConnection(cadenaConexion);
                conexion.Open(); // Abrir la conexión

                // Marcar que la conexión está abierta
                conexionAbierta = true;
            }
            return conexion;  // Devolver la conexión abierta
        }

        // Método para cerrar la conexión abierta
        public void CerrarConexion()
        {
            if (conexionAbierta && conexion != null)
            {
                conexion.Close(); // Cierra la conexión
                conexionAbierta = false; // Marca que ya no está abierta
            }
        }
    }

    //-----------------------------------------------------------------------------------------------------------------

    internal class Cls_ClienteCRUD
    {
        SQLiteConnection conexion_sqlite;
        SQLiteCommand cmd_sqlite;

        public void CrearTablaCliente()
        {
            try
            {
                SQLiteConnection conexion_sqlite = ConexionSQLite.Instancia.ObtenerConexion();
                SQLiteCommand cmd_sqlite = conexion_sqlite.CreateCommand();

                cmd_sqlite.CommandText = @"CREATE TABLE tabla_cliente (IdCliente INTEGER PRIMARY KEY, TipoDocumentoCliente TEXT, CedulaCliente TEXT, NombreCliente TEXT, ApellidoPCliente TEXT, ApellidoMCliente TEXT, FechaNacimientoCliente TEXT, SexoCliente TEXT, Pais TEXT, DepartamentoCliente, CiudadCliente TEXT, DireccionCliente TEXT, CelularCliente TEXT, EmailCliente TEXT);";

                cmd_sqlite.ExecuteNonQuery();
                MessageBox.Show("Tabla cliente creada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear la tabla cliente: " + ex.Message);
            }
        }
        public void InsertarCliente(string tipoc, string doc, string nombre, string apellidoP, string apellidoM, string nacimiento, string sexo, string pais, string depto, string ciudad, string direccion, string telefono, string email)
        {
            try
            {
                conexion_sqlite = ConexionSQLite.Instancia.ObtenerConexion();
                cmd_sqlite = conexion_sqlite.CreateCommand();

                cmd_sqlite.CommandText = $"INSERT INTO tabla_cliente (TipoDocumentoCliente, CedulaCliente, NombreCliente, ApellidoPCliente, ApellidoMCliente, FechaNacimientoCliente, SexoCliente, Pais, DepartamentoCliente, CiudadCliente, DireccionCliente, CelularCliente, EmailCliente)VALUES  ('{tipoc}', '{doc}', '{nombre}', '{apellidoP}', '{apellidoM}', '{nacimiento}', '{sexo} ', '{pais}', '{depto}', '{ciudad}', '{direccion}', '{telefono}', '{email}')";
                cmd_sqlite.ExecuteNonQuery();


                MessageBox.Show("Añadido");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el cliente: " + ex.Message);
            }
        }

        public void mostrarcliente(DataGridView dgv)
        {
            SQLiteDataReader datareader_sqlite;
            try
            {
                conexion_sqlite = Cls_ConexionDB.Instancia.ObtenerConexion();
                cmd_sqlite = conexion_sqlite.CreateCommand();

                cmd_sqlite.CommandText = $"Select * FROM tabla_cliente";
                cmd_sqlite.ExecuteNonQuery();
                datareader_sqlite = cmd_sqlite.ExecuteReader();

                while (datareader_sqlite.Read())
                {
                    dgv.Rows.Add(datareader_sqlite["IdCliente"].ToString(), datareader_sqlite["NombreCliente"].ToString(), datareader_sqlite["ApellidoPCliente"].ToString(), datareader_sqlite["ApellidoMCliente"].ToString(), datareader_sqlite["CelularCliente"].ToString(), datareader_sqlite["EmailCliente"].ToString(), datareader_sqlite["TipoDocumentoCliente"].ToString(), datareader_sqlite["CedulaCliente"].ToString(), datareader_sqlite["FechaNacimientoCliente"].ToString(), datareader_sqlite["SexoCliente"].ToString(), datareader_sqlite["Pais"].ToString(), datareader_sqlite["DepartamentoCliente"].ToString(), datareader_sqlite["CiudadCliente"].ToString(), datareader_sqlite["DireccionCliente"].ToString());
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los datos: " + ex.Message);
            }

        }
        public void mostrarcliente(DataGridView dgv, string bust)
        {
            SQLiteDataReader datareader_sqlite;
            try
            {
                conexion_sqlite = Cls_ConexionDB.Instancia.ObtenerConexion();
                cmd_sqlite = conexion_sqlite.CreateCommand();

                cmd_sqlite.CommandText = $"SELECT * FROM tabla_cliente WHERE NombreCliente LIKE '%{bust}%'";
                cmd_sqlite.ExecuteNonQuery();
                datareader_sqlite = cmd_sqlite.ExecuteReader();


                while (datareader_sqlite.Read())
                {
                    dgv.Rows.Add(datareader_sqlite["IdCliente"].ToString(), datareader_sqlite["NombreCliente"].ToString(), datareader_sqlite["ApellidoPCliente"].ToString(), datareader_sqlite["ApellidoMCliente"].ToString(), datareader_sqlite["CelularCliente"].ToString(), datareader_sqlite["EmailCliente"].ToString(), datareader_sqlite["TipoDocumentoCliente"].ToString(), datareader_sqlite["CedulaCliente"].ToString(), datareader_sqlite["FechaNacimientoCliente"].ToString(), datareader_sqlite["SexoCliente"].ToString(), datareader_sqlite["Pais"].ToString(), datareader_sqlite["DepartamentoCliente"].ToString(), datareader_sqlite["CiudadCliente"].ToString(), datareader_sqlite["DireccionCliente"].ToString());
                }
            }
                                                                                                                                                                                                                    
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los datos: " + ex.Message);
            }

        }
        public void EliminarRegistro(int id)
        {
            try
            {
                conexion_sqlite = Cls_ConexionDB.Instancia.ObtenerConexion();
                cmd_sqlite = conexion_sqlite.CreateCommand();

                cmd_sqlite.CommandText = $"Delete From tabla_cliente Where IdCliente = {id} ";
                cmd_sqlite.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar Cliente" + ex.Message);
            }
        }

        public void ModificarCliente(int id, string tipoc, string doc, string nombre, string apellidoP, string apellidoM, string nacimiento, string sexo, string pais, string depto, string ciudad, string direccion, string telefono, string email)
        {
            try
            {
                conexion_sqlite = Cls_ConexionDB.Instancia.ObtenerConexion();
                cmd_sqlite = conexion_sqlite.CreateCommand();

                cmd_sqlite.CommandText = $"UPDATE tabla_cliente SET TipoDocumentoCliente = '{tipoc}', CedulaCliente = '{doc}', NombreCliente = '{nombre}', ApellidoPCliente = '{apellidoP}', ApellidoMCliente = '{apellidoM}', FechaNacimientoCliente = '{nacimiento}', SexoCliente = '{sexo}', Pais = '{pais}', DepartamentoCliente = '{depto}', CiudadCliente = '{ciudad}', DireccionCliente = '{direccion}', CelularCliente = '{telefono}', EmailCliente = '{email}' WHERE IdCliente = '{id}'";
                cmd_sqlite.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el cliente: " + ex.Message);
            }
        }
        public string Mostrarcliente1()
        {
            SQLiteDataReader reader = null;
            StringBuilder resultado = new StringBuilder();
            SQLiteConnection conexion_sqlite;
            SQLiteCommand cmd_sqlite;

            try
            {
                conexion_sqlite = Cls_ConexionDB.Instancia.ObtenerConexion();
                cmd_sqlite = conexion_sqlite.CreateCommand();
                cmd_sqlite.CommandText = "SELECT * FROM tabla_cliente";

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
                MessageBox.Show("Error al mostrar el cliente: " + ex.Message);
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
