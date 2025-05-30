using Finisar.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Funeraria_Descanso_Eterno
{
    internal class Cls_Factura
    {
        SQLiteConnection conexion_sqlite;
        SQLiteCommand cmd_sqlite;
        SQLiteDataReader datareader_sqlite;

        public void mostrarFacturacion(DataGridView dgv)
        {
            SQLiteDataReader datareader_sqlite;
            try
            {
                conexion_sqlite = Cls_ConexionDB.Instancia.ObtenerConexion();
                cmd_sqlite = conexion_sqlite.CreateCommand();

                cmd_sqlite.CommandText = $"SELECT id, tabla_cliente.NombreCliente, tabla_empleado.NombreEmpleado, fecha from Factura\r\njoin tabla_cliente on tabla_cliente.IdCliente = REF_cliente\r\njoin tabla_empleado on tabla_empleado.IdEmpleado = ref_empleado";
                cmd_sqlite.ExecuteNonQuery();
                datareader_sqlite = cmd_sqlite.ExecuteReader();

                while (datareader_sqlite.Read())
                {
                    dgv.Rows.Add(datareader_sqlite["id"].ToString(), datareader_sqlite["NombreCliente"].ToString(), datareader_sqlite["NombreEmpleado"].ToString(), datareader_sqlite["fecha"].ToString());
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los datos: " + ex.Message);
            }
        }


        public void MostrarFactura(DataGridView dgv, int cod, Label codFact, Label NombreC, Label CedualC, Label UserCC, Label total)
        {
            int totalNeto = 0;
            //llenar los labels
            try
            {
                conexion_sqlite = Cls_ConexionDB.Instancia.ObtenerConexion();
                cmd_sqlite = conexion_sqlite.CreateCommand();

                cmd_sqlite.CommandText = $"SELECT id, cl.NombreCliente, cl.CedulaCliente, em.NombreEmpleado, em.CedulaEmpleado, fecha from Factura fact\r\njoin tabla_cliente cl on cl.IdCliente = fact.REF_cliente\r\njoin tabla_empleado em on em.IdEmpleado = fact.ref_empleado\r\nwhere id = {cod}";
                cmd_sqlite.ExecuteNonQuery();

                datareader_sqlite = cmd_sqlite.ExecuteReader();

                if (datareader_sqlite.Read())
                {
                    //codFact.Text = datareader_sqlite["id"].ToString();
                    codFact.Text = cod.ToString();
                    NombreC.Text = datareader_sqlite["NombreCliente"].ToString();
                    CedualC.Text = datareader_sqlite["CedulaCliente"].ToString();
                    UserCC.Text = datareader_sqlite["NombreEmpleado"].ToString();
                }
                else
                {
                    MessageBox.Show("No se encontró una factura con ese ID.");
                }
                datareader_sqlite.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los datos: " + ex.Message);
            }


            // llenar el datagridview con los porductos
            try
            {
                conexion_sqlite = Cls_ConexionDB.Instancia.ObtenerConexion();
                cmd_sqlite = conexion_sqlite.CreateCommand();

                cmd_sqlite.CommandText = $"select prod.CodigoProd, prod.NombreProd,cantidad, prod.PrecioProd from datalles_Producto  \r\njoin tabla_inventario prod on prod.CodigoProd = datalles_Producto.ref_Producto\r\nwhere Ref_Venta = {cod}";
                cmd_sqlite.ExecuteNonQuery();
                datareader_sqlite = cmd_sqlite.ExecuteReader();

                while (datareader_sqlite.Read())
                {
                    int Ptotal = Convert.ToInt32(datareader_sqlite["cantidad"]) * Convert.ToInt32(datareader_sqlite["PrecioProd"]);
                    dgv.Rows.Add(datareader_sqlite["CodigoProd"].ToString(), datareader_sqlite["NombreProd"].ToString(), datareader_sqlite["cantidad"].ToString(), datareader_sqlite["PrecioProd"].ToString(), Ptotal.ToString());
                    totalNeto += Ptotal;
                }

                datareader_sqlite.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los datos: " + ex.Message);
            }

            if (dgv.Rows.Count > 0)
                dgv.Rows.Add("-----", "-----", "-----", "-----", "-----");

            // llenar el datagridview con los servicios
            try
            {

                conexion_sqlite = Cls_ConexionDB.Instancia.ObtenerConexion();
                cmd_sqlite = conexion_sqlite.CreateCommand();

                cmd_sqlite.CommandText = $"SELECT serv.CodigoServ, serv.NombreServ,cantidad, serv.PrecioServ from datalles_Servicio  \r\njoin tabla_servicio serv on serv.CodigoServ = datalles_Servicio.ref_Servicio\r\nwhere Ref_Venta = {cod}";
                cmd_sqlite.ExecuteNonQuery();
                datareader_sqlite = cmd_sqlite.ExecuteReader();

                while (datareader_sqlite.Read())
                {
                    int Ptotal = Convert.ToInt32(datareader_sqlite["cantidad"]) * Convert.ToInt32(datareader_sqlite["PrecioServ"]);

                    totalNeto += Ptotal;
                    dgv.Rows.Add(datareader_sqlite["CodigoServ"].ToString(), datareader_sqlite["NombreServ"].ToString(), datareader_sqlite["cantidad"].ToString(), datareader_sqlite["PrecioServ"].ToString(), Ptotal.ToString());
                }
                total.Text = totalNeto.ToString();
                datareader_sqlite.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los datos: " + ex.Message);
            }
        }



        public void cargarProd(int idventa, int idprod, int cant)
        {
            try
            {

                conexion_sqlite = Cls_ConexionDB.Instancia.ObtenerConexion();
                cmd_sqlite = conexion_sqlite.CreateCommand();

                cmd_sqlite.CommandText = $"insert into datalles_Producto (Ref_Venta, ref_Producto,cantidad) values ('{idventa}','{idprod}','{cant}')";
                cmd_sqlite.ExecuteNonQuery();
                datareader_sqlite = cmd_sqlite.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar los produtos: " + ex.Message);
            }

        }
       

        public void cargarservi(int idventa,  int idservi, int cant)
        {
            try
            {
                conexion_sqlite = Cls_ConexionDB.Instancia.ObtenerConexion();
                cmd_sqlite = conexion_sqlite.CreateCommand();

                cmd_sqlite.CommandText = $"insert into datalles_Servicio (Ref_Venta, ref_Servicio,cantidad) values ('{idventa}','{idservi}','{cant}')";
                cmd_sqlite.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar los Servicios: " + ex.Message);
            }

        }

        public void pfactura(int idc, int ide, string fecha)
        {

            try
            {
                conexion_sqlite = Cls_ConexionDB.Instancia.ObtenerConexion();
                cmd_sqlite = conexion_sqlite.CreateCommand();

                cmd_sqlite.CommandText = $"insert into Factura (REF_cliente, ref_empleado ,fecha) values ('{idc}','{ide}','{fecha}')";
                cmd_sqlite.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el pfactura: " + ex.Message);
            }
        }

        public int ultima()
        {
            int facturaId = 0;
            try
            {

                conexion_sqlite = Cls_ConexionDB.Instancia.ObtenerConexion();
                cmd_sqlite = conexion_sqlite.CreateCommand();

                cmd_sqlite.CommandText = $"select MAX(id) from Factura ";
                cmd_sqlite.ExecuteNonQuery();
                datareader_sqlite = cmd_sqlite.ExecuteReader();

                if (datareader_sqlite.Read())
                {
                    facturaId = Convert.ToInt32(datareader_sqlite[0]);
                }
                else
                {
                    MessageBox.Show("No se encontró ninguna factura.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar la ultima factura: " + ex.Message);
            }
            return facturaId;
        }

        //elinar fact
        public void EliminarFactura(int id)
        {
            //p
            try
            {
                conexion_sqlite = Cls_ConexionDB.Instancia.ObtenerConexion();
                cmd_sqlite = conexion_sqlite.CreateCommand();

                cmd_sqlite.CommandText = $"Delete From Factura Where id = {id} ";
                cmd_sqlite.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar Servicio" + ex.Message);
            }

            //a 
            
            try
            {
                conexion_sqlite = Cls_ConexionDB.Instancia.ObtenerConexion();
                cmd_sqlite = conexion_sqlite.CreateCommand();

                cmd_sqlite.CommandText = $"Delete From datalles_Producto Where Ref_Venta = {id} ";
                cmd_sqlite.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar Servicio" + ex.Message);
            }

            //b
            try
            {
                conexion_sqlite = Cls_ConexionDB.Instancia.ObtenerConexion();
                cmd_sqlite = conexion_sqlite.CreateCommand();

                cmd_sqlite.CommandText = $"Delete From datalles_Servicio Where Ref_Venta = {id} ";
                cmd_sqlite.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar Servicio" + ex.Message);
            }

        }



    }
}
//:)
