using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Funeraria_Descanso_Eterno.Cls_InventarioCRUD;

namespace Funeraria_Descanso_Eterno
{
    public partial class frm_Inventario : Form
    {
        Cls_InventarioCRUD inventario = new Cls_InventarioCRUD();
        public frm_Inventario()
        {
            InitializeComponent();
        }

        public void llenarGridProd()
        {
            inventario.MostrarInventario(dtg_Inventario);
        }
        private void btn_NuevoI_Click(object sender, EventArgs e)
        {
            frm_NuevoProducto frm_NuevoProducto = new frm_NuevoProducto();
            this.Hide();
            frm_NuevoProducto.ShowDialog();
            this.Show();
        }

        private void btn_EliminarI_Click(object sender, EventArgs e)
        {
            Cls_InventarioCRUD inventario = new Cls_InventarioCRUD();
            int codigoProducto = Convert.ToInt32(dtg_Inventario.SelectedRows[0].Cells["Cod"].Value);
            inventario.EliminarProducto(codigoProducto);
        }

        private void frm_Inventario_Load(object sender, EventArgs e)
        {
            llenarGridProd();
        }

        private void txt_BuscarI_TextChanged(object sender, EventArgs e)
        {
            string texto = txt_BuscarI.Text;
            inventario.BoscarProducto(dtg_Inventario, texto);

        }
    }
}
