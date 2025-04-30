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
    public partial class frm_Loguin : Form
    {
        public frm_Loguin()
        {
            InitializeComponent();
        }

        private void frm_Loguin_Load(object sender, EventArgs e)
        {
        }

        private void pic_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pic_Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pic_Restaurar.Visible = false;
            pic_Redimencionar.Visible = true;
        }

        private void pic_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void pic_Redimencionar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pic_Redimencionar.Visible = false;
            pic_Restaurar.Visible = true;
        }

        private void btn_Siguiente_Click(object sender, EventArgs e)
        {
            frm_Menu frm_Menu = new frm_Menu();
            this.Hide();
            frm_Menu.ShowDialog();
            this.Show();
            this.Close();
        }

        private void pnl_Titulo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
