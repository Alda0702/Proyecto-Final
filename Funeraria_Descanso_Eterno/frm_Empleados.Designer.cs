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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_BuscarE = new System.Windows.Forms.Label();
            this.txt_BuscarE = new System.Windows.Forms.TextBox();
            this.pnl_BuscarE = new System.Windows.Forms.Panel();
            this.btn_EliminarE = new System.Windows.Forms.Button();
            this.btn_ActualizarE = new System.Windows.Forms.Button();
            this.btn_NuevoE = new System.Windows.Forms.Button();
            this.dtg_Empleados = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tdoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CedulaEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_BuscarE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_BuscarE
            // 
            this.lbl_BuscarE.AutoSize = true;
            this.lbl_BuscarE.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BuscarE.Location = new System.Drawing.Point(23, 36);
            this.lbl_BuscarE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_BuscarE.Name = "lbl_BuscarE";
            this.lbl_BuscarE.Size = new System.Drawing.Size(136, 46);
            this.lbl_BuscarE.TabIndex = 2;
            this.lbl_BuscarE.Text = "Buscar:";
            // 
            // txt_BuscarE
            // 
            this.txt_BuscarE.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BuscarE.Location = new System.Drawing.Point(176, 36);
            this.txt_BuscarE.Margin = new System.Windows.Forms.Padding(4);
            this.txt_BuscarE.Name = "txt_BuscarE";
            this.txt_BuscarE.Size = new System.Drawing.Size(1183, 39);
            this.txt_BuscarE.TabIndex = 0;
            this.txt_BuscarE.TextChanged += new System.EventHandler(this.txt_BuscarE_TextChanged);
            // 
            // pnl_BuscarE
            // 
            this.pnl_BuscarE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_BuscarE.BackColor = System.Drawing.Color.White;
            this.pnl_BuscarE.Controls.Add(this.lbl_BuscarE);
            this.pnl_BuscarE.Controls.Add(this.txt_BuscarE);
            this.pnl_BuscarE.Location = new System.Drawing.Point(35, 15);
            this.pnl_BuscarE.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_BuscarE.Name = "pnl_BuscarE";
            this.pnl_BuscarE.Size = new System.Drawing.Size(1395, 114);
            this.pnl_BuscarE.TabIndex = 2;
            // 
            // btn_EliminarE
            // 
            this.btn_EliminarE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_EliminarE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(76)))), ((int)(((byte)(70)))));
            this.btn_EliminarE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EliminarE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EliminarE.ForeColor = System.Drawing.Color.White;
            this.btn_EliminarE.Location = new System.Drawing.Point(792, 149);
            this.btn_EliminarE.Margin = new System.Windows.Forms.Padding(4);
            this.btn_EliminarE.Name = "btn_EliminarE";
            this.btn_EliminarE.Size = new System.Drawing.Size(339, 52);
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
            this.btn_ActualizarE.Location = new System.Drawing.Point(563, 149);
            this.btn_ActualizarE.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ActualizarE.Name = "btn_ActualizarE";
            this.btn_ActualizarE.Size = new System.Drawing.Size(221, 52);
            this.btn_ActualizarE.TabIndex = 6;
            this.btn_ActualizarE.Text = "Actualizar Empleado";
            this.btn_ActualizarE.UseVisualStyleBackColor = false;
            this.btn_ActualizarE.Click += new System.EventHandler(this.btn_ActualizarE_Click);
            // 
            // btn_NuevoE
            // 
            this.btn_NuevoE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_NuevoE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(123)))));
            this.btn_NuevoE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NuevoE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NuevoE.ForeColor = System.Drawing.Color.White;
            this.btn_NuevoE.Location = new System.Drawing.Point(336, 149);
            this.btn_NuevoE.Margin = new System.Windows.Forms.Padding(4);
            this.btn_NuevoE.Name = "btn_NuevoE";
            this.btn_NuevoE.Size = new System.Drawing.Size(219, 52);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Empleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_Empleados.ColumnHeadersHeight = 50;
            this.dtg_Empleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Tdoc,
            this.CedulaEmpleado,
            this.Nombre,
            this.ApellidoP,
            this.ApellidoM,
            this.Nacimiento,
            this.Sexo,
            this.Rol,
            this.Departamento,
            this.Ciudad,
            this.Direccion,
            this.Celular,
            this.Email});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_Empleados.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_Empleados.EnableHeadersVisualStyles = false;
            this.dtg_Empleados.Location = new System.Drawing.Point(16, 222);
            this.dtg_Empleados.Margin = new System.Windows.Forms.Padding(4);
            this.dtg_Empleados.Name = "dtg_Empleados";
            this.dtg_Empleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Empleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_Empleados.RowHeadersVisible = false;
            this.dtg_Empleados.RowHeadersWidth = 51;
            this.dtg_Empleados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtg_Empleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_Empleados.Size = new System.Drawing.Size(1435, 517);
            this.dtg_Empleados.TabIndex = 8;
            this.dtg_Empleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Empleados_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 150;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 150;
            // 
            // Tdoc
            // 
            this.Tdoc.HeaderText = "Tdoc";
            this.Tdoc.MinimumWidth = 6;
            this.Tdoc.Name = "Tdoc";
            this.Tdoc.ReadOnly = true;
            this.Tdoc.Width = 125;
            // 
            // CedulaEmpleado
            // 
            this.CedulaEmpleado.HeaderText = "CedulaEmpleado";
            this.CedulaEmpleado.MinimumWidth = 6;
            this.CedulaEmpleado.Name = "CedulaEmpleado";
            this.CedulaEmpleado.ReadOnly = true;
            this.CedulaEmpleado.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 230;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 230;
            // 
            // ApellidoP
            // 
            this.ApellidoP.HeaderText = "ApellidoP";
            this.ApellidoP.MinimumWidth = 6;
            this.ApellidoP.Name = "ApellidoP";
            this.ApellidoP.ReadOnly = true;
            this.ApellidoP.Width = 125;
            // 
            // ApellidoM
            // 
            this.ApellidoM.HeaderText = "ApellidoM";
            this.ApellidoM.MinimumWidth = 6;
            this.ApellidoM.Name = "ApellidoM";
            this.ApellidoM.ReadOnly = true;
            this.ApellidoM.Width = 125;
            // 
            // Nacimiento
            // 
            this.Nacimiento.HeaderText = "Nacimiento";
            this.Nacimiento.MinimumWidth = 6;
            this.Nacimiento.Name = "Nacimiento";
            this.Nacimiento.ReadOnly = true;
            this.Nacimiento.Width = 125;
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.MinimumWidth = 6;
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            this.Sexo.Width = 125;
            // 
            // Rol
            // 
            this.Rol.HeaderText = "Rol";
            this.Rol.MinimumWidth = 6;
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
            this.Rol.Width = 125;
            // 
            // Departamento
            // 
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.MinimumWidth = 6;
            this.Departamento.Name = "Departamento";
            this.Departamento.ReadOnly = true;
            this.Departamento.Width = 125;
            // 
            // Ciudad
            // 
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.MinimumWidth = 6;
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.ReadOnly = true;
            this.Ciudad.Width = 125;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 125;
            // 
            // Celular
            // 
            this.Celular.HeaderText = "Celular";
            this.Celular.MinimumWidth = 150;
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            this.Celular.Width = 150;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 125;
            // 
            // frm_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 753);
            this.Controls.Add(this.dtg_Empleados);
            this.Controls.Add(this.btn_EliminarE);
            this.Controls.Add(this.btn_ActualizarE);
            this.Controls.Add(this.btn_NuevoE);
            this.Controls.Add(this.pnl_BuscarE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Empleados";
            this.Text = "frm_Empleados";
            this.Load += new System.EventHandler(this.frm_Empleados_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Tdoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn CedulaEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}