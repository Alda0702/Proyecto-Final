using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funeraria_Descanso_Eterno
{
    public partial class frm_Servicios : Form
    {
        public frm_Servicios()
        {
            InitializeComponent();
            llenarGrid();
        }
        Cls_ServiciosCRUD servi = new Cls_ServiciosCRUD();

        public void llenarGrid()
        {
            // Llenar el DataGridView con los datos de la base de datos
            dtg_Servicios.Rows.Clear();
            servi.mostrardata(dtg_Servicios);
        }
        private void btn_NuevoS_Click(object sender, EventArgs e)
        {
            frm_NuevoServicio frmNServicio = new frm_NuevoServicio();
            this.Hide();
            frmNServicio.ShowDialog();
            this.Show();
            llenarGrid();
        }

        private void frm_Servicios_Load(object sender, EventArgs e)
        {

        }

        private void btn_EliminarS_Click(object sender, EventArgs e)
        {
            if (dtg_Servicios.SelectedRows.Count > 0)
            {
                int idProceso = Convert.ToInt32(dtg_Servicios.SelectedRows[0].Cells["Cod"].Value);
                MessageBox.Show("¿Está seguro de que desea eliminar el servicio con ID: " + idProceso + "?");
                servi.EliminarRegistro(idProceso);
                llenarGrid();
            }
            else
            {
                MessageBox.Show("Seleccione un proceso para finalizar.");
            }
        }

        private void txt_BuscarS_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txt_BuscarS.Text.Trim();
            if (!string.IsNullOrEmpty(busqueda))
            {
                dtg_Servicios.Rows.Clear();
                servi.mostrardata(dtg_Servicios, busqueda);
                
            }
            else
            {
                
                llenarGrid();
            }
        }

        private void btn_ActualizarS_Click(object sender, EventArgs e)
        {

        }

        //private void btn_ActualizarS_Click(object sender, EventArgs e)
        //{
            
        //}

        private void btn_ActualizarS_Click_1(object sender, EventArgs e)
        {
            if (dtg_Servicios.SelectedRows.Count > 0)
            {
                MessageBox.Show("¿Está seguro de que desea actualizar el servicio con ID: " + dtg_Servicios.SelectedRows[0].Cells["Cod"].Value + "?");
                
                frm_ActualizarServico frm_ActualizarServico = new frm_ActualizarServico();

                int idProceso = Convert.ToInt32(dtg_Servicios.SelectedRows[0].Cells["Cod"].Value);
                frm_ActualizarServico.txt_NomProd.Text = dtg_Servicios.SelectedRows[0].Cells["NombreP"].Value.ToString();
                frm_ActualizarServico.txt_DescProd.Text = dtg_Servicios.SelectedRows[0].Cells["Desc"].Value.ToString();
                frm_ActualizarServico.txt_CategoriaProd.Text = dtg_Servicios.SelectedRows[0].Cells["Categoria"].Value.ToString();
                frm_ActualizarServico.txt_Duracion.Text = dtg_Servicios.SelectedRows[0].Cells["Duracion"].Value.ToString();
                string precio = dtg_Servicios.SelectedRows[0].Cells["Precio"].Value.ToString();
                string cadenaSinDecimales = precio.Split(',')[0]; // Toma la parte antes de la coma

                frm_ActualizarServico.tx_PrecioProd.Text = cadenaSinDecimales;
                frm_ActualizarServico.idServicio = idProceso;
                this.Hide();
                frm_ActualizarServico.ShowDialog();
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
