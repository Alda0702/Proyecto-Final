namespace Funeraria_Descanso_Eterno
{
    partial class frm_Registro_Cliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Clientes_Registrados = new System.Windows.Forms.Panel();
            this.lbl_Complemento_Cantidad = new System.Windows.Forms.Label();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.pnl_Buscar = new System.Windows.Forms.Panel();
            this.lbl_Buscar = new System.Windows.Forms.Label();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.btn_NuevoC = new System.Windows.Forms.Button();
            this.btn_ActualizarC = new System.Windows.Forms.Button();
            this.btn_EliminarC = new System.Windows.Forms.Button();
            this.dtg_Clientes = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo_Electrónico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Clientes_Registrados.SuspendLayout();
            this.pnl_Buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Clientes_Registrados
            // 
            this.pnl_Clientes_Registrados.BackColor = System.Drawing.Color.White;
            this.pnl_Clientes_Registrados.Controls.Add(this.lbl_Complemento_Cantidad);
            this.pnl_Clientes_Registrados.Controls.Add(this.lbl_Cantidad);
            this.pnl_Clientes_Registrados.Location = new System.Drawing.Point(12, 12);
            this.pnl_Clientes_Registrados.Name = "pnl_Clientes_Registrados";
            this.pnl_Clientes_Registrados.Size = new System.Drawing.Size(308, 93);
            this.pnl_Clientes_Registrados.TabIndex = 0;
            // 
            // lbl_Complemento_Cantidad
            // 
            this.lbl_Complemento_Cantidad.AutoSize = true;
            this.lbl_Complemento_Cantidad.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Complemento_Cantidad.Location = new System.Drawing.Point(136, 9);
            this.lbl_Complemento_Cantidad.Name = "lbl_Complemento_Cantidad";
            this.lbl_Complemento_Cantidad.Size = new System.Drawing.Size(169, 74);
            this.lbl_Complemento_Cantidad.TabIndex = 1;
            this.lbl_Complemento_Cantidad.Text = "Clientes \r\nRegistrados";
            this.lbl_Complemento_Cantidad.Click += new System.EventHandler(this.lbl_Complemento_Cantidad_Click);
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cantidad.Location = new System.Drawing.Point(34, 20);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(43, 50);
            this.lbl_Cantidad.TabIndex = 0;
            this.lbl_Cantidad.Text = "0";
            // 
            // pnl_Buscar
            // 
            this.pnl_Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Buscar.BackColor = System.Drawing.Color.White;
            this.pnl_Buscar.Controls.Add(this.lbl_Buscar);
            this.pnl_Buscar.Controls.Add(this.txt_Buscar);
            this.pnl_Buscar.Location = new System.Drawing.Point(342, 12);
            this.pnl_Buscar.Name = "pnl_Buscar";
            this.pnl_Buscar.Size = new System.Drawing.Size(746, 93);
            this.pnl_Buscar.TabIndex = 1;
            this.pnl_Buscar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Buscar_Paint);
            // 
            // lbl_Buscar
            // 
            this.lbl_Buscar.AutoSize = true;
            this.lbl_Buscar.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Buscar.Location = new System.Drawing.Point(17, 29);
            this.lbl_Buscar.Name = "lbl_Buscar";
            this.lbl_Buscar.Size = new System.Drawing.Size(109, 37);
            this.lbl_Buscar.TabIndex = 2;
            this.lbl_Buscar.Text = "Buscar:";
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Buscar.Location = new System.Drawing.Point(132, 29);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(578, 33);
            this.txt_Buscar.TabIndex = 0;
            // 
            // btn_NuevoC
            // 
            this.btn_NuevoC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_NuevoC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(123)))));
            this.btn_NuevoC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NuevoC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NuevoC.ForeColor = System.Drawing.Color.White;
            this.btn_NuevoC.Location = new System.Drawing.Point(251, 123);
            this.btn_NuevoC.Name = "btn_NuevoC";
            this.btn_NuevoC.Size = new System.Drawing.Size(164, 42);
            this.btn_NuevoC.TabIndex = 2;
            this.btn_NuevoC.Text = "+ Nuevo Cliente";
            this.btn_NuevoC.UseVisualStyleBackColor = false;
            this.btn_NuevoC.Click += new System.EventHandler(this.btn_NuevoC_Click);
            // 
            // btn_ActualizarC
            // 
            this.btn_ActualizarC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_ActualizarC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(209)))));
            this.btn_ActualizarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ActualizarC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ActualizarC.ForeColor = System.Drawing.Color.White;
            this.btn_ActualizarC.Location = new System.Drawing.Point(421, 123);
            this.btn_ActualizarC.Name = "btn_ActualizarC";
            this.btn_ActualizarC.Size = new System.Drawing.Size(166, 42);
            this.btn_ActualizarC.TabIndex = 3;
            this.btn_ActualizarC.Text = "Actualizar Cliente";
            this.btn_ActualizarC.UseVisualStyleBackColor = false;
            // 
            // btn_EliminarC
            // 
            this.btn_EliminarC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_EliminarC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(76)))), ((int)(((byte)(70)))));
            this.btn_EliminarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EliminarC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EliminarC.ForeColor = System.Drawing.Color.White;
            this.btn_EliminarC.Location = new System.Drawing.Point(593, 123);
            this.btn_EliminarC.Name = "btn_EliminarC";
            this.btn_EliminarC.Size = new System.Drawing.Size(254, 42);
            this.btn_EliminarC.TabIndex = 4;
            this.btn_EliminarC.Text = "Eliminar Cliente";
            this.btn_EliminarC.UseVisualStyleBackColor = false;
            this.btn_EliminarC.Click += new System.EventHandler(this.btn_EliminarC_Click);
            // 
            // dtg_Clientes
            // 
            this.dtg_Clientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_Clientes.BackgroundColor = System.Drawing.Color.White;
            this.dtg_Clientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_Clientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtg_Clientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtg_Clientes.ColumnHeadersHeight = 50;
            this.dtg_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.ApellidoP,
            this.ApellidoM,
            this.Celular,
            this.Correo_Electrónico});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_Clientes.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtg_Clientes.EnableHeadersVisualStyles = false;
            this.dtg_Clientes.Location = new System.Drawing.Point(12, 180);
            this.dtg_Clientes.Name = "dtg_Clientes";
            this.dtg_Clientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Clientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtg_Clientes.RowHeadersVisible = false;
            this.dtg_Clientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtg_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_Clientes.Size = new System.Drawing.Size(1076, 420);
            this.dtg_Clientes.TabIndex = 5;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 130;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 180;
            // 
            // ApellidoP
            // 
            this.ApellidoP.HeaderText = "Apellido Paterno";
            this.ApellidoP.Name = "ApellidoP";
            this.ApellidoP.ReadOnly = true;
            this.ApellidoP.Width = 150;
            // 
            // ApellidoM
            // 
            this.ApellidoM.HeaderText = "Apellido Materno";
            this.ApellidoM.Name = "ApellidoM";
            this.ApellidoM.ReadOnly = true;
            this.ApellidoM.Width = 150;
            // 
            // Celular
            // 
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            this.Celular.Width = 150;
            // 
            // Correo_Electrónico
            // 
            this.Correo_Electrónico.HeaderText = "Correo Electrónico";
            this.Correo_Electrónico.Name = "Correo_Electrónico";
            this.Correo_Electrónico.ReadOnly = true;
            this.Correo_Electrónico.Width = 300;
            // 
            // frm_Registro_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 612);
            this.Controls.Add(this.dtg_Clientes);
            this.Controls.Add(this.btn_EliminarC);
            this.Controls.Add(this.btn_ActualizarC);
            this.Controls.Add(this.btn_NuevoC);
            this.Controls.Add(this.pnl_Buscar);
            this.Controls.Add(this.pnl_Clientes_Registrados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Registro_Cliente";
            this.Text = "frm_Registro_Cliente";
            this.pnl_Clientes_Registrados.ResumeLayout(false);
            this.pnl_Clientes_Registrados.PerformLayout();
            this.pnl_Buscar.ResumeLayout(false);
            this.pnl_Buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Clientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Clientes_Registrados;
        private System.Windows.Forms.Panel pnl_Buscar;
        private System.Windows.Forms.Label lbl_Complemento_Cantidad;
        public System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.Label lbl_Buscar;
        private System.Windows.Forms.Button btn_NuevoC;
        private System.Windows.Forms.Button btn_ActualizarC;
        private System.Windows.Forms.Button btn_EliminarC;
        private System.Windows.Forms.DataGridView dtg_Clientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo_Electrónico;
    }
}