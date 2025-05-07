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
            llenarGrid();
        }

        Cls_ClienteCRUD client = new Cls_ClienteCRUD();

        private void pnl_Buscar_Paint(object sender, PaintEventArgs e)
        {

        }

        public void llenarGrid()
        {
            // Llenar el DataGridView con los datos de la base de datos
            dtg_Clientes.Rows.Clear();
            client.mostrarcliente(dtg_Clientes);
            //Actualiza label segun cantidad de filas
            ActualizarConteo();
        }

        private void lbl_Complemento_Cantidad_Click(object sender, EventArgs e)
        {

        }

        private void btn_NuevoC_Click(object sender, EventArgs e)
        {
            using (var frm = new frm_NuevoCliente())
            {
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            llenarGrid();
        }

        private void btn_EliminarC_Click(object sender, EventArgs e)
        {
            if (dtg_Clientes.SelectedRows.Count > 0)
            {
                int idProceso = Convert.ToInt32(dtg_Clientes.SelectedRows[0].Cells["ID"].Value);
                MessageBox.Show("¿Está seguro de que desea eliminar el servicio con ID: " + idProceso + "?");
                client.EliminarRegistro(idProceso);
                llenarGrid();
            }
            else
            {
                MessageBox.Show("Seleccione un proceso para finalizar.");
            }
        }

        private void dtg_Clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txt_Buscar.Text.Trim();
            if (!string.IsNullOrEmpty(busqueda))
            {
                dtg_Clientes.Rows.Clear();
                client.mostrarcliente(dtg_Clientes, busqueda);

            }
            else
            {

                llenarGrid();
            }
            ActualizarConteo();
        }

        private void ActualizarConteo()
        {
            // Cuenta solo las filas que no son la fila “nueva” de inserción
            int totalClientes = dtg_Clientes.Rows
                .Cast<DataGridViewRow>()
                .Count(r => !r.IsNewRow);

            lbl_Cantidad.Text = totalClientes.ToString();
        }

        private void lbl_Buscar_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Cantidad_Click(object sender, EventArgs e)
        {

        }
    }
}
