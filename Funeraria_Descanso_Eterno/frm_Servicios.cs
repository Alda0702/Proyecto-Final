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
    public partial class frm_Servicios : Form
    {
        public frm_Servicios()
        {
            InitializeComponent();
        }

        private void btn_NuevoS_Click(object sender, EventArgs e)
        {
            frm_NuevoServicio frmNServicio = new frm_NuevoServicio();
            this.Hide();
            frmNServicio.Show();
            this.Show();
        }

        private void frm_Servicios_Load(object sender, EventArgs e)
        {

        }

        private void btn_EliminarS_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_ActualizarS_Click(object sender, EventArgs e)
        {
            frm_ActualizarServico frm_ActualizarServico = new frm_ActualizarServico();
            this.Hide();
            frm_ActualizarServico.Show();
            this.Show();
        }
    }
}
