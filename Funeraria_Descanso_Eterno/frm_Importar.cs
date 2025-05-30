using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Funeraria_Descanso_Eterno
{
    public partial class frm_Importar : Form
    {
        public frm_Importar()
        {
            InitializeComponent();
        }

        private void btn_Siguiente_Click(object sender, EventArgs e)
        {
            if (cmb_Tabla.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona una tabla.");
                return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos CSV (*.csv)|*.csv";
            openFileDialog.Title = "Seleccionar archivo CSV";

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            string path = openFileDialog.FileName;
            string nombreTabla = cmb_Tabla.Text;

            try
            {
                var lineas = File.ReadAllLines(path, Encoding.UTF8);
                if (lineas.Length <= 1)
                {
                    MessageBox.Show("El archivo está vacío o no tiene datos válidos.");
                    return;
                }

                for (int i = 1; i < lineas.Length; i++)
                {
                    string[] campos = lineas[i].Split(';');

                    switch (nombreTabla)
                    {
                        case "Tabla Servicos":
                            if (campos.Length >= 6)
                            {
                                var servicio = new Cls_ServiciosCRUD();
                                servicio.InsertarServicios(
                                    campos[1], campos[2], campos[3],
                                    int.Parse(campos[4]),
                                    decimal.Parse(campos[5])
                                );
                            }
                            break;

                        case "Tabla Empleado":
                            {
                                var empleadoDB = new Cls_EmpleadoCRUD.EmpleadoDB();

                                var emp = new ClsEmpleado
                                {
                                    Tdoc_E = campos[1],
                                    Cedula_E = campos[2],
                                    Nombre_E = campos[3],
                                    ApellidoP_E = campos[4],
                                    ApellidoM_E = campos[5],
                                    F_Nacimiento_E = campos[6],
                                    Sexo_E = campos[7],
                                    REF_Rol = campos[8],
                                    Depto_E = campos[9],
                                    Ciudad_E = campos[10],  
                                    Direccion_E = campos[11],
                                    Celular_E = campos[12],
                                    Mail_E = campos[13]
                                };

                                empleadoDB.InsertarEmpleado(emp);
                            }
                            break;

                        case "Tabla Cliente":
                            if (campos.Length >= 14)
                            {
                                var cliente = new Cls_ClienteCRUD();
                                cliente.InsertarCliente(
                                       campos[1], campos[2], campos[3], campos[4],
                                       campos[5], campos[6], campos[7], campos[8],
                                       campos[9], campos[10], campos[11], campos[12],
                                       campos[13]
                                );
                            }
                            break;

                        case "Tabla Inventario":
                            if (campos.Length >= 6)  
                            {
                                var inventario = new Cls_InventarioCRUD.Inventario();

                                inventario.InsertarProducto(
                                    campos[1],           
                                    campos[2],           
                                    campos[3],          
                                    int.Parse(campos[4]),
                                    int.Parse(campos[5]) 
                                );
                            }
                            break;

                        case "Tabla Loguín":
                            if (campos.Length >= 4)
                            {
                                var login = new Cls_LoginCRUD();
                                login.InsertarLogin(
                                    campos[1], campos[2], campos[3]
                                );
                            }
                            break;

                        case "Tabla Proveedores":
                            if (campos.Length >= 4)
                            {
                                var proveedor = new Cls_ProveedoresCRUD();
                                proveedor.InsertarProveedores(  
                                    campos[1], campos[2], campos[3], campos[4]  
                                );
                            }
                            break;

                        default:
                            MessageBox.Show("Tabla no reconocida.");
                            break;  
                    }
                }

                MessageBox.Show("Importación completada exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al importar: " + ex.Message);
            }
        }

        private void pic_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
