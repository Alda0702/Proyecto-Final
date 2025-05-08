using Finisar.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funeraria_Descanso_Eterno
{
    internal class Cls_ServiciosCRUD
    {
        SQLiteConnection conexion_sqlite;
        SQLiteCommand cmd_sqlite;

        public void InsertarServicios(string Nombre, string Descripcion, string Categoria, int DuracioEst, decimal Precio)
        {

            try
            {
                conexion_sqlite = Cls_ConexionDB.Instancia.ObtenerConexion();
                cmd_sqlite = conexion_sqlite.CreateCommand();

                cmd_sqlite.CommandText = $"INSERT INTO tabla_servicio(NombreServ, DescripcionServ,CategoriaServ,DuracionEstimadaServ,PrecioServ)VALUES  ('{Nombre}','{Descripcion}', '{Categoria} ', ' {DuracioEst}' , {Precio})";
                cmd_sqlite.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el Servicio: " + ex.Message);
            }
        }

        //este es para cargar la tabla por defecto
        public void mostrardata(DataGridView dgv)
        {
            SQLiteDataReader datareader_sqlite;
            try
            {
                conexion_sqlite = Cls_ConexionDB.Instancia.ObtenerConexion();
                cmd_sqlite = conexion_sqlite.CreateCommand();

                cmd_sqlite.CommandText = $"Select * FROM tabla_servicio";
                cmd_sqlite.ExecuteNonQuery();
                datareader_sqlite = cmd_sqlite.ExecuteReader();

                while (datareader_sqlite.Read())
                {
                    dgv.Rows.Add(datareader_sqlite["CodigoServ"].ToString(), datareader_sqlite["NombreServ"].ToString(), datareader_sqlite["DescripcionServ"].ToString(), datareader_sqlite["CategoriaServ"].ToString(), Convert.ToDecimal(datareader_sqlite["PrecioServ"]).ToString("F2"), datareader_sqlite["DuracionEstimadaServ"].ToString());
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los datos: " + ex.Message);
            }

        }

        // y este recibe un string para buscar por nombre
        public void mostrardata(DataGridView dgv, string busq)
        {
            SQLiteDataReader datareader_sqlite;
            try
            {
                conexion_sqlite = Cls_ConexionDB.Instancia.ObtenerConexion();
                cmd_sqlite = conexion_sqlite.CreateCommand();

                cmd_sqlite.CommandText = $"SELECT * FROM tabla_servicio WHERE NombreServ LIKE '%{busq}%'";
                cmd_sqlite.ExecuteNonQuery();
                datareader_sqlite = cmd_sqlite.ExecuteReader();


                while (datareader_sqlite.Read())
                {
                    dgv.Rows.Add(datareader_sqlite["CodigoServ"].ToString(), datareader_sqlite["NombreServ"].ToString(), datareader_sqlite["DescripcionServ"].ToString(), datareader_sqlite["CategoriaServ"].ToString(), Convert.ToDecimal(datareader_sqlite["PrecioServ"]).ToString("F2"), datareader_sqlite["DuracionEstimadaServ"].ToString());
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

                cmd_sqlite.CommandText = $"Delete From tabla_servicio Where CodigoServ = {id} ";
                cmd_sqlite.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar Servicio" + ex.Message);
            }
        }


        public void ModificarServicio(int id, string Nombre, string Descripcion, string Categoria, int DuracioEst, decimal Precio)
        {
            try
            {
                conexion_sqlite = Cls_ConexionDB.Instancia.ObtenerConexion();
                cmd_sqlite = conexion_sqlite.CreateCommand();

                cmd_sqlite.CommandText = $"UPDATE tabla_servicio SET NombreServ = '{Nombre}', DescripcionServ = '{Descripcion}', CategoriaServ = '{Categoria}', DuracionEstimadaServ = {DuracioEst}, PrecioServ = {Precio} WHERE CodigoServ = {id}";
                cmd_sqlite.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el Servicio: " + ex.Message);
            }
        }


        //esto se va ahora
        public void ALTER()
        {
            conexion_sqlite = Cls_ConexionDB.Instancia.ObtenerConexion();
            cmd_sqlite = conexion_sqlite.CreateCommand();

            cmd_sqlite.CommandText = $"INSERT into datalles_Servicio (Ref_Venta,ref_Servicio,cantidad) VALUES\r\n(1,2,1)";
            cmd_sqlite.ExecuteNonQuery();
        }
    }
}