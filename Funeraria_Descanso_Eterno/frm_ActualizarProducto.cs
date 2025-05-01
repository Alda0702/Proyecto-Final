using Finisar.SQLite;
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
    public partial class frm_ActualizarProducto : Form
    {
        public int codigoProducto;
        Cls_InventarioCRUD inventarioCRUD = new Cls_InventarioCRUD();

        public frm_ActualizarProducto()
        {
            InitializeComponent();

        }

        private void pic_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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

            inventarioCRUD.ModificarProducto(codigoProducto, txt_NomProd.Text, txt_DescProd.Text, txt_CategoriaProd.Text, Convert.ToInt32(txt_Cantidad.Text), Convert.ToDecimal(tx_PrecioProd.Text));
            MessageBox.Show("Servicio Actualizado");
            this.Close();
        }

        private void frm_ActualizarProducto_Load(object sender, EventArgs e)
        {
           
        }
    }
}
