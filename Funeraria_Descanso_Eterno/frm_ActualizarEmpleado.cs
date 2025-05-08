using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funeraria_Descanso_Eterno
{
    public partial class frm_ActualizarEmpleado : Form
    {
        private ClsEmpleado empleado;

        private static frm_ActualizarEmpleado instancia;

        Cls_EmpleadoCRUD.EmpleadoDB Cls_EmpleadoCRUD = new Cls_EmpleadoCRUD.EmpleadoDB();

        public static frm_ActualizarEmpleado Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new frm_ActualizarEmpleado();
                }
                return instancia;
            }
        }

        public frm_ActualizarEmpleado()
        {
        }

        public frm_ActualizarEmpleado(ClsEmpleado emp)
        {        
                    InitializeComponent();
        this.empleado = emp;


        }
       


        private void pic_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int id;
        private void frm_ActualizarEmpleado_Load(object sender, EventArgs e)
        {

            id = empleado.ID_Empleado;
            txt_NomE.Text = empleado.Nombre_E;
            txt_ApellidoPE.Text = empleado.ApellidoP_E;
            txt_ApellidoME.Text = empleado.ApellidoM_E;
            txt_Tdoc.Text = empleado.Cedula_E;
            txt_Direccion.Text = empleado.Direccion_E;
            txt_Cel.Text = empleado.Celular_E;
            txt_Email.Text = empleado.Mail_E;
            cmb_Sexo.SelectedItem = empleado.Sexo_E;
            cmb_Rol.SelectedItem = empleado.REF_Rol;
            txt_Departamento.Text = empleado.Depto_E;
            txt_Ciudad.Text = empleado.Ciudad_E;
            cmb_Tdoc.SelectedItem = empleado.Tdoc_E;
            txt_Nacimiento.Text = empleado.F_Nacimiento_E;
        }

        private void txt_Ciudad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {


            try
            {
                Cls_EmpleadoCRUD.ModificarEmpld(id, cmb_Tdoc.Text, txt_Tdoc.Text, txt_NomE.Text, txt_ApellidoPE.Text, txt_ApellidoME.Text, txt_Nacimiento.Text, cmb_Sexo.Text, cmb_Rol.Text, txt_Departamento.Text, txt_Ciudad.Text, txt_Direccion.Text, txt_Cel.Text, txt_Email.Text);

                MessageBox.Show("Empleado actualizado correctamente.");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el empleado: " + ex.Message);
            }

        }

        private void pnl_NuevoCl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
