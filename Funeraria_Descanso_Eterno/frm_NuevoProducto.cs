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
    public partial class frm_NuevoProducto : Form
    {
        public frm_NuevoProducto()
        {
            InitializeComponent();
        }

        private void frm_NuevoProducto_Load(object sender, EventArgs e)
        {

        }

        private void pic_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pic_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void lbl_CategoriaProd_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Cantidad_Click(object sender, EventArgs e)
        {

        }

        private void lbl_PrecioProd_Click(object sender, EventArgs e)
        {

        }

        private void tx_PrecioProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Cantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_CategoriaProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_NomProd.Text) || string.IsNullOrEmpty(txt_DescProd.Text) || string.IsNullOrEmpty(txt_CategoriaProd.Text) || string.IsNullOrEmpty(txt_Cantidad.Text) || string.IsNullOrEmpty(tx_PrecioProd.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            string nombre = txt_NomProd.Text;
            string descripcion = txt_DescProd.Text;
            string categoria = txt_CategoriaProd.Text;
            int cantidad = Convert.ToInt32(txt_Cantidad.Text);
            int precio = Convert.ToInt32(tx_PrecioProd.Text);

            MessageBox.Show("Producto Agregado");
            Inventario ADD = new Inventario();
            ADD.InsertarProducto(nombre, descripcion, categoria, cantidad, precio);

        }
    }
}
