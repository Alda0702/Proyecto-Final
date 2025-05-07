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
    public partial class frm_Proveedores : Form
    {
        public frm_Proveedores()
        {
            InitializeComponent();
        }

        private void btn_NuevoProv_Click(object sender, EventArgs e)
        {
            frm_NuevoProveedor frm_NuevoProv = new frm_NuevoProveedor();
            this.Hide();
            frm_NuevoProv.ShowDialog();
            this.Show();
        }

        private void btn_ActualizarProv_Click(object sender, EventArgs e)
        {
            frm_ActualizarProveedor frm_ActualizarProveedor = new frm_ActualizarProveedor();
            this.Hide();
            frm_ActualizarProveedor.ShowDialog();
            this.Show();
        }
    }
}
