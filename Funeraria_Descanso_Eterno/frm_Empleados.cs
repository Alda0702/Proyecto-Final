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
        }


        private void frm_Empleados_Load(object sender, EventArgs e)
        {
            empleadoDB.Mostrarempleado(dtg_Empleados);

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
            if (dtg_Empleados.SelectedRows.Count > 0)
            {
                MessageBox.Show("¿Está seguro de que desea actualizar el servicio con ID: " + dtg_Empleados.SelectedRows[0].Cells["Cod"].Value + "?");

                frm_ActualizarServico frm_ActualizarServico = new frm_ActualizarServico();

                int idProceso = Convert.ToInt32(dtg_Empleados.SelectedRows[0].Cells["Cod"].Value);
                frm_ActualizarServico.txt_NomProd.Text = dtg_Servicios.SelectedRows[0].Cells["NombreP"].Value.ToString();
                frm_ActualizarServico.txt_DescProd.Text = dtg_Servicios.SelectedRows[0].Cells["Desc"].Value.ToString();
                frm_ActualizarServico.txt_CategoriaProd.Text = dtg_Servicios.SelectedRows[0].Cells["Categoria"].Value.ToString();
                frm_ActualizarServico.txt_Duracion.Text = dtg_Servicios.SelectedRows[0].Cells["Duracion"].Value.ToString();
                string precio = dtg_Servicios.SelectedRows[0].Cells["Precio"].Value.ToString();
                string cadenaSinDecimales = precio.Split(',')[0]; // Toma la parte antes de la coma

                frm_ActualizarServico.tx_PrecioProd.Text = cadenaSinDecimales;
                frm_ActualizarServico.idServicio = idProceso;
                this.Hide();
                frm_ActualizarServico.ShowDialog();
                this.Show();
                llenarGrid();

            }
            else
            {
                MessageBox.Show("Seleccione un proceso para editar.");
            }

        }
    }
}
    }


}
    
