namespace Funeraria_Descanso_Eterno
{
    partial class frm_Facturacion
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
            this.lbl_BuscarF = new System.Windows.Forms.Label();
            this.txt_BuscarF = new System.Windows.Forms.TextBox();
            this.dtg_Factura = new System.Windows.Forms.DataGridView();
            this.btn_EliminarF = new System.Windows.Forms.Button();
            this.btn_ActualizarF = new System.Windows.Forms.Button();
            this.btn_NuevoF = new System.Windows.Forms.Button();
            this.pnl_BuscarF = new System.Windows.Forms.Panel();
            this.CodigoF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sub_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Metodo_Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Imprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Factura)).BeginInit();
            this.pnl_BuscarF.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_BuscarF
            // 
            this.lbl_BuscarF.AutoSize = true;
            this.lbl_BuscarF.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BuscarF.Location = new System.Drawing.Point(17, 29);
            this.lbl_BuscarF.Name = "lbl_BuscarF";
            this.lbl_BuscarF.Size = new System.Drawing.Size(109, 37);
            this.lbl_BuscarF.TabIndex = 2;
            this.lbl_BuscarF.Text = "Buscar:";
            // 
            // txt_BuscarF
            // 
            this.txt_BuscarF.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BuscarF.Location = new System.Drawing.Point(132, 29);
            this.txt_BuscarF.Name = "txt_BuscarF";
            this.txt_BuscarF.Size = new System.Drawing.Size(888, 33);
            this.txt_BuscarF.TabIndex = 0;
            // 
            // dtg_Factura
            // 
            this.dtg_Factura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_Factura.BackgroundColor = System.Drawing.Color.White;
            this.dtg_Factura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_Factura.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtg_Factura.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Factura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_Factura.ColumnHeadersHeight = 50;
            this.dtg_Factura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoF,
            this.Fecha,
            this.ID_Cliente,
            this.Cod_Servicio,
            this.Sub_Total,
            this.IVA,
            this.Total,
            this.Metodo_Pago});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_Factura.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_Factura.EnableHeadersVisualStyles = false;
            this.dtg_Factura.Location = new System.Drawing.Point(12, 180);
            this.dtg_Factura.Name = "dtg_Factura";
            this.dtg_Factura.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Factura.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_Factura.RowHeadersVisible = false;
            this.dtg_Factura.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtg_Factura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_Factura.Size = new System.Drawing.Size(1076, 372);
            this.dtg_Factura.TabIndex = 16;
            // 
            // btn_EliminarF
            // 
            this.btn_EliminarF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_EliminarF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(76)))), ((int)(((byte)(70)))));
            this.btn_EliminarF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EliminarF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EliminarF.ForeColor = System.Drawing.Color.White;
            this.btn_EliminarF.Location = new System.Drawing.Point(594, 123);
            this.btn_EliminarF.Name = "btn_EliminarF";
            this.btn_EliminarF.Size = new System.Drawing.Size(254, 42);
            this.btn_EliminarF.TabIndex = 15;
            this.btn_EliminarF.Text = "Eliminar Pago";
            this.btn_EliminarF.UseVisualStyleBackColor = false;
            // 
            // btn_ActualizarF
            // 
            this.btn_ActualizarF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_ActualizarF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(209)))));
            this.btn_ActualizarF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ActualizarF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ActualizarF.ForeColor = System.Drawing.Color.White;
            this.btn_ActualizarF.Location = new System.Drawing.Point(422, 123);
            this.btn_ActualizarF.Name = "btn_ActualizarF";
            this.btn_ActualizarF.Size = new System.Drawing.Size(166, 42);
            this.btn_ActualizarF.TabIndex = 14;
            this.btn_ActualizarF.Text = "Actualizar Pago";
            this.btn_ActualizarF.UseVisualStyleBackColor = false;
            // 
            // btn_NuevoF
            // 
            this.btn_NuevoF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_NuevoF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(123)))));
            this.btn_NuevoF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NuevoF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NuevoF.ForeColor = System.Drawing.Color.White;
            this.btn_NuevoF.Location = new System.Drawing.Point(252, 123);
            this.btn_NuevoF.Name = "btn_NuevoF";
            this.btn_NuevoF.Size = new System.Drawing.Size(164, 42);
            this.btn_NuevoF.TabIndex = 13;
            this.btn_NuevoF.Text = "+ Nuevo Pago";
            this.btn_NuevoF.UseVisualStyleBackColor = false;
            // 
            // pnl_BuscarF
            // 
            this.pnl_BuscarF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_BuscarF.BackColor = System.Drawing.Color.White;
            this.pnl_BuscarF.Controls.Add(this.lbl_BuscarF);
            this.pnl_BuscarF.Controls.Add(this.txt_BuscarF);
            this.pnl_BuscarF.Location = new System.Drawing.Point(25, 12);
            this.pnl_BuscarF.Name = "pnl_BuscarF";
            this.pnl_BuscarF.Size = new System.Drawing.Size(1046, 93);
            this.pnl_BuscarF.TabIndex = 12;
            // 
            // CodigoF
            // 
            this.CodigoF.HeaderText = "Codigo Factura";
            this.CodigoF.Name = "CodigoF";
            this.CodigoF.ReadOnly = true;
            this.CodigoF.Width = 130;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 130;
            // 
            // ID_Cliente
            // 
            this.ID_Cliente.HeaderText = "Id Cliente";
            this.ID_Cliente.Name = "ID_Cliente";
            this.ID_Cliente.ReadOnly = true;
            this.ID_Cliente.Width = 130;
            // 
            // Cod_Servicio
            // 
            this.Cod_Servicio.HeaderText = "Codigo Servicio";
            this.Cod_Servicio.Name = "Cod_Servicio";
            this.Cod_Servicio.ReadOnly = true;
            this.Cod_Servicio.Width = 130;
            // 
            // Sub_Total
            // 
            this.Sub_Total.HeaderText = "Sub total";
            this.Sub_Total.Name = "Sub_Total";
            this.Sub_Total.ReadOnly = true;
            this.Sub_Total.Width = 130;
            // 
            // IVA
            // 
            this.IVA.HeaderText = "IVA";
            this.IVA.Name = "IVA";
            this.IVA.ReadOnly = true;
            this.IVA.Width = 130;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 130;
            // 
            // Metodo_Pago
            // 
            this.Metodo_Pago.HeaderText = "Metodo de Pago";
            this.Metodo_Pago.Name = "Metodo_Pago";
            this.Metodo_Pago.ReadOnly = true;
            this.Metodo_Pago.Width = 130;
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Imprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(209)))));
            this.btn_Imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Imprimir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Imprimir.ForeColor = System.Drawing.Color.White;
            this.btn_Imprimir.Location = new System.Drawing.Point(467, 558);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(166, 42);
            this.btn_Imprimir.TabIndex = 17;
            this.btn_Imprimir.Text = "Imprimir Factura";
            this.btn_Imprimir.UseVisualStyleBackColor = false;
            // 
            // frm_Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 612);
            this.Controls.Add(this.btn_Imprimir);
            this.Controls.Add(this.dtg_Factura);
            this.Controls.Add(this.btn_EliminarF);
            this.Controls.Add(this.btn_ActualizarF);
            this.Controls.Add(this.btn_NuevoF);
            this.Controls.Add(this.pnl_BuscarF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Facturacion";
            this.Text = "frm_Facturacion";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Factura)).EndInit();
            this.pnl_BuscarF.ResumeLayout(false);
            this.pnl_BuscarF.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_BuscarF;
        private System.Windows.Forms.TextBox txt_BuscarF;
        private System.Windows.Forms.DataGridView dtg_Factura;
        private System.Windows.Forms.Button btn_EliminarF;
        private System.Windows.Forms.Button btn_ActualizarF;
        private System.Windows.Forms.Button btn_NuevoF;
        private System.Windows.Forms.Panel pnl_BuscarF;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sub_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Metodo_Pago;
        private System.Windows.Forms.Button btn_Imprimir;
    }
}