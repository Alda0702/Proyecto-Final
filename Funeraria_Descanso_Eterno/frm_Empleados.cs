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
       private EmpleadoDB empleadoDB = new EmpleadoDB();

        private static frm_Empleados instancia;

        public static frm_Empleados Instancia
        {
            get
            {
                // Si la instancia no existe, se crea
                if (instancia == null)
                {
                    instancia = new frm_Empleados();
                }
                return instancia;
            }
        }
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
                // obtiene el id del empleado seleccionado 
                int idEmpleado = Convert.ToInt32(dtg_Empleados.SelectedRows[0].Cells["ID"].Value);

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
            // cargar los empleados al iniciar el formulario

            llenargrid();
        }

        public void llenargrid()
        {
            dtg_Empleados.Rows.Clear();
            empleadoDB.Mostrarempleado(dtg_Empleados);
        }

        private void txt_BuscarE_TextChanged(object sender, EventArgs e)
        {

            //llamar al metodo de busqueda
            empleadoDB.BuscarPorCodigoempl(dtg_Empleados, txt_BuscarE.Text.Trim());

        }
        private void dtg_Empleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void btn_ActualizarE_Click(object sender, EventArgs e)
        {

            // verifica si hay una fila seleccionada en el datagridview
            if (dtg_Empleados.SelectedRows.Count > 0)
                {
                    int idEmpleado = Convert.ToInt32(dtg_Empleados.SelectedRows[0].Cells["ID"].Value);

                ClsEmpleado empleado = empleadoDB.ObtenerEmpleadoPorID(idEmpleado);


                if (empleado != null)
                    {
                        frm_ActualizarEmpleado frm = new frm_ActualizarEmpleado(empleado);
                        frm.ShowDialog();
                        this.Hide();

                }
            }
                else
                {
                    MessageBox.Show("Por favor, selecciona un empleado para actualizar.");
                }

        }



    }
    

    

}
    
