namespace Funeraria_Descanso_Eterno
{
    partial class frm_Inventario
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
            this.lbl_BuscarI = new System.Windows.Forms.Label();
            this.txt_BuscarI = new System.Windows.Forms.TextBox();
            this.pnl_BuscarI = new System.Windows.Forms.Panel();
            this.btn_EliminarI = new System.Windows.Forms.Button();
            this.btn_ActualizarI = new System.Windows.Forms.Button();
            this.btn_NuevoI = new System.Windows.Forms.Button();
            this.dtg_Inventario = new System.Windows.Forms.DataGridView();
            this.Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_BuscarI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Inventario)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_BuscarI
            // 
            this.lbl_BuscarI.AutoSize = true;
            this.lbl_BuscarI.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BuscarI.Location = new System.Drawing.Point(17, 29);
            this.lbl_BuscarI.Name = "lbl_BuscarI";
            this.lbl_BuscarI.Size = new System.Drawing.Size(109, 37);
            this.lbl_BuscarI.TabIndex = 2;
            this.lbl_BuscarI.Text = "Buscar:";
            // 
            // txt_BuscarI
            // 
            this.txt_BuscarI.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BuscarI.Location = new System.Drawing.Point(132, 29);
            this.txt_BuscarI.Name = "txt_BuscarI";
            this.txt_BuscarI.Size = new System.Drawing.Size(888, 33);
            this.txt_BuscarI.TabIndex = 0;
            // 
            // pnl_BuscarI
            // 
            this.pnl_BuscarI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_BuscarI.BackColor = System.Drawing.Color.White;
            this.pnl_BuscarI.Controls.Add(this.lbl_BuscarI);
            this.pnl_BuscarI.Controls.Add(this.txt_BuscarI);
            this.pnl_BuscarI.Location = new System.Drawing.Point(25, 12);
            this.pnl_BuscarI.Name = "pnl_BuscarI";
            this.pnl_BuscarI.Size = new System.Drawing.Size(1046, 93);
            this.pnl_BuscarI.TabIndex = 3;
            // 
            // btn_EliminarI
            // 
            this.btn_EliminarI.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_EliminarI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(76)))), ((int)(((byte)(70)))));
            this.btn_EliminarI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EliminarI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EliminarI.ForeColor = System.Drawing.Color.White;
            this.btn_EliminarI.Location = new System.Drawing.Point(594, 123);
            this.btn_EliminarI.Name = "btn_EliminarI";
            this.btn_EliminarI.Size = new System.Drawing.Size(254, 42);
            this.btn_EliminarI.TabIndex = 10;
            this.btn_EliminarI.Text = "Eliminar Producto";
            this.btn_EliminarI.UseVisualStyleBackColor = false;
            this.btn_EliminarI.Click += new System.EventHandler(this.btn_EliminarI_Click);
            // 
            // btn_ActualizarI
            // 
            this.btn_ActualizarI.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_ActualizarI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(209)))));
            this.btn_ActualizarI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ActualizarI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ActualizarI.ForeColor = System.Drawing.Color.White;
            this.btn_ActualizarI.Location = new System.Drawing.Point(422, 123);
            this.btn_ActualizarI.Name = "btn_ActualizarI";
            this.btn_ActualizarI.Size = new System.Drawing.Size(166, 42);
            this.btn_ActualizarI.TabIndex = 9;
            this.btn_ActualizarI.Text = "Actualizar Producto";
            this.btn_ActualizarI.UseVisualStyleBackColor = false;
            // 
            // btn_NuevoI
            // 
            this.btn_NuevoI.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_NuevoI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(123)))));
            this.btn_NuevoI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NuevoI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NuevoI.ForeColor = System.Drawing.Color.White;
            this.btn_NuevoI.Location = new System.Drawing.Point(252, 123);
            this.btn_NuevoI.Name = "btn_NuevoI";
            this.btn_NuevoI.Size = new System.Drawing.Size(164, 42);
            this.btn_NuevoI.TabIndex = 8;
            this.btn_NuevoI.Text = "+ Nuevo Producto";
            this.btn_NuevoI.UseVisualStyleBackColor = false;
            this.btn_NuevoI.Click += new System.EventHandler(this.btn_NuevoI_Click);
            // 
            // dtg_Inventario
            // 
            this.dtg_Inventario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_Inventario.BackgroundColor = System.Drawing.Color.White;
            this.dtg_Inventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_Inventario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtg_Inventario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Inventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtg_Inventario.ColumnHeadersHeight = 50;
            this.dtg_Inventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod,
            this.NombreP,
            this.Desc,
            this.Categoria,
            this.Cantidad,
            this.Precio});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_Inventario.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtg_Inventario.EnableHeadersVisualStyles = false;
            this.dtg_Inventario.Location = new System.Drawing.Point(12, 180);
            this.dtg_Inventario.Name = "dtg_Inventario";
            this.dtg_Inventario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Inventario.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtg_Inventario.RowHeadersVisible = false;
            this.dtg_Inventario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtg_Inventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_Inventario.Size = new System.Drawing.Size(1076, 420);
            this.dtg_Inventario.TabIndex = 11;
            // 
            // Cod
            // 
            this.Cod.HeaderText = "Código";
            this.Cod.Name = "Cod";
            this.Cod.ReadOnly = true;
            this.Cod.Width = 150;
            // 
            // NombreP
            // 
            this.NombreP.HeaderText = "Nombre";
            this.NombreP.Name = "NombreP";
            this.NombreP.ReadOnly = true;
            this.NombreP.Width = 150;
            // 
            // Desc
            // 
            this.Desc.HeaderText = "Descripción";
            this.Desc.Name = "Desc";
            this.Desc.ReadOnly = true;
            this.Desc.Width = 300;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 150;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 150;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 150;
            // 
            // frm_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 612);
            this.Controls.Add(this.dtg_Inventario);
            this.Controls.Add(this.btn_EliminarI);
            this.Controls.Add(this.btn_ActualizarI);
            this.Controls.Add(this.btn_NuevoI);
            this.Controls.Add(this.pnl_BuscarI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Inventario";
            this.Text = "frm_Inventario";
            this.pnl_BuscarI.ResumeLayout(false);
            this.pnl_BuscarI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Inventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_BuscarI;
        private System.Windows.Forms.TextBox txt_BuscarI;
        private System.Windows.Forms.Panel pnl_BuscarI;
        private System.Windows.Forms.Button btn_EliminarI;
        private System.Windows.Forms.Button btn_ActualizarI;
        private System.Windows.Forms.Button btn_NuevoI;
        private System.Windows.Forms.DataGridView dtg_Inventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}