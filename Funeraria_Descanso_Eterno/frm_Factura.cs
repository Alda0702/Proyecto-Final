using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
        Bitmap memoryImage;

        private void btn_ImprimirFac_Click(object sender, EventArgs e)
        {
            CapturarPanelParaImpresion(pnl_Fondo);
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(Documento_PrintPage);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
                this.Close();
            }
        }
        private void CapturarPanelParaImpresion(Panel panel)
        {
            memoryImage = new Bitmap(panel.Width, panel.Height);
            panel.DrawToBitmap(memoryImage, new Rectangle(0, 0, panel.Width, panel.Height));
        }

        private void Documento_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Puedes ajustar la posición y tamaño si es necesario
            e.Graphics.DrawImage(memoryImage, e.MarginBounds);
        }
        private void frm_Factura_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void dtg_Factura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
