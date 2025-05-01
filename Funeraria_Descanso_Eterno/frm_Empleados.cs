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
    public partial class frm_Empleados : Form
    {
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

        }

        private void btn_ActualizarE_Click(object sender, EventArgs e)
        {
            frm_ActualizarEmpleado frm_ActualizarE = new frm_ActualizarEmpleado();
            this.Hide();
            frm_ActualizarE.ShowDialog();
            this.Show();
        }
    }
}
