    using Finisar.SQLite;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace Funeraria_Descanso_Eterno
    {
        internal class Cls_InventarioCRUD
        {
            public class Inventario
            {
                SQLiteConnection conexion_sqlite;
                SQLiteCommand cmd_sqlite;

                public void InsertarProducto(string Nombre, string Descripcion, string Categoria, int Stock, int Precio)
                {
                    try
                    {
                        conexion_sqlite = Cls_ConexionDB.Instancia.ObtenerConexion();
                        cmd_sqlite = conexion_sqlite.CreateCommand();
                        cmd_sqlite.CommandText = $"INSERT INTO tabla_inventario (NombreProd, DescripcionProd, CategoriaProd, CantidadProd, PrecioProd) " + $"VALUES ('{Nombre}', '{Descripcion}', '{Categoria}', {Stock}, {Precio})";
                        cmd_sqlite.ExecuteNonQuery();
                    }
                    catch(Exception ex) 
                    {
                        MessageBox.Show("Error al insertar el producto: " + ex.Message);

                    }
                }
            }

            public void MostrarInventario(DataGridView dgv)
            {
                SQLiteConnection conexion_sqlite;
                SQLiteCommand cmd_sqlite;
                SQLiteDataReader reader = null;

                try
                {
                    dgv.Rows.Clear();
                    conexion_sqlite = Cls_ConexionDB.Instancia.ObtenerConexion();
                    cmd_sqlite = conexion_sqlite.CreateCommand();

                    cmd_sqlite.CommandText = "SELECT * FROM tabla_inventario";
                    reader = cmd_sqlite.ExecuteReader();

                    while (reader.Read()) 
                    {
                        dgv.Rows.Add(reader["CodigoProd"].ToString(),reader["NombreProd"].ToString(),reader["DescripcionProd"].ToString(),reader["CategoriaProd"].ToString(),reader["CantidadProd"].ToString(),reader["PrecioProd"].ToString());
                    }

                }
                catch (Exception ex) 
                {
                    MessageBox.Show("Error al mostrar el inventario: " + ex.Message);
                }

            }

            public void BoscarProducto(DataGridView dgv, string texto)
            {
                SQLiteConnection conexion_sqlite;
                SQLiteCommand cmd_sqlite;
                SQLiteDataReader reader = null;


                try
                {
                    dgv.Rows.Clear();

                    conexion_sqlite = Cls_ConexionDB.Instancia.ObtenerConexion();
                    cmd_sqlite = conexion_sqlite.CreateCommand();
                    cmd_sqlite.CommandText = @"SELECT * FROM tabla_inventario WHERE CodigoProd LIKE @texto OR NombreProd LIKE @texto";
                    cmd_sqlite.Parameters.Add("@texto", $"%{texto}%");
                    reader = cmd_sqlite.ExecuteReader();

                    while (reader.Read())
                    {
                        dgv.Rows.Add(reader["CodigoProd"].ToString(), reader["NombreProd"].ToString(), reader["DescripcionProd"].ToString(), reader["CategoriaProd"].ToString(), reader["CantidadProd"].ToString(), reader["PrecioProd"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar el producto: " + ex.Message);
                }
            }

            public void EliminarProducto(int codigoProducto)
            {
                SQLiteConnection conexion_sqlite;
                SQLiteCommand cmd_sqlite;

                try
                {
                    conexion_sqlite = Cls_ConexionDB.Instancia.ObtenerConexion();
                    cmd_sqlite = conexion_sqlite.CreateCommand();

                    cmd_sqlite.CommandText = "DELETE FROM tabla_inventario WHERE CodigoProd = @codigo";
                    cmd_sqlite.Parameters.Add(new SQLiteParameter("@codigo", DbType.Int32) { Value = codigoProducto });
                    int filasAfectadas = cmd_sqlite.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Producto eliminado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontró el producto con el código proporcionado.");
                }
                
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el producto: " + ex.Message);

                }
            }
        public void ModificarProducto(int id, string Nombre, string Descripcion, string Categoria, int Cantidad, decimal Precio)
        {
            SQLiteConnection conexion_sqlite;
            SQLiteCommand cmd_sqlite;

            try
            {
                conexion_sqlite = Cls_ConexionDB.Instancia.ObtenerConexion();
                cmd_sqlite = conexion_sqlite.CreateCommand();

                cmd_sqlite.CommandText = $"UPDATE tabla_inventario SET NombreProd = '{Nombre}', DescripcionProd = '{Descripcion}', CategoriaProd = '{Categoria}', CantidadProd = {Cantidad}, PrecioProd = {Precio} WHERE CodigoProd = {id}";
                cmd_sqlite.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el Producto: " + ex.Message);
            }
        }


        public string MostrarInventario1()
        {
            SQLiteDataReader reader = null;
            StringBuilder resultado = new StringBuilder();
            SQLiteConnection conexion_sqlite;
            SQLiteCommand cmd_sqlite;

            try
            {
                conexion_sqlite = Cls_ConexionDB.Instancia.ObtenerConexion();
                cmd_sqlite = conexion_sqlite.CreateCommand();
                cmd_sqlite.CommandText = "SELECT * FROM tabla_inventario";

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
                MessageBox.Show("Error al mostrar el inventario: " + ex.Message);
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
