using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funeraria_Descanso_Eterno
{
    public partial class frm_Exportar : Form
    {
        public frm_Exportar()
        {
            InitializeComponent();
        }

        private void pic_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_Acceso_Click(object sender, EventArgs e)
        {

        }

        private void btn_Siguiente_Click(object sender, EventArgs e)
        {
            /*         Tabla Servicio
Table Rol
Tabla Proveedores
Tabla Loguín
Tabla Inventario
Tabla Empleado
Tabla Cliente
   */



            if (cmb_Tabla.Text == "Tabla Empleado")
            {
                Cls_EmpleadoCRUD.EmpleadoDB cls_EmpleadoCRU = new Cls_EmpleadoCRUD.EmpleadoDB();

                string empleado = cls_EmpleadoCRU.Mostrarempleado1();



                string empleadoparts = "";

                if (empleado.Contains(";"))
                {

                    foreach (var item in empleado.Split(';'))
                    {
                        empleadoparts += item + ";";

                    }

                }
                try
                {

                    using (StreamWriter writer = new StreamWriter(Environment.CurrentDirectory + "\\empleado.csv", false, Encoding.UTF8))
                    {
                        writer.WriteLine("IdEmpleado;" + "Tipo_Documento;" + "CedulaEmpleado;" + "NombreEmpleado;" + "ApellidoPEmpleado;" + "ApellidoMEmpleado;" + "FechaNacimientoEmpleado;" + "SexoEmpleado;" + "RolEmpleado;" + "DepartamentoEmpleado;" + "CiudadEmpleado;" + "DireccionEmpleado;" + "CelularEmpleado;" + "EmailEmpleado;");

                        writer.WriteLine(empleadoparts);
                    }

                    MessageBox.Show("Archivo creado");
                }
                catch
                {
                    MessageBox.Show("No se pudo crear el archivo");
                }


            }



            if (cmb_Tabla.Text == "Tabla Cliente")
            {
                Cls_ClienteCRUD cls_ClienteCRUD = new Cls_ClienteCRUD();

                string cliente = cls_ClienteCRUD.Mostrarcliente1();



                string clienteparts = "";

                if (cliente.Contains(";"))
                {

                    foreach (var item in cliente.Split(';'))
                    {
                        clienteparts += item + ";";

                    }

                }
                try
                {

                    using (StreamWriter writer = new StreamWriter(Environment.CurrentDirectory + "\\cliente.csv", false, Encoding.UTF8))
                    {
                        writer.WriteLine("IdCliente;" + "TipoDocumentoCliente;" + "CedulaCliente;" + "NombreCliente;" + "ApellidoPCliente;" + "ApellidoMCliente;" + "FechaNacimientoCliente;" + "SexoCliente;" + "Pais;" + "DepartamentoCliente;" + "CiudadCliente;" + "DireccionCliente;" + "CelularCliente;" + "EmailCliente;");

                        writer.WriteLine(clienteparts);
                    }

                    MessageBox.Show("Archivo creado");
                }
                catch
                {
                    MessageBox.Show("No se pudo crear el archivo");
                }


            }

            if (cmb_Tabla.Text == "Tabla Inventario")
            {
                Cls_InventarioCRUD cls_InventarioCRUD = new Cls_InventarioCRUD();

                string inventario = cls_InventarioCRUD.MostrarInventario1();



                string inventarioparts = "";

                if (inventario.Contains(";"))
                {

                    foreach (var item in inventario.Split(';'))
                    {
                        inventarioparts += item + ";";

                    }

                }
                try
                {

                    using (StreamWriter writer = new StreamWriter(Environment.CurrentDirectory + "\\inventario.csv", false, Encoding.UTF8))
                    {
                        writer.WriteLine("CodigoProd;" + "NombreProd;" + "DescripcionProd;" + "CategoriaPord;" + "CantidadProd;" + "PrecioProd;");

                        writer.WriteLine(inventarioparts);
                    }

                    MessageBox.Show("Archivo creado");
                }
                catch
                {
                    MessageBox.Show("No se pudo crear el archivo");
                }


            }

            if (cmb_Tabla.Text == "Tabla Loguín")
            {
                Cls_LoginCRUD cls_LoginCRUD = new Cls_LoginCRUD();

                string login = cls_LoginCRUD.Mostrarlogin1();



                string loginparts = "";

                if (login.Contains(";"))
                {

                    foreach (var item in login.Split(';'))
                    {
                        loginparts += item + ";";

                    }

                }
                try
                {

                    using (StreamWriter writer = new StreamWriter(Environment.CurrentDirectory + "\\login.csv", false, Encoding.UTF8))
                    {
                        writer.WriteLine("CodigoLoguin;" + "Usuario;" + "Pass;" + "RolEmpleado;");

                        writer.WriteLine(loginparts);
                    }

                    MessageBox.Show("Archivo creado");
                }
                catch
                {
                    MessageBox.Show("No se pudo crear el archivo");
                }


            }

            if (cmb_Tabla.Text == "Tabla Proveedores")
            {
                Cls_ProveedoresCRUD cls_ProveedoresCRUD = new Cls_ProveedoresCRUD();

                string proveedores = cls_ProveedoresCRUD.Mostrarproveedor1();



                string proveedorparts = "";

                if (proveedores.Contains(";"))
                {

                    foreach (var item in proveedores.Split(';'))
                    {
                        proveedorparts += item + ";";

                    }

                }
                try
                {

                    using (StreamWriter writer = new StreamWriter(Environment.CurrentDirectory + "\\proveedores.csv", false, Encoding.UTF8))
                    {
                        writer.WriteLine("CodigoProv;" + "NombreProv;" + "CiudadProv;" + "ContactoProv;" + "EmailProv");

                        writer.WriteLine(proveedorparts);
                    }

                    MessageBox.Show("Archivo creado");
                }
                catch
                {
                    MessageBox.Show("No se pudo crear el archivo");
                }


            }

            if (cmb_Tabla.Text == "Tabla Servicio")
            {
                Cls_ServiciosCRUD cls_ServiciosCRUD = new Cls_ServiciosCRUD();

                string servicios = cls_ServiciosCRUD.Mostrarservicio1();



                string serviciosparts = "";

                if (servicios.Contains(";"))
                {

                    foreach (var item in servicios.Split(';'))
                    {
                        serviciosparts += item + ";";

                    }

                }
                try
                {

                    using (StreamWriter writer = new StreamWriter(Environment.CurrentDirectory + "\\servicios.csv", false, Encoding.UTF8))
                    {
                        writer.WriteLine("CodigoServ;" + "NombreServ;" + "DescripcionServ;" + "CategoriaServ;" + "DuracionEstimadaServ" + "PrecioServ;");

                        writer.WriteLine(serviciosparts);
                    }

                    MessageBox.Show("Archivo creado");
                }
                catch
                {
                    MessageBox.Show("No se pudo crear el archivo");
                }


            }

            if (cmb_Tabla.Text == "Table Rol")
            {
                Cls_LoginCRUD cls_LoginCRUD = new Cls_LoginCRUD();

                string rol = cls_LoginCRUD.MostrarRol1();



                string rolparts = "";

                if (rol.Contains(";"))
                {

                    foreach (var item in rol.Split(';'))
                    {
                        rolparts += item + ";";

                    }

                }
                try
                {

                    using (StreamWriter writer = new StreamWriter(Environment.CurrentDirectory + "\\rol.csv", false, Encoding.UTF8))
                    {
                        writer.WriteLine("CodigoRol;" + "Nombre;");

                        writer.WriteLine(rolparts);
                    }

                    MessageBox.Show("Archivo creado");
                }
                catch
                {
                    MessageBox.Show("No se pudo crear el archivo");
                }


            }



        }

        private void cmb_Tabla_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
