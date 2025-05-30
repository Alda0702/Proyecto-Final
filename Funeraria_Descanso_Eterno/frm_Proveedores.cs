using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Funeraria_Descanso_Eterno.Cls_EmpleadoCRUD;

namespace Funeraria_Descanso_Eterno
{
    public partial class frm_Proveedores : Form
    {
        public frm_Proveedores()
        {
            InitializeComponent();
        }

        Cls_ProveedoresCRUD Provedores = new Cls_ProveedoresCRUD();
        private void btn_NuevoProv_Click(object sender, EventArgs e)
        {
            frm_NuevoProveedor frm_Proveedor = new frm_NuevoProveedor();
            this.Hide();
            frm_Proveedor.ShowDialog();
            this.Show();
            llenarGrid(); 
        }
        
        private void llenarGrid()
        {
            dtg_Proveedores.Rows.Clear();
            Provedores.mostrardataProv(dtg_Proveedores);
        }

        private void btn_ActualizarProv_Click(object sender, EventArgs e)
        {
            frm_ActualizarProveedor frm_Proveedores = new frm_ActualizarProveedor();

            int idProve = Convert.ToInt32(dtg_Proveedores.SelectedRows[0].Cells["Cod"].Value);

            frm_Proveedores.txt_NomProv.Text = dtg_Proveedores.SelectedRows[0].Cells["NombreP"].Value.ToString();
            frm_Proveedores.txt_DescProv.Text = dtg_Proveedores.SelectedRows[0].Cells["Contacto"].Value.ToString();
            frm_Proveedores.txt_Contacto.Text = dtg_Proveedores.SelectedRows[0].Cells["email"].Value.ToString();
            frm_Proveedores.txt_Email.Text = dtg_Proveedores.SelectedRows[0].Cells["Ciudad"].Value.ToString();

            frm_Proveedores.idproveedor = idProve;

            this.Hide();
            frm_Proveedores.ShowDialog();
            this.Show();
            llenarGrid();
        }

        private void frm_Proveedores_Load(object sender, EventArgs e)
        {
            Provedores.mostrardataProv(dtg_Proveedores);
        }

        private void btn_EliminarProv_Click(object sender, EventArgs e)
        {
            if (dtg_Proveedores.SelectedRows.Count > 0)
            {
                int idProceso = Convert.ToInt32(dtg_Proveedores.SelectedRows[0].Cells["Cod"].Value);
                MessageBox.Show("¿Está seguro de que desea eliminar el Proovedor con ID: " + idProceso + "?");
                Provedores.EliminarRegistroProv(idProceso);
                llenarGrid();
            }
            else
            {
                MessageBox.Show("Seleccione un proceso para finalizar.");
            }
        }
    }
}
