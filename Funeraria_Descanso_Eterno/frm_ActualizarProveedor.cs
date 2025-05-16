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
    
    public partial class frm_ActualizarProveedor : Form
    {
        public int idproveedor;
        public frm_ActualizarProveedor()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void pic_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_NomProv.Text) || string.IsNullOrEmpty(txt_DescProv.Text) || string.IsNullOrEmpty(txt_Contacto.Text) || string.IsNullOrEmpty(txt_Email.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            string nombre = txt_NomProv.Text;
            string ciudad = txt_DescProv.Text;
            string contacto = txt_Contacto.Text;
            string email = (txt_Email.Text);


            Cls_ProveedoresCRUD ADD = new Cls_ProveedoresCRUD();
            ADD.ModificarProveedor(idproveedor, nombre, ciudad, contacto, email);
            MessageBox.Show("Proveedor Actualizado");
            this.Close();
        }
    }
}
