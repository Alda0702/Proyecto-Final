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
      

        Cls_Factura factura = new Cls_Factura();

        public int idBuscar;
        public frm_Factura()
        {
            InitializeComponent();
            //llenarGrid();
        }

        
        public void llenarGrid()
        {
            // Llenar el DataGridView con los datos de la base de datos

            dtg_Factura.Rows.Clear();
            factura.MostrarFactura(dtg_Factura, idBuscar, lbl_PrintNunFact, lbl_PrintNombreC, lbl_PrintCedulaC, lbl_PrintUserCC, lbl_PrintTotal);
            
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
            
            //this.Close();
        }

        private void frm_Factura_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }
    }
}
