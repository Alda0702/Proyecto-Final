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
    public partial class frm_Factura : Form
    {
        public frm_Factura()
        {
            InitializeComponent();
        }

        private void pnl_3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pic_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ImprimirFac_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
