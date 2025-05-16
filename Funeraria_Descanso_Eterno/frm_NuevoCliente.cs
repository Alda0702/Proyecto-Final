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
    public partial class frm_NuevoCliente : Form
    {

        public frm_NuevoCliente()
        {
            InitializeComponent();
        }

        private void pic_Restaurar_Click(object sender, EventArgs e)
        {

        }

        private void pic_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void pic_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pic_Redimencionar_Click(object sender, EventArgs e)
        {
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btn_Confirmar_Click(object sender, EventArgs e)
        {
            string tipoc = cmb_Tdoc.Text;
            string doc = txt_Tdoc.Text;
            string nombre = txt_NomC.Text;
            string apellidoP = txt_ApellidoPC.Text;
            string apellidoM = txt_ApellidoMC.Text;
            string nacimiento = txt_Nacimiento.Text;
            string sexo = cmb_Sexo.Text;
            string pais = txt_Pais.Text;
            string depto = txt_Departamento.Text;
            string ciudad = txt_Ciudad.Text;
            string direccion = txt_Direccion.Text;
            string telefono = txt_Cel.Text;
            string email = txt_Email.Text;

            if (string.IsNullOrEmpty(cmb_Tdoc.Text) || string.IsNullOrEmpty(txt_Tdoc.Text) || string.IsNullOrEmpty(txt_NomC.Text) || string.IsNullOrEmpty(txt_ApellidoPC.Text) || string.IsNullOrEmpty(txt_ApellidoMC.Text) || string.IsNullOrEmpty(txt_Nacimiento.Text) || string.IsNullOrEmpty(cmb_Sexo.Text) || string.IsNullOrEmpty(txt_Pais.Text) || string.IsNullOrEmpty(txt_Departamento.Text) || string.IsNullOrEmpty(txt_Ciudad.Text) || string.IsNullOrEmpty(txt_Direccion.Text) || string.IsNullOrEmpty(txt_Cel.Text) || string.IsNullOrEmpty(txt_Email.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos");
                return;
            }

            Cls_ClienteCRUD clientesCrud = new Cls_ClienteCRUD();
            //clientesCrud.CrearTablaCliente();
            clientesCrud.InsertarCliente(tipoc, doc, nombre, apellidoP, apellidoM, nacimiento, sexo, pais, depto, ciudad, direccion, telefono, email);
            this.Hide();
        }
    }
}
