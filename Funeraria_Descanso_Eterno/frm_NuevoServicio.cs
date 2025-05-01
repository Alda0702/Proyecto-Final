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
    public partial class frm_NuevoServicio : Form
    {
        public frm_NuevoServicio()
        {
            InitializeComponent();
        }

        private void pic_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pic_Minimizar_Click(object sender, EventArgs e)
        {
            //Minimiza la pestalla dandole clic en el pictureBox de minimizar 
            this.WindowState = FormWindowState.Minimized;

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            //Validar que los campos no esten vacios
            if (string.IsNullOrEmpty(txt_NomServ.Text) || string.IsNullOrEmpty(txt_DescServ.Text) || string.IsNullOrEmpty(txt_CategoriaServ.Text) || string.IsNullOrEmpty(txt_Duracion.Text) || string.IsNullOrEmpty(tx_PrecioServ.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            string nombre = txt_NomServ.Text;
            string descripcion = txt_DescServ.Text;
            string categoria = txt_CategoriaServ.Text;
            int duracion = Convert.ToInt32(txt_Duracion.Text);
            decimal precio = Convert.ToDecimal(tx_PrecioServ.Text);

            Cls_ServiciosCRUD ADD = new Cls_ServiciosCRUD();
            ADD.InsertarServicios(nombre, descripcion, categoria, duracion, precio);
            MessageBox.Show("Servicio Agregado");
            this.Close();
            
        }
    }
}
