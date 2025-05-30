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
            if (string.IsNullOrWhiteSpace(tx_IdC.Text) ||string.IsNullOrWhiteSpace(txt_IdE.Text) ||string.IsNullOrWhiteSpace(tx_Fecha.Text) || (dtg_prod.Rows.Count == 0 && dtg_servi.Rows.Count == 0))
            {
                MessageBox.Show("Todos los campos deben estar llenos y debe haber al menos un producto o un servicio.");
                return; 
            }

            int IDps, Cantps, IDCliente, IDempleado;
            string fecha;
            IDCliente = Convert.ToInt32(tx_IdC.Text);
            IDempleado = Convert.ToInt32(txt_IdE.Text);
            fecha = tx_Fecha.Text;


            a.pfactura(IDCliente, IDempleado, fecha);
            
            int ultima =  a.ultima();


            foreach (DataGridViewRow row in dtg_prod.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells["IdProducto"].Value != null && row.Cells["Cantidad"].Value != null)
                {

                    IDps = Convert.ToInt32(row.Cells["IdProducto"].Value);
                    Cantps = Convert.ToInt32(row.Cells["Cantidad"].Value);

                    a.cargarProd(ultima, IDps, Cantps);
                }
            }

            foreach (DataGridViewRow row in dtg_servi.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells["servi"].Value != null && row.Cells["canti"].Value != null)
                {
                    IDps = Convert.ToInt32(row.Cells["servi"].Value);
                    Cantps = Convert.ToInt32(row.Cells["canti"].Value);

                    a.cargarservi(ultima, IDps, Cantps);
                }
            }
            MessageBox.Show("Venta registrada correctamente.");
            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
