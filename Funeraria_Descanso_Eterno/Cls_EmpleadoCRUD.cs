using Finisar.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Funeraria_Descanso_Eterno.Cls_EmpleadoCRUD;

namespace Funeraria_Descanso_Eterno
{
    public class Cls_EmpleadoCRUD
    {

        public class ConexionSQLite
        {
            private static ConexionSQLite instancia;
            private SQLiteConnection conexion;
            SQLiteCommand cmd_sqlite;


            private ConexionSQLite()
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

            public static ConexionSQLite Instancia
            {
                get
                {
                    if (instancia == null)
                    {
                        instancia = new ConexionSQLite();
                    }

                    return instancia;
                }
            }

            public SQLiteConnection ObtenerConexion()
            {
                return conexion;
            }
        }



        public class EmpleadoDB
        {
            SQLiteConnection conexion_sqlite;
            SQLiteCommand cmd_sqlite;


            public void employee()
            {
                try
                {
                    // Obtener la conexión a SQLite
                    conexion_sqlite = ConexionSQLite.Instancia.ObtenerConexion();
                    cmd_sqlite = conexion_sqlite.CreateCommand();

                    // Activar claves foráneas (opcional en este caso, no hay claves foráneas en esta tabla)
                    cmd_sqlite.CommandText = "PRAGMA foreign_keys = ON;";
                    cmd_sqlite.ExecuteNonQuery();

                    // Crear la tabla tabla_empleado con los campos solicitados
                    cmd_sqlite.CommandText = @"
CREATE TABLE tabla_empleado (
    IdEmpleado INTEGER PRIMARY KEY,
    Tipo_Documento TEXT,
    CedulaEmpleado TEXT,
    NombreEmpleado TEXT,
    ApellidoPEmpleado TEXT,
    ApellidoMEmpleado TEXT,
    FechaNacimientoEmpleado TEXT,
    SexoEmpleado TEXT,
    RolEmpleado TEXT,
    DepartamentoEmpleado TEXT,
    CiudadEmpleado TEXT,
    DireccionEmpleado TEXT,
    CelularEmpleado TEXT,
    EmailEmpleado TEXT
);";

                    cmd_sqlite.ExecuteNonQuery();
                    MessageBox.Show("Tabla 'tabla_empleado' creada correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al crear la tabla 'tabla_empleado': " + ex.Message);
                }
            }


            public void insertroles()
            {
                try
                {
                    SQLiteConnection conexion_sqlite = ConexionSQLite.Instancia.ObtenerConexion();
                    SQLiteCommand cmd_sqlite = conexion_sqlite.CreateCommand();

                    // Insertar roles únicos
                    cmd_sqlite.CommandText = @"
 
        INSERT INTO tabla_rol (Nombre) VALUES ('Administrador');


    ";
                    cmd_sqlite.ExecuteNonQuery();

                    MessageBox.Show("Roles insertados correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar roles: " + ex.Message);
                }





            }
            public int InsertarEmpleado(ClsEmpleado emp)
            {
                int idEmpleado = -1;

                try
                {
                    SQLiteConnection conexion_sqlite = ConexionSQLite.Instancia.ObtenerConexion();
                    SQLiteCommand cmd_sqlite = conexion_sqlite.CreateCommand();

                    cmd_sqlite.CommandText = $@"
        INSERT INTO tabla_empleado 
        (Tipo_Documento,CedulaEmpleado, NombreEmpleado, ApellidoPEmpleado, ApellidoMEmpleado, FechaNacimientoEmpleado, SexoEmpleado, RolEmpleado,
        DepartamentoEmpleado, CiudadEmpleado, DireccionEmpleado, CelularEmpleado, EmailEmpleado)
        VALUES ('{emp.Tdoc_E}','{emp.Cedula_E}', '{emp.Nombre_E}', '{emp.ApellidoP_E}', '{emp.ApellidoM_E}', 
                '{emp.F_Nacimiento_E}', '{emp.Sexo_E}', '{emp.REF_Rol}', '{emp.Depto_E}',
                '{emp.Ciudad_E}', '{emp.Direccion_E}', '{emp.Celular_E}', '{emp.Mail_E}');";

                    cmd_sqlite.ExecuteNonQuery();

                    // Obtener el ID recién insertado
                    cmd_sqlite.CommandText = "SELECT last_insert_rowid();";
                    idEmpleado = Convert.ToInt32(cmd_sqlite.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }

                return idEmpleado;
            }

            public void Mostrarempleado(DataGridView dgv)
            {
                SQLiteDataReader reader = null;
                try
                {
                    dgv.Rows.Clear(); // Limpiar filas anteriores si es necesario

                    conexion_sqlite = ConexionSQLite.Instancia.ObtenerConexion();
                    cmd_sqlite = conexion_sqlite.CreateCommand();
                    cmd_sqlite.CommandText = "SELECT * FROM tabla_empleado";

                    reader = cmd_sqlite.ExecuteReader();
                    while (reader.Read())
                    {
                        dgv.Rows.Add(
       reader["IdEmpleado"].ToString(),
       reader["NombreEmpleado"].ToString(),
       reader["ApellidoPEmpleado"].ToString(),
       reader["RolEmpleado"].ToString(),
       reader["CelularEmpleado"].ToString(),
       reader["EmailEmpleado"].ToString()

   );

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al mostrar los empleados: " + ex.Message);
                }
                finally
                {
                    if (reader != null && !reader.IsClosed)
                        reader.Close();

                    if (cmd_sqlite != null)
                        cmd_sqlite.Dispose();
                }

            }
            // Método para obtener los datos de un empleado específico por su ID
            // Método para obtener los datos de un empleado específico por su ID
            public SQLiteDataReader ObtenerEmpleadoPorCed(string Cedula)
            {
                SQLiteDataReader reader = null;

                try
                {
                    // Obtener la conexión a la base de datos
                    SQLiteConnection conexion_sqlite = ConexionSQLite.Instancia.ObtenerConexion();
                    SQLiteCommand cmd_sqlite = conexion_sqlite.CreateCommand();

                    // Usar interpolación de cadenas para insertar el valor del ID en la consulta
                    cmd_sqlite.CommandText = $"SELECT * FROM tabla_empleado WHERE CedulaEmpleado = {Cedula};";

                    // Ejecutar la consulta
                    reader = cmd_sqlite.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el empleado: " + ex.Message);
                }

                return reader;
            }



            public void BuscarPorCodigoempl(DataGridView dgv, string codigo)
            {
                // Declarar el lector para recorrer los resultados de la consulta
                SQLiteDataReader reader = null;


                try
                {
                    dgv.Rows.Clear();

                    conexion_sqlite = ConexionSQLite.Instancia.ObtenerConexion();
                    cmd_sqlite = conexion_sqlite.CreateCommand();

                    // Establecer y ejecutar la consulta para buscar productos cuyo Código contenga el texto ingresado
                    cmd_sqlite.CommandText = $"SELECT * FROM tabla_empleado WHERE NombreEmpleado LIKE '%{codigo}%'";
                    reader = cmd_sqlite.ExecuteReader();

                    // Leer todos los registros encontrados y agregarlos al DataGridView
                    while (reader.Read())
                    {
                        dgv.Rows.Add(
                              reader["IdEmpleado"].ToString(),
       reader["NombreEmpleado"].ToString(),
       reader["ApellidoPEmpleado"].ToString(),
       reader["RolEmpleado"].ToString(),
       reader["CelularEmpleado"].ToString(),
       reader["EmailEmpleado"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar el producto: " + ex.Message);
                }
                finally
                {
                    // Cerrar el lector si está abierto
                    if (reader != null && !reader.IsClosed)
                        reader.Close();

                    // Liberar el recurso del comando
                    if (cmd_sqlite != null)
                        cmd_sqlite.Dispose();

                }
            }
            // Método para actualizar los datos de un empleado
            public static void ActualizarEmpleado(string tipoDocumento, string cedula, string nombre, string apellidoP, string apellidoM, string fechaNacimiento, string sexo, string rol, string departamento, string ciudad, string direccion, string celular, string email)
            {
                try
                {
                    SQLiteConnection conexion_sqlite = ConexionSQLite.Instancia.ObtenerConexion();
                    SQLiteCommand cmd_sqlite = conexion_sqlite.CreateCommand();
                    cmd_sqlite.CommandText = $@"
                UPDATE tabla_empleado
                SET 
                    Tipo_Documento = '{tipoDocumento}', 
                    CedulaEmpleado = '{cedula}', 
                    NombreEmpleado = '{nombre}', 
                    ApellidoPEmpleado = '{apellidoP}', 
                    ApellidoMEmpleado = '{apellidoM}', 
                    FechaNacimientoEmpleado = '{fechaNacimiento}', 
                    SexoEmpleado = '{sexo}', 
                    RolEmpleado = '{rol}', 
                    DepartamentoEmpleado = '{departamento}', 
                    CiudadEmpleado = '{ciudad}', 
                    DireccionEmpleado = '{direccion}', 
                    CelularEmpleado = '{celular}', 
                    EmailEmpleado = '{email}'
                WHERE CedulaEmpleado = {cedula};
            ";
                    cmd_sqlite.ExecuteNonQuery();
                    MessageBox.Show("Empleado actualizado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el empleado: " + ex.Message);
                }
            }
            public bool EliminarEmplPorCodigo(string codigo)
            {
                try
                {
                    conexion_sqlite = ConexionSQLite.Instancia.ObtenerConexion();
                    cmd_sqlite = conexion_sqlite.CreateCommand();

                    cmd_sqlite.CommandText = $"SELECT COUNT(*) FROM tabla_empleado WHERE IdEmpleado = '{codigo}'";

                    // Ejecutar la consulta y obtener la cantidad de coincidencias
                    long count = Convert.ToInt64(cmd_sqlite.ExecuteScalar());

                    // Si no existe ningún producto con ese código, mostrar un mensaje y salir
                    if (count == 0)
                    {
                        MessageBox.Show("El producto con el código " + codigo + " no existe en la base de datos.");
                        return false;
                    }

                    // Si existe, proceder a eliminarlo
                    cmd_sqlite.CommandText = $"DELETE FROM tabla_empleado WHERE IdEmpleado = '{codigo}'";
                    int filasAfectadas = cmd_sqlite.ExecuteNonQuery();

                    // Verificar si realmente se eliminó (si se afectó al menos una fila)
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Producto eliminado correctamente.");
                        return true;
                    }
                    else
                    {
                        // Por si algo salió mal y no se eliminó nada
                        MessageBox.Show("No se pudo eliminar el producto.");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el producto: " + ex.Message);
                    return false;
                }
                finally
                {
                    // Liberar recursos aunque haya éxito o error
                    // Liberar el comando
                    if (cmd_sqlite != null)
                        cmd_sqlite.Dispose();

                    // Cerrar la conexión a la base de datos
                }
            }
            public bool BuscarEmpleado(string textoBusqueda, out string codigo, out string nombre)
            {
                // Declarar el lector de datos
                SQLiteDataReader reader = null;

                // Inicializar los valores de salida
                codigo = "";
                nombre = "";

                try
                {
                    conexion_sqlite = ConexionSQLite.Instancia.ObtenerConexion();
                    cmd_sqlite = conexion_sqlite.CreateCommand();

                    cmd_sqlite.CommandText = $"SELECT * FROM tabla_empledao WHERE CedulaEmpleado LIKE '%{textoBusqueda}%' OR NombreEmpleado LIKE '%{textoBusqueda}%'";
                    reader = cmd_sqlite.ExecuteReader();

                    if (reader.Read())
                    {
                        codigo = reader["Cedula_E"].ToString();
                        nombre = reader["Nombre_E"].ToString();

                        // Retornar true indicando que se encontró un producto
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar el producto: " + ex.Message);
                }
                finally
                {
                    if (reader != null && !reader.IsClosed)
                        reader.Close();

                    // Liberar recursos del comando
                    if (cmd_sqlite != null)
                        cmd_sqlite.Dispose();

                }

                return false;
            }

            public void ModificarEmpld(int id, string tipoDoc, string nroDoc, string nombre, string apellidoP, string apellidoM, string nacimiento, string sexo, string rol, string departamento, string ciudad, string direccion, string celular, string correo)
            {
                try
                {
                    conexion_sqlite = Cls_ConexionDB.Instancia.ObtenerConexion();
                    cmd_sqlite = conexion_sqlite.CreateCommand();

                    cmd_sqlite.CommandText = $@"
            UPDATE tabla_empleado 
            SET 
                Tipo_Documento = '{tipoDoc}', 
                CedulaEmpleado = '{nroDoc}',
                NombreEmpleado = '{nombre}', 
                ApellidoPEmpleado = '{apellidoP}', 
                ApellidoMEmpleado = '{apellidoM}', 
                FechaNacimientoEmpleado = '{nacimiento}', 
                SexoEmpleado = '{sexo}', 
                RolEmpleado = '{rol}', 
                DepartamentoEmpleado = '{departamento}', 
                CiudadEmpleado = '{ciudad}', 
                DireccionEmpleado = '{direccion}', 
                CelularEmpleado = '{celular}', 
                EmailEmpleado = '{correo}'
            WHERE IdEmpleado = '{id}'"; // Asumiendo que 'NumeroDocumento' es la clave primaria
                    cmd_sqlite.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar el empleado: " + ex.Message);
                }
            }




            public ClsEmpleado ObtenerEmpleadoPorID(int id)
            {
                ClsEmpleado emp = null;
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=DBFunebre.db;Version=3;"))
                {
                    conn.Open();
                    string query = $"SELECT * FROM tabla_empleado WHERE IdEmpleado = {id}";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            emp = new ClsEmpleado
                            {
                                ID_Empleado = reader.GetInt32(reader.GetOrdinal("IdEmpleado")),
                                Tdoc_E = reader["Tipo_Documento"].ToString(),
                                Cedula_E = reader["CedulaEmpleado"].ToString(),
                                Nombre_E = reader["NombreEmpleado"].ToString(),
                                ApellidoP_E = reader["ApellidoPEmpleado"].ToString(),
                                ApellidoM_E = reader["ApellidoMEmpleado"].ToString(),
                                F_Nacimiento_E = reader["FechaNacimientoEmpleado"].ToString(),
                                Sexo_E = reader["SexoEmpleado"].ToString(),
                                REF_Rol = reader["RolEmpleado"].ToString(),
                                Depto_E = reader["DepartamentoEmpleado"].ToString(),
                                Ciudad_E = reader["CiudadEmpleado"].ToString(),
                                Direccion_E = reader["DireccionEmpleado"].ToString(),
                                Celular_E = reader["CelularEmpleado"].ToString(),
                                Mail_E = reader["EmailEmpleado"].ToString()
                            };
                        }
                    }
                }

                return emp;
            }


        }






    }


}










