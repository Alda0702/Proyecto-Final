namespace Funeraria_Descanso_Eterno
{
    partial class frm_Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_Titulo = new System.Windows.Forms.Panel();
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.pnl_Contenedor = new System.Windows.Forms.Panel();
            this.btn_Facturación = new System.Windows.Forms.Button();
            this.btn_Proveedores = new System.Windows.Forms.Button();
            this.btn_Servicios = new System.Windows.Forms.Button();
            this.btn_Inventario = new System.Windows.Forms.Button();
            this.btn_Empleados = new System.Windows.Forms.Button();
            this.btn_Registro_Cliente = new System.Windows.Forms.Button();
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            this.pic_Restaurar = new System.Windows.Forms.PictureBox();
            this.pic_Minimizar = new System.Windows.Forms.PictureBox();
            this.pic_Redimencionar = new System.Windows.Forms.PictureBox();
            this.pic_Cerrar = new System.Windows.Forms.PictureBox();
            this.pnl_Titulo.SuspendLayout();
            this.pnl_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Redimencionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Titulo
            // 
            this.pnl_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(209)))));
            this.pnl_Titulo.Controls.Add(this.pic_Restaurar);
            this.pnl_Titulo.Controls.Add(this.pic_Minimizar);
            this.pnl_Titulo.Controls.Add(this.pic_Redimencionar);
            this.pnl_Titulo.Controls.Add(this.pic_Cerrar);
            this.pnl_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Titulo.Name = "pnl_Titulo";
            this.pnl_Titulo.Size = new System.Drawing.Size(1300, 38);
            this.pnl_Titulo.TabIndex = 0;
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnl_Menu.Controls.Add(this.btn_Facturación);
            this.pnl_Menu.Controls.Add(this.btn_Proveedores);
            this.pnl_Menu.Controls.Add(this.btn_Servicios);
            this.pnl_Menu.Controls.Add(this.btn_Inventario);
            this.pnl_Menu.Controls.Add(this.btn_Empleados);
            this.pnl_Menu.Controls.Add(this.btn_Registro_Cliente);
            this.pnl_Menu.Controls.Add(this.pic_Logo);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 38);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(200, 612);
            this.pnl_Menu.TabIndex = 1;
            // 
            // pnl_Contenedor
            // 
            this.pnl_Contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.pnl_Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Contenedor.Location = new System.Drawing.Point(200, 38);
            this.pnl_Contenedor.Name = "pnl_Contenedor";
            this.pnl_Contenedor.Size = new System.Drawing.Size(1100, 612);
            this.pnl_Contenedor.TabIndex = 2;
            // 
            // btn_Facturación
            // 
            this.btn_Facturación.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Facturación.FlatAppearance.BorderSize = 0;
            this.btn_Facturación.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(209)))));
            this.btn_Facturación.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Facturación.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Facturación.Image = global::Funeraria_Descanso_Eterno.Properties.Resources.image__6_;
            this.btn_Facturación.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Facturación.Location = new System.Drawing.Point(0, 306);
            this.btn_Facturación.Name = "btn_Facturación";
            this.btn_Facturación.Size = new System.Drawing.Size(200, 37);
            this.btn_Facturación.TabIndex = 6;
            this.btn_Facturación.Text = "Facturación";
            this.btn_Facturación.UseVisualStyleBackColor = false;
            this.btn_Facturación.Click += new System.EventHandler(this.btn_Facturación_Click);
            // 
            // btn_Proveedores
            // 
            this.btn_Proveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Proveedores.FlatAppearance.BorderSize = 0;
            this.btn_Proveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(209)))));
            this.btn_Proveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Proveedores.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Proveedores.Image = global::Funeraria_Descanso_Eterno.Properties.Resources.image__5_;
            this.btn_Proveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Proveedores.Location = new System.Drawing.Point(0, 263);
            this.btn_Proveedores.Name = "btn_Proveedores";
            this.btn_Proveedores.Size = new System.Drawing.Size(200, 37);
            this.btn_Proveedores.TabIndex = 5;
            this.btn_Proveedores.Text = "Proveedores";
            this.btn_Proveedores.UseVisualStyleBackColor = false;
            this.btn_Proveedores.Click += new System.EventHandler(this.btn_Proveedores_Click);
            // 
            // btn_Servicios
            // 
            this.btn_Servicios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Servicios.FlatAppearance.BorderSize = 0;
            this.btn_Servicios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(209)))));
            this.btn_Servicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Servicios.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Servicios.Image = global::Funeraria_Descanso_Eterno.Properties.Resources.image__4_;
            this.btn_Servicios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Servicios.Location = new System.Drawing.Point(0, 220);
            this.btn_Servicios.Name = "btn_Servicios";
            this.btn_Servicios.Size = new System.Drawing.Size(200, 37);
            this.btn_Servicios.TabIndex = 4;
            this.btn_Servicios.Text = "Servicos";
            this.btn_Servicios.UseVisualStyleBackColor = false;
            this.btn_Servicios.Click += new System.EventHandler(this.btn_Servicios_Click);
            // 
            // btn_Inventario
            // 
            this.btn_Inventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Inventario.FlatAppearance.BorderSize = 0;
            this.btn_Inventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(209)))));
            this.btn_Inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Inventario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inventario.Image = global::Funeraria_Descanso_Eterno.Properties.Resources.image__3_;
            this.btn_Inventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Inventario.Location = new System.Drawing.Point(0, 177);
            this.btn_Inventario.Name = "btn_Inventario";
            this.btn_Inventario.Size = new System.Drawing.Size(200, 37);
            this.btn_Inventario.TabIndex = 3;
            this.btn_Inventario.Text = "Inventario";
            this.btn_Inventario.UseVisualStyleBackColor = false;
            this.btn_Inventario.Click += new System.EventHandler(this.btn_Inventario_Click);
            // 
            // btn_Empleados
            // 
            this.btn_Empleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Empleados.FlatAppearance.BorderSize = 0;
            this.btn_Empleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(209)))));
            this.btn_Empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Empleados.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Empleados.Image = global::Funeraria_Descanso_Eterno.Properties.Resources.image__2_1;
            this.btn_Empleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Empleados.Location = new System.Drawing.Point(0, 134);
            this.btn_Empleados.Name = "btn_Empleados";
            this.btn_Empleados.Size = new System.Drawing.Size(200, 37);
            this.btn_Empleados.TabIndex = 2;
            this.btn_Empleados.Text = "Empleados";
            this.btn_Empleados.UseVisualStyleBackColor = false;
            this.btn_Empleados.Click += new System.EventHandler(this.btn_Empleados_Click);
            // 
            // btn_Registro_Cliente
            // 
            this.btn_Registro_Cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Registro_Cliente.FlatAppearance.BorderSize = 0;
            this.btn_Registro_Cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(209)))));
            this.btn_Registro_Cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Registro_Cliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registro_Cliente.Image = global::Funeraria_Descanso_Eterno.Properties.Resources.image__1___1_;
            this.btn_Registro_Cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Registro_Cliente.Location = new System.Drawing.Point(0, 91);
            this.btn_Registro_Cliente.Name = "btn_Registro_Cliente";
            this.btn_Registro_Cliente.Size = new System.Drawing.Size(200, 37);
            this.btn_Registro_Cliente.TabIndex = 1;
            this.btn_Registro_Cliente.Text = "Clientes";
            this.btn_Registro_Cliente.UseVisualStyleBackColor = false;
            this.btn_Registro_Cliente.Click += new System.EventHandler(this.btn_Registro_Cliente_Click);
            // 
            // pic_Logo
            // 
            this.pic_Logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Logo.Image = global::Funeraria_Descanso_Eterno.Properties.Resources.WhatsApp_Image_2025_04_26_at_7_46_00_PM__2_;
            this.pic_Logo.Location = new System.Drawing.Point(0, 0);
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.Size = new System.Drawing.Size(200, 85);
            this.pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Logo.TabIndex = 0;
            this.pic_Logo.TabStop = false;
            this.pic_Logo.Click += new System.EventHandler(this.pic_Logo_Click);
            // 
            // pic_Restaurar
            // 
            this.pic_Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Restaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Restaurar.Image = global::Funeraria_Descanso_Eterno.Properties.Resources.res;
            this.pic_Restaurar.Location = new System.Drawing.Point(1232, 7);
            this.pic_Restaurar.Name = "pic_Restaurar";
            this.pic_Restaurar.Size = new System.Drawing.Size(25, 25);
            this.pic_Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Restaurar.TabIndex = 2;
            this.pic_Restaurar.TabStop = false;
            this.pic_Restaurar.Visible = false;
            this.pic_Restaurar.Click += new System.EventHandler(this.pic_Restaurar_Click);
            // 
            // pic_Minimizar
            // 
            this.pic_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Minimizar.Image = global::Funeraria_Descanso_Eterno.Properties.Resources.minimazar;
            this.pic_Minimizar.Location = new System.Drawing.Point(1191, 7);
            this.pic_Minimizar.Name = "pic_Minimizar";
            this.pic_Minimizar.Size = new System.Drawing.Size(25, 25);
            this.pic_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Minimizar.TabIndex = 2;
            this.pic_Minimizar.TabStop = false;
            this.pic_Minimizar.Click += new System.EventHandler(this.pic_Minimizar_Click);
            // 
            // pic_Redimencionar
            // 
            this.pic_Redimencionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Redimencionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Redimencionar.Image = global::Funeraria_Descanso_Eterno.Properties.Resources.maxi;
            this.pic_Redimencionar.Location = new System.Drawing.Point(1232, 7);
            this.pic_Redimencionar.Name = "pic_Redimencionar";
            this.pic_Redimencionar.Size = new System.Drawing.Size(25, 25);
            this.pic_Redimencionar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Redimencionar.TabIndex = 1;
            this.pic_Redimencionar.TabStop = false;
            this.pic_Redimencionar.Click += new System.EventHandler(this.pic_Redimencionar_Click);
            // 
            // pic_Cerrar
            // 
            this.pic_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Cerrar.Image = global::Funeraria_Descanso_Eterno.Properties.Resources.cerrar;
            this.pic_Cerrar.Location = new System.Drawing.Point(1272, 7);
            this.pic_Cerrar.Name = "pic_Cerrar";
            this.pic_Cerrar.Size = new System.Drawing.Size(25, 25);
            this.pic_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Cerrar.TabIndex = 0;
            this.pic_Cerrar.TabStop = false;
            this.pic_Cerrar.Click += new System.EventHandler(this.pic_Cerrar_Click);
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.pnl_Contenedor);
            this.Controls.Add(this.pnl_Menu);
            this.Controls.Add(this.pnl_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_Menu_Load);
            this.pnl_Titulo.ResumeLayout(false);
            this.pnl_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Redimencionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Cerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Titulo;
        private System.Windows.Forms.Panel pnl_Menu;
        private System.Windows.Forms.PictureBox pic_Cerrar;
        private System.Windows.Forms.PictureBox pic_Minimizar;
        private System.Windows.Forms.PictureBox pic_Redimencionar;
        private System.Windows.Forms.PictureBox pic_Restaurar;
        private System.Windows.Forms.PictureBox pic_Logo;
        private System.Windows.Forms.Button btn_Registro_Cliente;
        public System.Windows.Forms.Panel pnl_Contenedor;
        private System.Windows.Forms.Button btn_Proveedores;
        private System.Windows.Forms.Button btn_Servicios;
        private System.Windows.Forms.Button btn_Inventario;
        private System.Windows.Forms.Button btn_Empleados;
        private System.Windows.Forms.Button btn_Facturación;
    }
}

