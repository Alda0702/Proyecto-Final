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
    public partial class frm_NuevoServicio : Form
    {
        public frm_NuevoServicio()
        {
            InitializeComponent();
        }

        private void pic_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pic_Minimizar_Click(object sender, EventArgs e)
        {
            //Minimiza la pestalla dandole clic en el pictureBox de minimizar 
            this.WindowState = FormWindowState.Minimized;

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
