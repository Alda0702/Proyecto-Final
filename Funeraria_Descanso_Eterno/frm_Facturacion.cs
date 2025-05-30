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
    public partial class frm_Facturacion : Form
    {
        public frm_Facturacion()
        {
            InitializeComponent();
            llenarGrid();
        }

        Cls_Factura factura = new Cls_Factura();
        public void llenarGrid()
        {
            // Llenar el DataGridView con los datos de la base de datos
            dtg_Factura.Rows.Clear();
            factura.mostrarFacturacion(dtg_Factura);
        }

        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            if (dtg_Factura.SelectedRows.Count > 0)
            {
                int idProceso = Convert.ToInt32(dtg_Factura.SelectedRows[0].Cells["CodigoF"].Value);
                MessageBox.Show("¿Está seguro de que desea imprimir la factura con ID: " + idProceso + "?");
                frm_Factura frm_Factura = new frm_Factura();
                frm_Factura.idBuscar = idProceso;

                this.Hide();
                frm_Factura.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Seleccione un proceso para finalizar.");
            }
        }

        private void btn_NuevoF_Click(object sender, EventArgs e)
        {
            frm_NuevaVenta frmventa = new frm_NuevaVenta();
            this.Hide();
            frmventa.ShowDialog();
            this.Show();
            llenarGrid();
        }

        private void btn_EliminarF_Click(object sender, EventArgs e)
        {
            if (dtg_Factura.SelectedRows.Count > 0)
            {
                int idProceso = Convert.ToInt32(dtg_Factura.SelectedRows[0].Cells["CodigoF"].Value);
                MessageBox.Show("¿Está seguro de que desea eliminar la factura con ID: " + idProceso + "?");

                factura.EliminarFactura(idProceso);
                llenarGrid();
            }
            else
            {
                MessageBox.Show("Seleccione un proceso para finalizar.");
            }
        }

        private void frm_Facturacion_Load(object sender, EventArgs e)
        {
        }
    }
}
