using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Funeraria_Descanso_Eterno.Cls_EmpleadoCRUD;

namespace Funeraria_Descanso_Eterno
{
    public partial class frm_NuevoEmpleado : Form
    {
        private static frm_NuevoEmpleado instancia;
        public static string LastEmpleadoID { get; set; }  // Variable estática para almacenar el último ID de empleado

        public frm_NuevoEmpleado()
        {
            InitializeComponent();
        }
        public static frm_NuevoEmpleado Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                    instancia = new frm_NuevoEmpleado();
                return instancia;
            }
        }

        private void pic_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pic_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_Departamento_Click(object sender, EventArgs e)
        {

        }

        private void txt_Ciudad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {


            string result = "";

            // Validar campos vacíos
            if (string.IsNullOrWhiteSpace(txt_NomE.Text) ||
                string.IsNullOrWhiteSpace(txt_ApellidoPE.Text) ||
                string.IsNullOrWhiteSpace(txt_ApellidoME.Text) ||
                string.IsNullOrWhiteSpace(txt_Cel.Text) ||
                string.IsNullOrWhiteSpace(txt_Ciudad.Text) ||
                string.IsNullOrWhiteSpace(txt_Departamento.Text) ||
                string.IsNullOrWhiteSpace(txt_Direccion.Text) ||
                string.IsNullOrWhiteSpace(txt_Email.Text) ||
                string.IsNullOrWhiteSpace(txt_Nacimiento.Text) ||
                string.IsNullOrWhiteSpace(cmb_Sexo.Text) ||
                string.IsNullOrWhiteSpace(cmb_Tdoc.Text) ||
                string.IsNullOrWhiteSpace(cmb_Rol.Text))
            {
                MessageBox.Show("Todos los campos deben estar completos.");
                return;
            }

            // Validar Rol
            if (cmb_Rol.Text == "Vendedor")
            {
                result = "Vendedor";
            }
            else if (cmb_Rol.Text == "Logística")
            {
                result = "Logística";
            }
            else if (cmb_Rol.Text == "RRHH")
            {
                result = "RRHH";
            }
            else if (cmb_Rol.Text == "Contratador")
            {
                result = "Contratador";
            }
            else
            {
                MessageBox.Show("El rol seleccionado no es válido.");
                return;
            }






            // Crear el nuevo empleado
            ClsEmpleado nuevoEmpleado = new ClsEmpleado
            {
                REF_Rol = result,
                Sexo_E = cmb_Sexo.Text,
                Tdoc_E = cmb_Tdoc.Text,
                Cedula_E = txt_Tdoc.Text,
                ApellidoM_E = txt_ApellidoME.Text,
                ApellidoP_E = txt_ApellidoPE.Text,
                Celular_E = txt_Cel.Text,
                Ciudad_E = txt_Ciudad.Text,
                Depto_E = txt_Departamento.Text,
                Direccion_E = txt_Direccion.Text,
                Mail_E = txt_Email.Text,
                F_Nacimiento_E = txt_Nacimiento.Text,
                Nombre_E = txt_NomE.Text,
            };

            EmpleadoDB empleadoDB = new EmpleadoDB();
            //empleadoDB.employee();
            //empleadoDB.insertroles();
            int idEmpleado = empleadoDB.InsertarEmpleado(nuevoEmpleado);  // Aquí obtienes el ID del empleado recién insertado

             frm_NuevoUsario.LastEmpleadoID = result;
        //    MessageBox.Show("Empleado registrado correctamente.");


              frm_NuevoUsario.Instancia.ShowDialog();
            this.Close();

        }

    }
}
