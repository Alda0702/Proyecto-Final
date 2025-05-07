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
    public partial class frm_ActualizarServico : Form
    {
        Cls_ServiciosCRUD serviciosCRUD = new Cls_ServiciosCRUD();
        public frm_ActualizarServico()
        {
            InitializeComponent();
        }

        private void lbl_Actua_Click(object sender, EventArgs e)
        {

        }

        private void pic_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int idServicio;
        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            //Validar que los campos no esten vacios
            if (string.IsNullOrEmpty(txt_NomProd.Text) || string.IsNullOrEmpty(txt_DescProd.Text) || string.IsNullOrEmpty(txt_CategoriaProd.Text) || string.IsNullOrEmpty(txt_Duracion.Text) || string.IsNullOrEmpty(tx_PrecioProd.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            serviciosCRUD.ModificarServicio(idServicio, txt_NomProd.Text, txt_DescProd.Text, txt_CategoriaProd.Text, Convert.ToInt32(txt_Duracion.Text), Convert.ToDecimal(tx_PrecioProd.Text));    
            MessageBox.Show("Servicio Actualizado");
            this.Close();
        }
    }
}
