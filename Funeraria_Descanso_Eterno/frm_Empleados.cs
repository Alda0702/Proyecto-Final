using Finisar.SQLite;
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
    public partial class frm_Empleados : Form
    {
        EmpleadoDB empleadoDB = new EmpleadoDB();

        public frm_Empleados()
        {
            InitializeComponent();
        }

        private void btn_NuevoE_Click(object sender, EventArgs e)
        {
            frm_NuevoEmpleado frm_N_Empleado = new frm_NuevoEmpleado();
            this.Hide();
            frm_N_Empleado.ShowDialog();
            this.Show();
            llenargrid();
        }

        private void btn_EliminarE_Click(object sender, EventArgs e)
        {
            if (dtg_Empleados.SelectedRows.Count > 0)
            {
                // Obtener el ID del empleado seleccionado (suponiendo que la columna "IdEmpleado" es la primera columna)
                int idEmpleado = Convert.ToInt32(dtg_Empleados.SelectedRows[0].Cells["ID"].Value);

                // Confirmación antes de eliminar
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este empleado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    bool eliminado = empleadoDB.EliminarEmplPorCodigo(idEmpleado.ToString());

                    if (eliminado)
                    {
                        dtg_Empleados.Rows.RemoveAt(dtg_Empleados.SelectedRows[0].Index);
                        MessageBox.Show("Empleado eliminado correctamente.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un empleado para eliminar.");
            }
            llenargrid();
        }

        private void llenargrid()
        {
            dtg_Empleados.Rows.Clear();
            empleadoDB.Mostrarempleado(dtg_Empleados);
        }


        private void frm_Empleados_Load(object sender, EventArgs e)
        {
            llenargrid();

        }

        private void txt_BuscarE_TextChanged(object sender, EventArgs e)
        {
            empleadoDB.BuscarPorCodigoempl(dtg_Empleados, txt_BuscarE.Text.Trim());

        }
        private void dtg_Empleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void btn_ActualizarE_Click(object sender, EventArgs e)
        {
            frm_ActualizarEmpleado frmActualizar = frm_ActualizarEmpleado.Instancia;

            int idEmpleado = Convert.ToInt32(dtg_Empleados.SelectedRows[0].Cells["ID"].Value);

            frmActualizar.txt_NomE.Text = dtg_Empleados.SelectedRows[0].Cells["Nombre"].Value.ToString();
            frmActualizar.txt_ApellidoPE.Text = dtg_Empleados.SelectedRows[0].Cells["ApellidoP"].Value.ToString();
            frmActualizar.cmb_Rol.Text = dtg_Empleados.SelectedRows[0].Cells["Rol"].Value.ToString();
            frmActualizar.txt_Cel.Text = dtg_Empleados.SelectedRows[0].Cells["Celular"].Value.ToString();
            frmActualizar.txt_Email.Text = dtg_Empleados.SelectedRows[0].Cells["Email"].Value.ToString();

            frmActualizar.idservicio = idEmpleado;
            this.Hide();
            frmActualizar.ShowDialog();
            llenargrid();


        }
    }

    

}
    
