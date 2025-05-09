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
    public partial class frm_NuevoProveedor: Form
    {
        public frm_NuevoProveedor()
        {
            InitializeComponent();
        }

        private void pic_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_NombreProv.Text) || string.IsNullOrEmpty(txt_CiudadProv.Text) || string.IsNullOrEmpty(txt_ContactoProv.Text) || string.IsNullOrEmpty(txt_EmailProv.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            string nombre = txt_NombreProv.Text;
            string ciudad = txt_CiudadProv.Text;
            string contacto = txt_ContactoProv.Text;
            string email = (txt_EmailProv.Text);


            Cls_ProveedoresCRUD ADD = new Cls_ProveedoresCRUD();
            ADD.InsertarProveedores(nombre, ciudad, contacto, email);
            MessageBox.Show("Proveedor Agregado");
            this.Close();
        }
    }
}
