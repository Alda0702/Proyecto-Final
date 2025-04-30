namespace Funeraria_Descanso_Eterno
{
    partial class frm_Empleados
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
            this.lbl_BuscarE = new System.Windows.Forms.Label();
            this.txt_BuscarE = new System.Windows.Forms.TextBox();
            this.pnl_BuscarE = new System.Windows.Forms.Panel();
            this.btn_EliminarE = new System.Windows.Forms.Button();
            this.btn_ActualizarE = new System.Windows.Forms.Button();
            this.btn_NuevoE = new System.Windows.Forms.Button();
            this.dtg_Empleados = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo_Electrónico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_BuscarE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_BuscarE
            // 
            this.lbl_BuscarE.AutoSize = true;
            this.lbl_BuscarE.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BuscarE.Location = new System.Drawing.Point(17, 29);
            this.lbl_BuscarE.Name = "lbl_BuscarE";
            this.lbl_BuscarE.Size = new System.Drawing.Size(109, 37);
            this.lbl_BuscarE.TabIndex = 2;
            this.lbl_BuscarE.Text = "Buscar:";
            // 
            // txt_BuscarE
            // 
            this.txt_BuscarE.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BuscarE.Location = new System.Drawing.Point(132, 29);
            this.txt_BuscarE.Name = "txt_BuscarE";
            this.txt_BuscarE.Size = new System.Drawing.Size(888, 33);
            this.txt_BuscarE.TabIndex = 0;
            // 
            // pnl_BuscarE
            // 
            this.pnl_BuscarE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_BuscarE.BackColor = System.Drawing.Color.White;
            this.pnl_BuscarE.Controls.Add(this.lbl_BuscarE);
            this.pnl_BuscarE.Controls.Add(this.txt_BuscarE);
            this.pnl_BuscarE.Location = new System.Drawing.Point(26, 12);
            this.pnl_BuscarE.Name = "pnl_BuscarE";
            this.pnl_BuscarE.Size = new System.Drawing.Size(1046, 93);
            this.pnl_BuscarE.TabIndex = 2;
            // 
            // btn_EliminarE
            // 
            this.btn_EliminarE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_EliminarE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(76)))), ((int)(((byte)(70)))));
            this.btn_EliminarE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EliminarE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EliminarE.ForeColor = System.Drawing.Color.White;
            this.btn_EliminarE.Location = new System.Drawing.Point(594, 121);
            this.btn_EliminarE.Name = "btn_EliminarE";
            this.btn_EliminarE.Size = new System.Drawing.Size(254, 42);
            this.btn_EliminarE.TabIndex = 7;
            this.btn_EliminarE.Text = "Eliminar Empleado";
            this.btn_EliminarE.UseVisualStyleBackColor = false;
            this.btn_EliminarE.Click += new System.EventHandler(this.btn_EliminarE_Click);
            // 
            // btn_ActualizarE
            // 
            this.btn_ActualizarE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_ActualizarE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(209)))));
            this.btn_ActualizarE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ActualizarE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ActualizarE.ForeColor = System.Drawing.Color.White;
            this.btn_ActualizarE.Location = new System.Drawing.Point(422, 121);
            this.btn_ActualizarE.Name = "btn_ActualizarE";
            this.btn_ActualizarE.Size = new System.Drawing.Size(166, 42);
            this.btn_ActualizarE.TabIndex = 6;
            this.btn_ActualizarE.Text = "Actualizar Empleado";
            this.btn_ActualizarE.UseVisualStyleBackColor = false;
            // 
            // btn_NuevoE
            // 
            this.btn_NuevoE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_NuevoE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(123)))));
            this.btn_NuevoE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NuevoE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NuevoE.ForeColor = System.Drawing.Color.White;
            this.btn_NuevoE.Location = new System.Drawing.Point(252, 121);
            this.btn_NuevoE.Name = "btn_NuevoE";
            this.btn_NuevoE.Size = new System.Drawing.Size(164, 42);
            this.btn_NuevoE.TabIndex = 5;
            this.btn_NuevoE.Text = "+ Nuevo Empleado";
            this.btn_NuevoE.UseVisualStyleBackColor = false;
            this.btn_NuevoE.Click += new System.EventHandler(this.btn_NuevoE_Click);
            // 
            // dtg_Empleados
            // 
            this.dtg_Empleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_Empleados.BackgroundColor = System.Drawing.Color.White;
            this.dtg_Empleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_Empleados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtg_Empleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Empleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtg_Empleados.ColumnHeadersHeight = 50;
            this.dtg_Empleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Apellido,
            this.Celular,
            this.Correo_Electrónico});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_Empleados.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtg_Empleados.EnableHeadersVisualStyles = false;
            this.dtg_Empleados.Location = new System.Drawing.Point(12, 180);
            this.dtg_Empleados.Name = "dtg_Empleados";
            this.dtg_Empleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Empleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtg_Empleados.RowHeadersVisible = false;
            this.dtg_Empleados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtg_Empleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_Empleados.Size = new System.Drawing.Size(1076, 420);
            this.dtg_Empleados.TabIndex = 8;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 150;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 230;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 230;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 230;
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 230;
            // 
            // Celular
            // 
            this.Celular.HeaderText = "Celular";
            this.Celular.MinimumWidth = 150;
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            this.Celular.Width = 150;
            // 
            // Correo_Electrónico
            // 
            this.Correo_Electrónico.HeaderText = "Correo Electrónico";
            this.Correo_Electrónico.MinimumWidth = 300;
            this.Correo_Electrónico.Name = "Correo_Electrónico";
            this.Correo_Electrónico.ReadOnly = true;
            this.Correo_Electrónico.Width = 300;
            // 
            // frm_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 612);
            this.Controls.Add(this.dtg_Empleados);
            this.Controls.Add(this.btn_EliminarE);
            this.Controls.Add(this.btn_ActualizarE);
            this.Controls.Add(this.btn_NuevoE);
            this.Controls.Add(this.pnl_BuscarE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Empleados";
            this.Text = "frm_Empleados";
            this.pnl_BuscarE.ResumeLayout(false);
            this.pnl_BuscarE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Empleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_BuscarE;
        private System.Windows.Forms.TextBox txt_BuscarE;
        private System.Windows.Forms.Panel pnl_BuscarE;
        private System.Windows.Forms.Button btn_EliminarE;
        private System.Windows.Forms.Button btn_ActualizarE;
        private System.Windows.Forms.Button btn_NuevoE;
        private System.Windows.Forms.DataGridView dtg_Empleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo_Electrónico;
    }
}