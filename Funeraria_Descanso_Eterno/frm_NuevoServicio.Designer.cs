namespace Funeraria_Descanso_Eterno
{
    partial class frm_NuevoServicio
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
            this.pic_Restaurar = new System.Windows.Forms.PictureBox();
            this.pic_Minimizar = new System.Windows.Forms.PictureBox();
            this.pic_Cerrar = new System.Windows.Forms.PictureBox();
            this.tx_PrecioServ = new System.Windows.Forms.TextBox();
            this.pnl_NuevoCl = new System.Windows.Forms.Panel();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.txt_CodigoServ = new System.Windows.Forms.TextBox();
            this.lbl_Cod = new System.Windows.Forms.Label();
            this.txt_Duracion = new System.Windows.Forms.TextBox();
            this.txt_CategoriaServ = new System.Windows.Forms.TextBox();
            this.txt_DescServ = new System.Windows.Forms.TextBox();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.lbl_CategoriaServ = new System.Windows.Forms.Label();
            this.lbl_Duracion = new System.Windows.Forms.Label();
            this.lbl_PrecioServ = new System.Windows.Forms.Label();
            this.lbl_NomServ = new System.Windows.Forms.Label();
            this.txt_NomServ = new System.Windows.Forms.TextBox();
            this.lbl_Inf = new System.Windows.Forms.Label();
            this.lbl_Regis = new System.Windows.Forms.Label();
            this.pic_Redimencionar = new System.Windows.Forms.PictureBox();
            this.pnl_Titulo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Cerrar)).BeginInit();
            this.pnl_NuevoCl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Redimencionar)).BeginInit();
            this.pnl_Titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_Restaurar
            // 
            this.pic_Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Restaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Restaurar.Image = global::Funeraria_Descanso_Eterno.Properties.Resources.res;
            this.pic_Restaurar.Location = new System.Drawing.Point(1032, 7);
            this.pic_Restaurar.Name = "pic_Restaurar";
            this.pic_Restaurar.Size = new System.Drawing.Size(25, 25);
            this.pic_Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Restaurar.TabIndex = 2;
            this.pic_Restaurar.TabStop = false;
            this.pic_Restaurar.Visible = false;
            // 
            // pic_Minimizar
            // 
            this.pic_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Minimizar.Image = global::Funeraria_Descanso_Eterno.Properties.Resources.minimazar;
            this.pic_Minimizar.Location = new System.Drawing.Point(991, 7);
            this.pic_Minimizar.Name = "pic_Minimizar";
            this.pic_Minimizar.Size = new System.Drawing.Size(25, 25);
            this.pic_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Minimizar.TabIndex = 2;
            this.pic_Minimizar.TabStop = false;
            this.pic_Minimizar.Click += new System.EventHandler(this.pic_Minimizar_Click);
            // 
            // pic_Cerrar
            // 
            this.pic_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Cerrar.Image = global::Funeraria_Descanso_Eterno.Properties.Resources.cerrar;
            this.pic_Cerrar.Location = new System.Drawing.Point(1072, 7);
            this.pic_Cerrar.Name = "pic_Cerrar";
            this.pic_Cerrar.Size = new System.Drawing.Size(25, 25);
            this.pic_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Cerrar.TabIndex = 0;
            this.pic_Cerrar.TabStop = false;
            this.pic_Cerrar.Click += new System.EventHandler(this.pic_Cerrar_Click);
            // 
            // tx_PrecioServ
            // 
            this.tx_PrecioServ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_PrecioServ.Location = new System.Drawing.Point(239, 392);
            this.tx_PrecioServ.Name = "tx_PrecioServ";
            this.tx_PrecioServ.Size = new System.Drawing.Size(331, 29);
            this.tx_PrecioServ.TabIndex = 35;
            // 
            // pnl_NuevoCl
            // 
            this.pnl_NuevoCl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_NuevoCl.BackColor = System.Drawing.Color.White;
            this.pnl_NuevoCl.Controls.Add(this.tx_PrecioServ);
            this.pnl_NuevoCl.Controls.Add(this.btn_Cancelar);
            this.pnl_NuevoCl.Controls.Add(this.btn_Confirmar);
            this.pnl_NuevoCl.Controls.Add(this.txt_CodigoServ);
            this.pnl_NuevoCl.Controls.Add(this.lbl_Cod);
            this.pnl_NuevoCl.Controls.Add(this.txt_Duracion);
            this.pnl_NuevoCl.Controls.Add(this.txt_CategoriaServ);
            this.pnl_NuevoCl.Controls.Add(this.txt_DescServ);
            this.pnl_NuevoCl.Controls.Add(this.lbl_Descripcion);
            this.pnl_NuevoCl.Controls.Add(this.lbl_CategoriaServ);
            this.pnl_NuevoCl.Controls.Add(this.lbl_Duracion);
            this.pnl_NuevoCl.Controls.Add(this.lbl_PrecioServ);
            this.pnl_NuevoCl.Controls.Add(this.lbl_NomServ);
            this.pnl_NuevoCl.Controls.Add(this.txt_NomServ);
            this.pnl_NuevoCl.Controls.Add(this.lbl_Inf);
            this.pnl_NuevoCl.Controls.Add(this.lbl_Regis);
            this.pnl_NuevoCl.Location = new System.Drawing.Point(246, 55);
            this.pnl_NuevoCl.Name = "pnl_NuevoCl";
            this.pnl_NuevoCl.Size = new System.Drawing.Size(613, 556);
            this.pnl_NuevoCl.TabIndex = 9;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(76)))), ((int)(((byte)(70)))));
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_Cancelar.Location = new System.Drawing.Point(339, 509);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(94, 42);
            this.btn_Cancelar.TabIndex = 34;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Confirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(123)))));
            this.btn_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirmar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirmar.ForeColor = System.Drawing.Color.White;
            this.btn_Confirmar.Location = new System.Drawing.Point(169, 509);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(164, 42);
            this.btn_Confirmar.TabIndex = 4;
            this.btn_Confirmar.Text = "Reistrar Empleado";
            this.btn_Confirmar.UseVisualStyleBackColor = false;
            // 
            // txt_CodigoServ
            // 
            this.txt_CodigoServ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CodigoServ.Location = new System.Drawing.Point(239, 106);
            this.txt_CodigoServ.Name = "txt_CodigoServ";
            this.txt_CodigoServ.Size = new System.Drawing.Size(331, 29);
            this.txt_CodigoServ.TabIndex = 21;
            // 
            // lbl_Cod
            // 
            this.lbl_Cod.AutoSize = true;
            this.lbl_Cod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cod.Location = new System.Drawing.Point(45, 106);
            this.lbl_Cod.Name = "lbl_Cod";
            this.lbl_Cod.Size = new System.Drawing.Size(60, 21);
            this.lbl_Cod.TabIndex = 19;
            this.lbl_Cod.Text = "Código";
            // 
            // txt_Duracion
            // 
            this.txt_Duracion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Duracion.Location = new System.Drawing.Point(239, 357);
            this.txt_Duracion.Name = "txt_Duracion";
            this.txt_Duracion.Size = new System.Drawing.Size(331, 29);
            this.txt_Duracion.TabIndex = 14;
            // 
            // txt_CategoriaServ
            // 
            this.txt_CategoriaServ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CategoriaServ.Location = new System.Drawing.Point(239, 322);
            this.txt_CategoriaServ.Name = "txt_CategoriaServ";
            this.txt_CategoriaServ.Size = new System.Drawing.Size(331, 29);
            this.txt_CategoriaServ.TabIndex = 13;
            // 
            // txt_DescServ
            // 
            this.txt_DescServ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DescServ.Location = new System.Drawing.Point(239, 173);
            this.txt_DescServ.Multiline = true;
            this.txt_DescServ.Name = "txt_DescServ";
            this.txt_DescServ.Size = new System.Drawing.Size(331, 143);
            this.txt_DescServ.TabIndex = 12;
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descripcion.Location = new System.Drawing.Point(45, 176);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(91, 21);
            this.lbl_Descripcion.TabIndex = 11;
            this.lbl_Descripcion.Text = "Descripción";
            // 
            // lbl_CategoriaServ
            // 
            this.lbl_CategoriaServ.AutoSize = true;
            this.lbl_CategoriaServ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CategoriaServ.Location = new System.Drawing.Point(45, 322);
            this.lbl_CategoriaServ.Name = "lbl_CategoriaServ";
            this.lbl_CategoriaServ.Size = new System.Drawing.Size(77, 21);
            this.lbl_CategoriaServ.TabIndex = 10;
            this.lbl_CategoriaServ.Text = "Categoria";
            // 
            // lbl_Duracion
            // 
            this.lbl_Duracion.AutoSize = true;
            this.lbl_Duracion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Duracion.Location = new System.Drawing.Point(45, 357);
            this.lbl_Duracion.Name = "lbl_Duracion";
            this.lbl_Duracion.Size = new System.Drawing.Size(140, 21);
            this.lbl_Duracion.TabIndex = 9;
            this.lbl_Duracion.Text = "Duración Estimada";
            // 
            // lbl_PrecioServ
            // 
            this.lbl_PrecioServ.AutoSize = true;
            this.lbl_PrecioServ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PrecioServ.Location = new System.Drawing.Point(45, 392);
            this.lbl_PrecioServ.Name = "lbl_PrecioServ";
            this.lbl_PrecioServ.Size = new System.Drawing.Size(53, 21);
            this.lbl_PrecioServ.TabIndex = 8;
            this.lbl_PrecioServ.Text = "Precio";
            // 
            // lbl_NomServ
            // 
            this.lbl_NomServ.AutoSize = true;
            this.lbl_NomServ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomServ.Location = new System.Drawing.Point(45, 141);
            this.lbl_NomServ.Name = "lbl_NomServ";
            this.lbl_NomServ.Size = new System.Drawing.Size(68, 21);
            this.lbl_NomServ.TabIndex = 7;
            this.lbl_NomServ.Text = "Nombre";
            // 
            // txt_NomServ
            // 
            this.txt_NomServ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NomServ.Location = new System.Drawing.Point(239, 141);
            this.txt_NomServ.Name = "txt_NomServ";
            this.txt_NomServ.Size = new System.Drawing.Size(331, 29);
            this.txt_NomServ.TabIndex = 6;
            // 
            // lbl_Inf
            // 
            this.lbl_Inf.AutoSize = true;
            this.lbl_Inf.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Inf.Location = new System.Drawing.Point(44, 63);
            this.lbl_Inf.Name = "lbl_Inf";
            this.lbl_Inf.Size = new System.Drawing.Size(236, 30);
            this.lbl_Inf.TabIndex = 4;
            this.lbl_Inf.Text = "Información del Servicio";
            // 
            // lbl_Regis
            // 
            this.lbl_Regis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Regis.AutoSize = true;
            this.lbl_Regis.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Regis.Location = new System.Drawing.Point(179, 7);
            this.lbl_Regis.Name = "lbl_Regis";
            this.lbl_Regis.Size = new System.Drawing.Size(244, 37);
            this.lbl_Regis.TabIndex = 3;
            this.lbl_Regis.Text = "Registrar Servicio";
            // 
            // pic_Redimencionar
            // 
            this.pic_Redimencionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Redimencionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_Redimencionar.Image = global::Funeraria_Descanso_Eterno.Properties.Resources.maxi;
            this.pic_Redimencionar.Location = new System.Drawing.Point(1032, 7);
            this.pic_Redimencionar.Name = "pic_Redimencionar";
            this.pic_Redimencionar.Size = new System.Drawing.Size(25, 25);
            this.pic_Redimencionar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Redimencionar.TabIndex = 1;
            this.pic_Redimencionar.TabStop = false;
            // 
            // pnl_Titulo
            // 
            this.pnl_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(123)))));
            this.pnl_Titulo.Controls.Add(this.pic_Restaurar);
            this.pnl_Titulo.Controls.Add(this.pic_Minimizar);
            this.pnl_Titulo.Controls.Add(this.pic_Redimencionar);
            this.pnl_Titulo.Controls.Add(this.pic_Cerrar);
            this.pnl_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Titulo.Name = "pnl_Titulo";
            this.pnl_Titulo.Size = new System.Drawing.Size(1100, 38);
            this.pnl_Titulo.TabIndex = 8;
            // 
            // frm_NuevoServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 612);
            this.Controls.Add(this.pnl_NuevoCl);
            this.Controls.Add(this.pnl_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_NuevoServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_NuevoServicio";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Cerrar)).EndInit();
            this.pnl_NuevoCl.ResumeLayout(false);
            this.pnl_NuevoCl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Redimencionar)).EndInit();
            this.pnl_Titulo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Restaurar;
        private System.Windows.Forms.PictureBox pic_Minimizar;
        private System.Windows.Forms.PictureBox pic_Cerrar;
        private System.Windows.Forms.TextBox tx_PrecioServ;
        private System.Windows.Forms.Panel pnl_NuevoCl;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.TextBox txt_CodigoServ;
        private System.Windows.Forms.Label lbl_Cod;
        private System.Windows.Forms.TextBox txt_Duracion;
        private System.Windows.Forms.TextBox txt_CategoriaServ;
        private System.Windows.Forms.TextBox txt_DescServ;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.Label lbl_CategoriaServ;
        private System.Windows.Forms.Label lbl_Duracion;
        private System.Windows.Forms.Label lbl_PrecioServ;
        private System.Windows.Forms.Label lbl_NomServ;
        private System.Windows.Forms.TextBox txt_NomServ;
        private System.Windows.Forms.Label lbl_Inf;
        private System.Windows.Forms.Label lbl_Regis;
        private System.Windows.Forms.PictureBox pic_Redimencionar;
        private System.Windows.Forms.Panel pnl_Titulo;
    }
}