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

private void btn_ActualizarC_Click(object sender, EventArgs e)
        {
            if (dtg_Clientes.SelectedRows.Count > 0)
            {
                MessageBox.Show("¿Está seguro de que desea actualizar el servicio con ID: " + dtg_Clientes.SelectedRows[0].Cells["ID"].Value + "?");

                frm_ActualizarCliente frm_ActualizarCliente = new frm_ActualizarCliente();

                int idProceso = Convert.ToInt32(dtg_Clientes.SelectedRows[0].Cells["ID"].Value);
                frm_ActualizarCliente.txt_NomC.Text = dtg_Clientes.SelectedRows[0].Cells["Nombre"].Value.ToString();
                frm_ActualizarCliente.txt_ApellidoPC.Text = dtg_Clientes.SelectedRows[0].Cells["ApellidoP"].Value.ToString();
                frm_ActualizarCliente.txt_ApellidoMC.Text = dtg_Clientes.SelectedRows[0].Cells["ApellidoM"].Value.ToString();
                frm_ActualizarCliente.txt_Cel.Text = dtg_Clientes.SelectedRows[0].Cells["Celular"].Value.ToString();
                frm_ActualizarCliente.txt_Email.Text = dtg_Clientes.SelectedRows[0].Cells["Correo_Electrónico"].Value.ToString();
                frm_ActualizarCliente.cmb_Tdoc.Text = dtg_Clientes.SelectedRows[0].Cells["Tipo_Doc"].Value.ToString();
                frm_ActualizarCliente.txt_Tdoc.Text = dtg_Clientes.SelectedRows[0].Cells["Cedula_Cliente"].Value.ToString();
                frm_ActualizarCliente.txt_Nacimiento.Text = dtg_Clientes.SelectedRows[0].Cells["Fecha_N"].Value.ToString();
                frm_ActualizarCliente.cmb_Sexo.Text = dtg_Clientes.SelectedRows[0].Cells["Sexo_C"].Value.ToString();
                frm_ActualizarCliente.txt_Pais.Text = dtg_Clientes.SelectedRows[0].Cells["Pais"].Value.ToString();
                frm_ActualizarCliente.txt_Departamento.Text = dtg_Clientes.SelectedRows[0].Cells["Departamento_C"].Value.ToString();
                frm_ActualizarCliente.txt_Ciudad.Text = dtg_Clientes.SelectedRows[0].Cells["Ciudad_C"].Value.ToString();
                frm_ActualizarCliente.txt_Direccion.Text = dtg_Clientes.SelectedRows[0].Cells["Direccion_C"].Value.ToString();

                frm_ActualizarCliente.idCliente = idProceso;
                this.Hide();
                frm_ActualizarCliente.ShowDialog();
                this.Show();
                llenarGrid();

            }
            else
            {
                MessageBox.Show("Seleccione un proceso para editar.");
            }
        }
    }
}
