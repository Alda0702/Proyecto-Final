namespace Funeraria_Descanso_Eterno
{
    partial class frm_Servicios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtg_Servicios = new System.Windows.Forms.DataGridView();
            this.Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_BuscarS = new System.Windows.Forms.Label();
            this.txt_BuscarS = new System.Windows.Forms.TextBox();
            this.btn_EliminarS = new System.Windows.Forms.Button();
            this.btn_ActualizarS = new System.Windows.Forms.Button();
            this.btn_NuevoS = new System.Windows.Forms.Button();
            this.pnl_BuscarS = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Servicios)).BeginInit();
            this.pnl_BuscarS.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_Servicios
            // 
            this.dtg_Servicios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_Servicios.BackgroundColor = System.Drawing.Color.White;
            this.dtg_Servicios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_Servicios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtg_Servicios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Servicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtg_Servicios.ColumnHeadersHeight = 50;
            this.dtg_Servicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod,
            this.NombreP,
            this.Desc,
            this.Categoria,
            this.Precio,
            this.Duracion});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_Servicios.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtg_Servicios.EnableHeadersVisualStyles = false;
            this.dtg_Servicios.Location = new System.Drawing.Point(12, 180);
            this.dtg_Servicios.Name = "dtg_Servicios";
            this.dtg_Servicios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Servicios.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtg_Servicios.RowHeadersVisible = false;
            this.dtg_Servicios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtg_Servicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_Servicios.Size = new System.Drawing.Size(1076, 420);
            this.dtg_Servicios.TabIndex = 16;
            // 
            // Cod
            // 
            this.Cod.HeaderText = "Codigo";
            this.Cod.Name = "Cod";
            this.Cod.ReadOnly = true;
            this.Cod.Width = 150;
            // 
            // NombreP
            // 
            this.NombreP.HeaderText = "Nombre";
            this.NombreP.Name = "NombreP";
            this.NombreP.ReadOnly = true;
            this.NombreP.Width = 180;
            // 
            // Desc
            // 
            this.Desc.HeaderText = "Descripción";
            this.Desc.Name = "Desc";
            this.Desc.ReadOnly = true;
            this.Desc.Width = 180;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 180;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 180;
            // 
            // Duracion
            // 
            this.Duracion.HeaderText = "Duración Estimada";
            this.Duracion.Name = "Duracion";
            this.Duracion.ReadOnly = true;
            this.Duracion.Width = 180;
            // 
            // lbl_BuscarS
            // 
            this.lbl_BuscarS.AutoSize = true;
            this.lbl_BuscarS.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BuscarS.Location = new System.Drawing.Point(17, 29);
            this.lbl_BuscarS.Name = "lbl_BuscarS";
            this.lbl_BuscarS.Size = new System.Drawing.Size(109, 37);
            this.lbl_BuscarS.TabIndex = 2;
            this.lbl_BuscarS.Text = "Buscar:";
            // 
            // txt_BuscarS
            // 
            this.txt_BuscarS.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BuscarS.Location = new System.Drawing.Point(132, 29);
            this.txt_BuscarS.Name = "txt_BuscarS";
            this.txt_BuscarS.Size = new System.Drawing.Size(888, 33);
            this.txt_BuscarS.TabIndex = 0;
            // 
            // btn_EliminarS
            // 
            this.btn_EliminarS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_EliminarS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(76)))), ((int)(((byte)(70)))));
            this.btn_EliminarS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EliminarS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EliminarS.ForeColor = System.Drawing.Color.White;
            this.btn_EliminarS.Location = new System.Drawing.Point(594, 123);
            this.btn_EliminarS.Name = "btn_EliminarS";
            this.btn_EliminarS.Size = new System.Drawing.Size(254, 42);
            this.btn_EliminarS.TabIndex = 15;
            this.btn_EliminarS.Text = "Eliminar Servicio";
            this.btn_EliminarS.UseVisualStyleBackColor = false;
            this.btn_EliminarS.Click += new System.EventHandler(this.btn_EliminarS_Click);
            // 
            // btn_ActualizarS
            // 
            this.btn_ActualizarS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_ActualizarS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(209)))));
            this.btn_ActualizarS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ActualizarS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ActualizarS.ForeColor = System.Drawing.Color.White;
            this.btn_ActualizarS.Location = new System.Drawing.Point(422, 123);
            this.btn_ActualizarS.Name = "btn_ActualizarS";
            this.btn_ActualizarS.Size = new System.Drawing.Size(166, 42);
            this.btn_ActualizarS.TabIndex = 14;
            this.btn_ActualizarS.Text = "Actualizar Servicio";
            this.btn_ActualizarS.UseVisualStyleBackColor = false;
            // 
            // btn_NuevoS
            // 
            this.btn_NuevoS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_NuevoS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(123)))));
            this.btn_NuevoS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NuevoS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NuevoS.ForeColor = System.Drawing.Color.White;
            this.btn_NuevoS.Location = new System.Drawing.Point(252, 123);
            this.btn_NuevoS.Name = "btn_NuevoS";
            this.btn_NuevoS.Size = new System.Drawing.Size(164, 42);
            this.btn_NuevoS.TabIndex = 13;
            this.btn_NuevoS.Text = "+ Nuevo Servicio";
            this.btn_NuevoS.UseVisualStyleBackColor = false;
            this.btn_NuevoS.Click += new System.EventHandler(this.btn_NuevoS_Click);
            // 
            // pnl_BuscarS
            // 
            this.pnl_BuscarS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_BuscarS.BackColor = System.Drawing.Color.White;
            this.pnl_BuscarS.Controls.Add(this.lbl_BuscarS);
            this.pnl_BuscarS.Controls.Add(this.txt_BuscarS);
            this.pnl_BuscarS.Location = new System.Drawing.Point(25, 12);
            this.pnl_BuscarS.Name = "pnl_BuscarS";
            this.pnl_BuscarS.Size = new System.Drawing.Size(1046, 93);
            this.pnl_BuscarS.TabIndex = 12;
            // 
            // frm_Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 612);
            this.Controls.Add(this.dtg_Servicios);
            this.Controls.Add(this.btn_EliminarS);
            this.Controls.Add(this.btn_ActualizarS);
            this.Controls.Add(this.btn_NuevoS);
            this.Controls.Add(this.pnl_BuscarS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Servicios";
            this.Text = "frm_Servicios";
            this.Load += new System.EventHandler(this.frm_Servicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Servicios)).EndInit();
            this.pnl_BuscarS.ResumeLayout(false);
            this.pnl_BuscarS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_Servicios;
        private System.Windows.Forms.Label lbl_BuscarS;
        private System.Windows.Forms.TextBox txt_BuscarS;
        private System.Windows.Forms.Button btn_EliminarS;
        private System.Windows.Forms.Button btn_ActualizarS;
        private System.Windows.Forms.Button btn_NuevoS;
        private System.Windows.Forms.Panel pnl_BuscarS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracion;
    }
}