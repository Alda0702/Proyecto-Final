using Finisar.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funeraria_Descanso_Eterno
{
    internal class Cls_ProveedoresCRUD
    {
        SQLiteConnection conexion_sqlite;
        SQLiteCommand cmd_sqlite;

        public void InsertarProveedores(string Nombre, string Ciudad, string Contacto, string Email)
        {

            try
            {
                conexion_sqlite = Cls_ConexionDB.Instancia.ObtenerConexion();
                cmd_sqlite = conexion_sqlite.CreateCommand();

                cmd_sqlite.CommandText = $"INSERT INTO tabla_proveedores(NombreProv,CiudadProv,ContactoProv,EmailProv)VALUES  ('{Nombre}', '{Ciudad} ', ' {Contacto}' , '{Email}')";

                cmd_sqlite.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el proveedor: " + ex.Message);
            }
        }

        public void mostrardataProv(DataGridView dgv, string busq)
        {
            SQLiteDataReader datareader_sqlite;
            try
            {
                conexion_sqlite = Cls_ConexionDB.Instancia.ObtenerConexion();
                cmd_sqlite = conexion_sqlite.CreateCommand();

                cmd_sqlite.CommandText = $"SELECT * FROM tabla_proveedores WHERE NombreProv LIKE '%{busq}%'";
                cmd_sqlite.ExecuteNonQuery();
                datareader_sqlite = cmd_sqlite.ExecuteReader();


                while (datareader_sqlite.Read())
                {
                    dgv.Rows.Add(datareader_sqlite["CodigoProv"].ToString(), datareader_sqlite["NombreProv"].ToString(), datareader_sqlite["CiudadProv"].ToString(), datareader_sqlite["EmailProv"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los datos: " + ex.Message);
            }

        }

        public void mostrardataProv(DataGridView dgv)
        {
            SQLiteDataReader datareader_sqlite;
            try
            {
                conexion_sqlite = Cls_ConexionDB.Instancia.ObtenerConexion();
                cmd_sqlite = conexion_sqlite.CreateCommand();

                cmd_sqlite.CommandText = $"Select * FROM tabla_proveedores";
                cmd_sqlite.ExecuteNonQuery();
                datareader_sqlite = cmd_sqlite.ExecuteReader();

                while (datareader_sqlite.Read())
                {
                    dgv.Rows.Add(datareader_sqlite["CodigoProv"].ToString(), datareader_sqlite["NombreProv"].ToString(), datareader_sqlite["ContactoProv"].ToString(), datareader_sqlite["EmailProv"].ToString(), datareader_sqlite["CiudadProv"].ToString());
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los datos: " + ex.Message);
            }

        }

        public void EliminarRegistroProv(int id)
        {
            try
            {
                conexion_sqlite = Cls_ConexionDB.Instancia.ObtenerConexion();
                cmd_sqlite = conexion_sqlite.CreateCommand();

                cmd_sqlite.CommandText = $"Delete From tabla_proveedores Where CodigoProv = {id} ";
                cmd_sqlite.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar proveedor" + ex.Message);
            }
        }

        public void ModificarProveedor(int CodigoProv, string Nombre, string Ciudad, string Contacto, string Email)
        {
            try
            {
                conexion_sqlite = Cls_ConexionDB.Instancia.ObtenerConexion();
                cmd_sqlite = conexion_sqlite.CreateCommand();

                cmd_sqlite.CommandText = $"UPDATE tabla_proveedores SET NombreProv = '{Nombre}', CiudadProv = '{Ciudad}', ContactoProv = '{Contacto}', EmailProv = '{Email}' WHERE CodigoProv = {CodigoProv}";
                cmd_sqlite.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el proveedor: " + ex.Message);
            }
        }


    }
}
