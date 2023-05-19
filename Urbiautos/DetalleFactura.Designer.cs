namespace Urbiautos
{
    partial class DetalleFactura
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbliva = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblNeto = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridViewprods = new System.Windows.Forms.DataGridView();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ruttxb = new System.Windows.Forms.TextBox();
            this.nombretxb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewprods)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(313, 81);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(243, 135);
            this.richTextBox1.TabIndex = 76;
            this.richTextBox1.Tag = "Perma";
            this.richTextBox1.Text = "";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(218, 535);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(76, 23);
            this.lbltotal.TabIndex = 74;
            this.lbltotal.Text = "%total%";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(227, 506);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 23);
            this.label17.TabIndex = 67;
            this.label17.Text = "Total: ";
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // DescProducto
            // 
            this.DescProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DescProducto.HeaderText = "Descripcion";
            this.DescProducto.Name = "DescProducto";
            this.DescProducto.ReadOnly = true;
            // 
            // lbliva
            // 
            this.lbliva.AutoSize = true;
            this.lbliva.Font = new System.Drawing.Font("Calibri", 12F);
            this.lbliva.Location = new System.Drawing.Point(135, 535);
            this.lbliva.Name = "lbliva";
            this.lbliva.Size = new System.Drawing.Size(50, 19);
            this.lbliva.TabIndex = 72;
            this.lbliva.Text = "%iva%";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 12F);
            this.label16.Location = new System.Drawing.Point(147, 506);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 19);
            this.label16.TabIndex = 70;
            this.label16.Text = "IVA: ";
            // 
            // lblNeto
            // 
            this.lblNeto.AutoSize = true;
            this.lblNeto.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblNeto.Location = new System.Drawing.Point(22, 536);
            this.lblNeto.Name = "lblNeto";
            this.lblNeto.Size = new System.Drawing.Size(60, 19);
            this.lblNeto.TabIndex = 69;
            this.lblNeto.Text = "%neto%";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 12F);
            this.label15.Location = new System.Drawing.Point(27, 506);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 19);
            this.label15.TabIndex = 68;
            this.label15.Text = "Neto: ";
            // 
            // dataGridViewprods
            // 
            this.dataGridViewprods.AllowUserToAddRows = false;
            this.dataGridViewprods.AllowUserToDeleteRows = false;
            this.dataGridViewprods.AllowUserToOrderColumns = true;
            this.dataGridViewprods.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewprods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewprods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DescProducto,
            this.Precio});
            this.dataGridViewprods.Location = new System.Drawing.Point(16, 247);
            this.dataGridViewprods.Name = "dataGridViewprods";
            this.dataGridViewprods.ReadOnly = true;
            this.dataGridViewprods.RowHeadersVisible = false;
            this.dataGridViewprods.Size = new System.Drawing.Size(540, 256);
            this.dataGridViewprods.TabIndex = 75;
            this.dataGridViewprods.Tag = "Perma";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(481, 517);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 38);
            this.btnIngresar.TabIndex = 77;
            this.btnIngresar.Tag = "Perma";
            this.btnIngresar.Text = "OK";
            this.btnIngresar.UseVisualStyleBackColor = false;
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fecha.Location = new System.Drawing.Point(208, 9);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(67, 19);
            this.lbl_Fecha.TabIndex = 59;
            this.lbl_Fecha.Text = "%fecha%";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(49, 9);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(79, 19);
            this.lbl_ID.TabIndex = 57;
            this.lbl_ID.Text = "%idventa%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 65;
            this.label2.Text = "Fecha: ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(398, 44);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 19);
            this.label19.TabIndex = 60;
            this.label19.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(93, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 62;
            this.label5.Text = "Proveedor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 19);
            this.label8.TabIndex = 63;
            this.label8.Text = "RUT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 64;
            this.label3.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 19);
            this.label1.TabIndex = 58;
            this.label1.Text = "ID: ";
            // 
            // ruttxb
            // 
            this.ruttxb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ruttxb.Enabled = false;
            this.ruttxb.Font = new System.Drawing.Font("Calibri", 12F);
            this.ruttxb.Location = new System.Drawing.Point(97, 147);
            this.ruttxb.Name = "ruttxb";
            this.ruttxb.Size = new System.Drawing.Size(122, 27);
            this.ruttxb.TabIndex = 66;
            // 
            // nombretxb
            // 
            this.nombretxb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nombretxb.Enabled = false;
            this.nombretxb.Font = new System.Drawing.Font("Calibri", 12F);
            this.nombretxb.Location = new System.Drawing.Point(98, 110);
            this.nombretxb.Name = "nombretxb";
            this.nombretxb.Size = new System.Drawing.Size(122, 27);
            this.nombretxb.TabIndex = 66;
            // 
            // DetalleFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(571, 583);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lbliva);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblNeto);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dataGridViewprods);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lbl_Fecha);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombretxb);
            this.Controls.Add(this.ruttxb);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(587, 622);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(587, 622);
            this.Name = "DetalleFactura";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.Text = "Detalle de Factura";
            this.Load += new System.EventHandler(this.DetalleFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewprods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescProducto;
        private System.Windows.Forms.Label lbliva;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblNeto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridViewprods;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ruttxb;
        private System.Windows.Forms.TextBox nombretxb;
    }
}