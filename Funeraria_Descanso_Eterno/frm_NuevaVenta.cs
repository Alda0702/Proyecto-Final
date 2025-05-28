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
    public partial class frm_NuevaVenta : Form
    {
        Cls_Factura a = new Cls_Factura();
        public frm_NuevaVenta()
        {
            InitializeComponent();
        }

        private void pic_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtg_Factura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            int IDps, Cantps, IDCliente, IDempleado;
            string fecha;
            IDCliente = Convert.ToInt32(tx_IdC.Text);
            IDempleado = Convert.ToInt32(txt_IdE.Text);
            fecha = tx_Fecha.Text;


            a.pfactura(IDCliente, IDempleado, fecha);
           int ultiam =  a.ultima();


            foreach (DataGridViewRow row in dtg_prod.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells["IdProducto"].Value != null && row.Cells["Cantidad"].Value != null)
                {

                    IDps = Convert.ToInt32(row.Cells["IdProducto"].Value);
                    Cantps = Convert.ToInt32(row.Cells["Cantidad"].Value);

                    a.cargarProd(IDCliente, IDempleado, IDps, Cantps);
                }
            }

            foreach (DataGridViewRow row in dtg_servi.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells["IdProducto"].Value != null && row.Cells["Cantidad"].Value != null)
                {
                    IDps = Convert.ToInt32(row.Cells["servi"].Value);
                    Cantps = Convert.ToInt32(row.Cells["canti"].Value);

                    a.cargarservi(IDCliente, IDempleado, IDps, Cantps);
                }
            }

        }
    }
}
