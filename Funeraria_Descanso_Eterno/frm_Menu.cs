using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funeraria_Descanso_Eterno
{
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }

        private void pic_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pic_Redimencionar_Click(object sender, EventArgs e)
        {
            //Maximixa la Pantalla con el PictureBox         
            this.WindowState= FormWindowState.Maximized;
            pic_Redimencionar.Visible = false;
            pic_Restaurar.Visible = true;
        }

        private void pic_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pic_Restaurar_Click(object sender, EventArgs e)
        {
            //Regresa al estado normal la pantalla clickeando el PictureBox
            this.WindowState = FormWindowState.Normal;
            pic_Restaurar.Visible = false;
            pic_Redimencionar.Visible = true;
        }

        private void btn_Registro_Cliente_Click(object sender, EventArgs e)
        {
            //LLama la clase AbrirForm para ejecutar el form en el panel Contenedor 
            Cls_AbrirForm abrir = new Cls_AbrirForm();
            abrir.abrirForm(new frm_Registro_Cliente(), this.pnl_Contenedor);
        }

        private void pic_Logo_Click(object sender, EventArgs e)
        {
            //LLama la clase AbrirForm para ejecutar el form en el panel Contenedor 

            Cls_AbrirForm abrir = new Cls_AbrirForm();
            abrir.abrirForm(new frm_Inicio(), this.pnl_Contenedor);
        }

        private void frm_Menu_Load(object sender, EventArgs e)
        {
            //La pantalla en la que se iniciara dentro del panel COntenedor sera la del form de Inicio
            pic_Logo_Click(null, e);
        }

        private void btn_Empleados_Click(object sender, EventArgs e)
        {
            //LLama la clase AbrirForm para ejecutar el form en el panel Contenedor 
            Cls_AbrirForm abrir = new Cls_AbrirForm();
            abrir.abrirForm(new frm_Empleados(), this.pnl_Contenedor);
        }

        private void btn_Inventario_Click(object sender, EventArgs e)
        {
            //LLama la clase AbrirForm para ejecutar el form en el panel Contenedor 
            Cls_AbrirForm abrir = new Cls_AbrirForm();
            abrir.abrirForm(new frm_Inventario(), this.pnl_Contenedor);
        }

        private void btn_Servicios_Click(object sender, EventArgs e)
        {
            //LLama la clase AbrirForm para ejecutar el form en el panel Contenedor 
            Cls_AbrirForm abrir = new Cls_AbrirForm();
            abrir.abrirForm(new frm_Servicios(), this.pnl_Contenedor);
        }

        private void btn_Proveedores_Click(object sender, EventArgs e)
        {
            //LLama la clase AbrirForm para ejecutar el form en el panel Contenedor 
            Cls_AbrirForm abrir = new Cls_AbrirForm();
            abrir.abrirForm(new frm_Proveedores(), this.pnl_Contenedor);
        }

        private void btn_Facturación_Click(object sender, EventArgs e)
        {
            //LLama la clase AbrirForm para ejecutar el form en el panel Contenedor 
            Cls_AbrirForm abrir = new Cls_AbrirForm();
            abrir.abrirForm(new frm_Facturacion(), this.pnl_Contenedor);
        }
    }

}
