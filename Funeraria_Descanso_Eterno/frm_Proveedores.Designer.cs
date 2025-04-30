namespace Funeraria_Descanso_Eterno
{
    partial class frm_Proveedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_BuscarProv = new System.Windows.Forms.Label();
            this.txt_BuscarProv = new System.Windows.Forms.TextBox();
            this.dtg_Proveedores = new System.Windows.Forms.DataGridView();
            this.btn_EliminarProv = new System.Windows.Forms.Button();
            this.btn_ActualizarProv = new System.Windows.Forms.Button();
            this.btn_NuevoProv = new System.Windows.Forms.Button();
            this.pnl_BuscarProv = new System.Windows.Forms.Panel();
            this.Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Proveedores)).BeginInit();
            this.pnl_BuscarProv.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_BuscarProv
            // 
            this.lbl_BuscarProv.AutoSize = true;
            this.lbl_BuscarProv.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BuscarProv.Location = new System.Drawing.Point(17, 29);
            this.lbl_BuscarProv.Name = "lbl_BuscarProv";
            this.lbl_BuscarProv.Size = new System.Drawing.Size(109, 37);
            this.lbl_BuscarProv.TabIndex = 2;
            this.lbl_BuscarProv.Text = "Buscar:";
            // 
            // txt_BuscarProv
            // 
            this.txt_BuscarProv.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BuscarProv.Location = new System.Drawing.Point(132, 29);
            this.txt_BuscarProv.Name = "txt_BuscarProv";
            this.txt_BuscarProv.Size = new System.Drawing.Size(888, 33);
            this.txt_BuscarProv.TabIndex = 0;
            // 
            // dtg_Proveedores
            // 
            this.dtg_Proveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_Proveedores.BackgroundColor = System.Drawing.Color.White;
            this.dtg_Proveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_Proveedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtg_Proveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Proveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_Proveedores.ColumnHeadersHeight = 50;
            this.dtg_Proveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod,
            this.NombreP,
            this.Contacto,
            this.email,
            this.Ciudad});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_Proveedores.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_Proveedores.EnableHeadersVisualStyles = false;
            this.dtg_Proveedores.Location = new System.Drawing.Point(12, 180);
            this.dtg_Proveedores.Name = "dtg_Proveedores";
            this.dtg_Proveedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Proveedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_Proveedores.RowHeadersVisible = false;
            this.dtg_Proveedores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtg_Proveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_Proveedores.Size = new System.Drawing.Size(1076, 420);
            this.dtg_Proveedores.TabIndex = 16;
            // 
            // btn_EliminarProv
            // 
            this.btn_EliminarProv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_EliminarProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(76)))), ((int)(((byte)(70)))));
            this.btn_EliminarProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EliminarProv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EliminarProv.ForeColor = System.Drawing.Color.White;
            this.btn_EliminarProv.Location = new System.Drawing.Point(594, 123);
            this.btn_EliminarProv.Name = "btn_EliminarProv";
            this.btn_EliminarProv.Size = new System.Drawing.Size(254, 42);
            this.btn_EliminarProv.TabIndex = 15;
            this.btn_EliminarProv.Text = "Eliminar Proveedor";
            this.btn_EliminarProv.UseVisualStyleBackColor = false;
            // 
            // btn_ActualizarProv
            // 
            this.btn_ActualizarProv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_ActualizarProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(209)))));
            this.btn_ActualizarProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ActualizarProv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ActualizarProv.ForeColor = System.Drawing.Color.White;
            this.btn_ActualizarProv.Location = new System.Drawing.Point(422, 123);
            this.btn_ActualizarProv.Name = "btn_ActualizarProv";
            this.btn_ActualizarProv.Size = new System.Drawing.Size(166, 42);
            this.btn_ActualizarProv.TabIndex = 14;
            this.btn_ActualizarProv.Text = "Actualizar Proveedor";
            this.btn_ActualizarProv.UseVisualStyleBackColor = false;
            // 
            // btn_NuevoProv
            // 
            this.btn_NuevoProv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_NuevoProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(123)))));
            this.btn_NuevoProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NuevoProv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NuevoProv.ForeColor = System.Drawing.Color.White;
            this.btn_NuevoProv.Location = new System.Drawing.Point(252, 123);
            this.btn_NuevoProv.Name = "btn_NuevoProv";
            this.btn_NuevoProv.Size = new System.Drawing.Size(164, 42);
            this.btn_NuevoProv.TabIndex = 13;
            this.btn_NuevoProv.Text = "+ Nuevo Proveedor";
            this.btn_NuevoProv.UseVisualStyleBackColor = false;
            // 
            // pnl_BuscarProv
            // 
            this.pnl_BuscarProv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_BuscarProv.BackColor = System.Drawing.Color.White;
            this.pnl_BuscarProv.Controls.Add(this.lbl_BuscarProv);
            this.pnl_BuscarProv.Controls.Add(this.txt_BuscarProv);
            this.pnl_BuscarProv.Location = new System.Drawing.Point(25, 12);
            this.pnl_BuscarProv.Name = "pnl_BuscarProv";
            this.pnl_BuscarProv.Size = new System.Drawing.Size(1046, 93);
            this.pnl_BuscarProv.TabIndex = 12;
            // 
            // Cod
            // 
            this.Cod.HeaderText = "Codigo";
            this.Cod.Name = "Cod";
            this.Cod.ReadOnly = true;
            this.Cod.Width = 200;
            // 
            // NombreP
            // 
            this.NombreP.HeaderText = "Razón Social";
            this.NombreP.Name = "NombreP";
            this.NombreP.ReadOnly = true;
            this.NombreP.Width = 200;
            // 
            // Contacto
            // 
            this.Contacto.HeaderText = "Contacto";
            this.Contacto.Name = "Contacto";
            this.Contacto.ReadOnly = true;
            this.Contacto.Width = 200;
            // 
            // email
            // 
            this.email.HeaderText = "Correo Electrónico";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 300;
            // 
            // Ciudad
            // 
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.ReadOnly = true;
            this.Ciudad.Width = 150;
            // 
            // frm_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 612);
            this.Controls.Add(this.dtg_Proveedores);
            this.Controls.Add(this.btn_EliminarProv);
            this.Controls.Add(this.btn_ActualizarProv);
            this.Controls.Add(this.btn_NuevoProv);
            this.Controls.Add(this.pnl_BuscarProv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Proveedores";
            this.Text = "frm_Proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Proveedores)).EndInit();
            this.pnl_BuscarProv.ResumeLayout(false);
            this.pnl_BuscarProv.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_BuscarProv;
        private System.Windows.Forms.TextBox txt_BuscarProv;
        private System.Windows.Forms.DataGridView dtg_Proveedores;
        private System.Windows.Forms.Button btn_EliminarProv;
        private System.Windows.Forms.Button btn_ActualizarProv;
        private System.Windows.Forms.Button btn_NuevoProv;
        private System.Windows.Forms.Panel pnl_BuscarProv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
    }
}