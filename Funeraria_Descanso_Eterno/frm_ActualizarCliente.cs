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
    public partial class frm_ActualizarCliente : Form
    {
        Cls_ClienteCRUD clienteCRUD = new Cls_ClienteCRUD();
        public int idCliente;
        public frm_ActualizarCliente()
        {
            InitializeComponent();

        }

        public void pic_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int IdCliente;


        public void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_NomC.Text) || string.IsNullOrEmpty(txt_ApellidoPC.Text) || string.IsNullOrEmpty(txt_ApellidoMC.Text) || string.IsNullOrEmpty(txt_Cel.Text) || string.IsNullOrEmpty(txt_Email.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            clienteCRUD.ModificarCliente(idCliente, cmb_Tdoc.Text, txt_Tdoc.Text, txt_NomC.Text, txt_ApellidoPC.Text, txt_ApellidoMC.Text, txt_Nacimiento.Text, cmb_Sexo.Text, txt_Pais.Text, txt_Departamento.Text, txt_Ciudad.Text, txt_Direccion.Text, txt_Cel.Text, txt_Email.Text);
            MessageBox.Show("Servicio Actualizado");
            this.Close();
        }

        private void txt_Cel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
