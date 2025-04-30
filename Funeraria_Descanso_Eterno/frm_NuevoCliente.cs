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
    public partial class frm_NuevoCliente : Form
    {
        public frm_NuevoCliente()
        {
            InitializeComponent();
        }

        private void pic_Restaurar_Click(object sender, EventArgs e)
        {
  
        }

        private void pic_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void pic_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pic_Redimencionar_Click(object sender, EventArgs e)
        {
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
