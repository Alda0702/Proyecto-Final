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


    public partial class frm_NuevoUsario : Form
    {
        public static string LastEmpleadoID { get; set; }  // Variable estática para almacenar el último ID de empleado

        private static frm_NuevoUsario instancia;

        public frm_NuevoUsario()
        {
            InitializeComponent();
        }
        public static frm_NuevoUsario Instancia
        {
            get
            {
                if (instancia == null || instancia.IsDisposed)
                {
                    instancia = new frm_NuevoUsario();
                }
                return instancia;
            }
        }

        private void pic_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pic_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void pnl_Loguin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Siguiente_Click(object sender, EventArgs e)
        {


            ClsLogin nuevoUsuario = new ClsLogin
            {
                Usuario = txt_Usuario.Text,
                Contraseña = txt_Pass.Text
            };

            string idEmpleado = LastEmpleadoID;

            // Insertar el usuario usando el ID del empleado
            Cls_UsuariosCRUD.usuariodb userdb = new Cls_UsuariosCRUD.usuariodb();
            //userdb.CrearTablaUsuario();
            userdb.InsertarUsuario(nuevoUsuario, idEmpleado);
            frm_Menu.Instancia.Show();


            MessageBox.Show($"Usuario registrado correctamente con ID de empleado: {idEmpleado}");


        }

        private void frm_NuevoUsario_Load(object sender, EventArgs e)
        {

        }
    }
}
