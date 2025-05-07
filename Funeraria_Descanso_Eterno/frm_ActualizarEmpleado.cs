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
        private static frm_ActualizarEmpleado instancia;

        Cls_EmpleadoCRUD.EmpleadoDB Cls_EmpleadoCRUD = new Cls_EmpleadoCRUD.EmpleadoDB();



        public frm_ActualizarEmpleado()
        {
            InitializeComponent();

        }
        public static frm_ActualizarEmpleado Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new frm_ActualizarEmpleado();
                }
                return instancia;
            }
        }

        private void pic_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_ActualizarEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void txt_Ciudad_TextChanged(object sender, EventArgs e)
        {

        }
        public int idservicio;

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {


            try
            {
                Cls_EmpleadoCRUD.ModificarEmpld(idservicio, cmb_Tdoc.Text, txt_Tdoc.Text, txt_NomE.Text, txt_ApellidoPE.Text, txt_ApellidoME.Text, txt_Nacimiento.Text, cmb_Sexo.Text, cmb_Rol.Text, txt_Departamento.Text, txt_Ciudad.Text, txt_Direccion.Text, txt_Cel.Text, txt_Email.Text);

                MessageBox.Show("Empleado actualizado correctamente.");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el empleado: " + ex.Message);
            }

        }
    }
}
