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
    public partial class frm_Registro_Cliente : Form
    {
        public frm_Registro_Cliente()
        {
            InitializeComponent();
        }

        private void pnl_Buscar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_Complemento_Cantidad_Click(object sender, EventArgs e)
        {

        }

        private void btn_NuevoC_Click(object sender, EventArgs e)
        {
            frm_NuevoCliente frm_NuevoCliente = new frm_NuevoCliente();
            this.Hide();
            frm_NuevoCliente.ShowDialog();
            this.Show();
        }

        private void btn_EliminarC_Click(object sender, EventArgs e)
        {
            frm_EliminarCliente frm_Eliminar = new frm_EliminarCliente();
            this.Hide();
            frm_Eliminar.ShowDialog();
            this.Show();

        }
    }
}
