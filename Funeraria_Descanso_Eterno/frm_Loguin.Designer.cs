namespace Funeraria_Descanso_Eterno
{
    partial class frm_Loguin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_Titulo = new System.Windows.Forms.Panel();
            this.pic_Restaurar = new System.Windows.Forms.PictureBox();
            this.pic_Minimizar = new System.Windows.Forms.PictureBox();
            this.pic_Redimencionar = new System.Windows.Forms.PictureBox();
            this.pic_Cerrar = new System.Windows.Forms.PictureBox();
            this.btn_Siguiente = new System.Windows.Forms.Button();
            this.pnl_Loguin = new System.Windows.Forms.Panel();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_Acceso = new System.Windows.Forms.Label();
            this.pnl_Titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Redimencionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Cerrar)).BeginInit();
            this.pnl_Loguin.SuspendLayout();
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
            this.pnl_Titulo.TabIndex = 1;
            this.pnl_Titulo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Titulo_Paint);
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
            // btn_Siguiente
            // 
            this.btn_Siguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Siguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(209)))));
            this.btn_Siguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Siguiente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Siguiente.ForeColor = System.Drawing.Color.White;
            this.btn_Siguiente.Location = new System.Drawing.Point(48, 306);
            this.btn_Siguiente.Name = "btn_Siguiente";
            this.btn_Siguiente.Size = new System.Drawing.Size(331, 33);
            this.btn_Siguiente.TabIndex = 2;
            this.btn_Siguiente.Text = "Iniciar Sesión";
            this.btn_Siguiente.UseVisualStyleBackColor = false;
            this.btn_Siguiente.Click += new System.EventHandler(this.btn_Siguiente_Click);
            // 
            // pnl_Loguin
            // 
            this.pnl_Loguin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Loguin.BackColor = System.Drawing.Color.White;
            this.pnl_Loguin.Controls.Add(this.txt_Pass);
            this.pnl_Loguin.Controls.Add(this.btn_Siguiente);
            this.pnl_Loguin.Controls.Add(this.txt_Usuario);
            this.pnl_Loguin.Controls.Add(this.lbl_Pass);
            this.pnl_Loguin.Controls.Add(this.lbl_Usuario);
            this.pnl_Loguin.Controls.Add(this.lbl_Acceso);
            this.pnl_Loguin.Location = new System.Drawing.Point(444, 144);
            this.pnl_Loguin.Name = "pnl_Loguin";
            this.pnl_Loguin.Size = new System.Drawing.Size(424, 388);
            this.pnl_Loguin.TabIndex = 3;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Pass.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pass.Location = new System.Drawing.Point(48, 236);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(331, 33);
            this.txt_Pass.TabIndex = 6;
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Usuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Usuario.Location = new System.Drawing.Point(48, 142);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(331, 33);
            this.txt_Usuario.TabIndex = 5;
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pass.Location = new System.Drawing.Point(43, 203);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(118, 30);
            this.lbl_Pass.TabIndex = 4;
            this.lbl_Pass.Text = "Contraseña";
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Usuario.Location = new System.Drawing.Point(43, 109);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(83, 30);
            this.lbl_Usuario.TabIndex = 3;
            this.lbl_Usuario.Text = "Usuario";
            // 
            // lbl_Acceso
            // 
            this.lbl_Acceso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Acceso.AutoSize = true;
            this.lbl_Acceso.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Acceso.Location = new System.Drawing.Point(95, 32);
            this.lbl_Acceso.Name = "lbl_Acceso";
            this.lbl_Acceso.Size = new System.Drawing.Size(244, 37);
            this.lbl_Acceso.TabIndex = 2;
            this.lbl_Acceso.Text = "Acceso al Sistema";
            // 
            // frm_Loguin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.pnl_Loguin);
            this.Controls.Add(this.pnl_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Loguin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Loguin";
            this.Load += new System.EventHandler(this.frm_Loguin_Load);
            this.pnl_Titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Redimencionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Cerrar)).EndInit();
            this.pnl_Loguin.ResumeLayout(false);
            this.pnl_Loguin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Titulo;
        private System.Windows.Forms.PictureBox pic_Restaurar;
        private System.Windows.Forms.PictureBox pic_Minimizar;
        private System.Windows.Forms.PictureBox pic_Redimencionar;
        private System.Windows.Forms.PictureBox pic_Cerrar;
        private System.Windows.Forms.Button btn_Siguiente;
        private System.Windows.Forms.Panel pnl_Loguin;
        private System.Windows.Forms.Label lbl_Pass;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label lbl_Acceso;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.TextBox txt_Pass;
    }
}