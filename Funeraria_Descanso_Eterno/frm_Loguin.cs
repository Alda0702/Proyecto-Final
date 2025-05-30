using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finisar.SQLite;

namespace Funeraria_Descanso_Eterno
{
    public partial class frm_Loguin : Form
    {
        public frm_Loguin()
        {
            InitializeComponent();
        }

        private void frm_Loguin_Load(object sender, EventArgs e)
        {
        }

        private void pic_Cerrar_Click(object sender, EventArgs e)
        {
            // Cerrar la aplicación
            Application.Exit();
        }

        private void pic_Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pic_Restaurar.Visible = false;
            pic_Redimencionar.Visible = true;
        }

        private void pic_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void pic_Redimencionar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pic_Redimencionar.Visible = false;
            pic_Restaurar.Visible = true;
        }
        string rol;

        private void btn_Siguiente_Click(object sender, EventArgs e)
        {

            Cls_Factura bb = new Cls_Factura();
            bb.Eliminar();

            string usuario = txt_Usuario.Text;
            string contraseña = txt_Pass.Text;

            if (Cls_LoginCRUD.AutenticarUsuario(usuario, contraseña, out rol))
            {
                MessageBox.Show("Inicio de sesión exitoso, Bienvenido Empleado " + rol);


                frm_Menu frm_Menu;
                frm_Menu = frm_Menu.Instancia;
                frm_Menu.loginrol = rol;
                this.Hide();
                frm_Menu.ShowDialog();
                

            }

            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
            Cls_ConexionDB a = Cls_ConexionDB.Instancia;

        }





        private void pnl_Titulo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
