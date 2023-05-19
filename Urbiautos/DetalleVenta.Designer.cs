namespace Urbiautos
{
    partial class DetalleVenta
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
            this.PatentemaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbliva = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblNeto = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridViewprods = new System.Windows.Forms.DataGridView();
            this.DescProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ruttxb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbldescuento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewprods)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(317, 90);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(243, 135);
            this.richTextBox1.TabIndex = 54;
            this.richTextBox1.Tag = "Perma";
            this.richTextBox1.Text = "";
            // 
            // PatentemaskedTextBox
            // 
            this.PatentemaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PatentemaskedTextBox.Enabled = false;
            this.PatentemaskedTextBox.Font = new System.Drawing.Font("Calibri", 12F);
            this.PatentemaskedTextBox.Location = new System.Drawing.Point(101, 86);
            this.PatentemaskedTextBox.Mask = ">AA-AA-AA";
            this.PatentemaskedTextBox.Name = "PatentemaskedTextBox";
            this.PatentemaskedTextBox.Size = new System.Drawing.Size(121, 27);
            this.PatentemaskedTextBox.TabIndex = 16;
            this.PatentemaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(222, 544);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(76, 23);
            this.lbltotal.TabIndex = 47;
            this.lbltotal.Text = "%total%";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(231, 515);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 23);
            this.label17.TabIndex = 41;
            this.label17.Text = "Total: ";
            // 
            // lbliva
            // 
            this.lbliva.AutoSize = true;
            this.lbliva.Font = new System.Drawing.Font("Calibri", 12F);
            this.lbliva.Location = new System.Drawing.Point(139, 544);
            this.lbliva.Name = "lbliva";
            this.lbliva.Size = new System.Drawing.Size(50, 19);
            this.lbliva.TabIndex = 46;
            this.lbliva.Text = "%iva%";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 12F);
            this.label16.Location = new System.Drawing.Point(151, 515);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 19);
            this.label16.TabIndex = 45;
            this.label16.Text = "IVA: ";
            // 
            // lblNeto
            // 
            this.lblNeto.AutoSize = true;
            this.lblNeto.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblNeto.Location = new System.Drawing.Point(26, 545);
            this.lblNeto.Name = "lblNeto";
            this.lblNeto.Size = new System.Drawing.Size(60, 19);
            this.lblNeto.TabIndex = 44;
            this.lblNeto.Text = "%neto%";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 12F);
            this.label15.Location = new System.Drawing.Point(31, 515);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 19);
            this.label15.TabIndex = 43;
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
            this.dataGridViewprods.Location = new System.Drawing.Point(20, 256);
            this.dataGridViewprods.Name = "dataGridViewprods";
            this.dataGridViewprods.ReadOnly = true;
            this.dataGridViewprods.RowHeadersVisible = false;
            this.dataGridViewprods.Size = new System.Drawing.Size(540, 256);
            this.dataGridViewprods.TabIndex = 52;
            this.dataGridViewprods.Tag = "Perma";
            // 
            // DescProducto
            // 
            this.DescProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DescProducto.HeaderText = "Descripcion";
            this.DescProducto.Name = "DescProducto";
            this.DescProducto.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(485, 526);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 38);
            this.btnIngresar.TabIndex = 55;
            this.btnIngresar.Tag = "Perma";
            this.btnIngresar.Text = "OK";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fecha.Location = new System.Drawing.Point(212, 18);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(67, 19);
            this.lbl_Fecha.TabIndex = 19;
            this.lbl_Fecha.Text = "%fecha%";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(53, 18);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(79, 19);
            this.lbl_ID.TabIndex = 17;
            this.lbl_ID.Text = "%idventa%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "Fecha: ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(402, 53);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 19);
            this.label19.TabIndex = 22;
            this.label19.Text = "Descripcion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(92, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 19);
            this.label7.TabIndex = 24;
            this.label7.Text = "Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(97, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "Vehiculo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 19);
            this.label8.TabIndex = 32;
            this.label8.Text = "RUT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 33;
            this.label3.Text = "Patente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID: ";
            // 
            // ruttxb
            // 
            this.ruttxb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ruttxb.Enabled = false;
            this.ruttxb.Font = new System.Drawing.Font("Calibri", 12F);
            this.ruttxb.Location = new System.Drawing.Point(101, 192);
            this.ruttxb.Name = "ruttxb";
            this.ruttxb.Size = new System.Drawing.Size(122, 27);
            this.ruttxb.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F);
            this.label4.Location = new System.Drawing.Point(325, 518);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 45;
            this.label4.Text = "Descuento:";
            // 
            // lbldescuento
            // 
            this.lbldescuento.AutoSize = true;
            this.lbldescuento.Font = new System.Drawing.Font("Calibri", 12F);
            this.lbldescuento.Location = new System.Drawing.Point(332, 546);
            this.lbldescuento.Name = "lbldescuento";
            this.lbldescuento.Size = new System.Drawing.Size(66, 19);
            this.lbldescuento.TabIndex = 46;
            this.lbldescuento.Text = "%dscto%";
            // 
            // DetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(571, 583);
            this.ControlBox = false;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.PatentemaskedTextBox);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lbldescuento);
            this.Controls.Add(this.label4);
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
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ruttxb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(587, 622);
            this.MinimumSize = new System.Drawing.Size(587, 622);
            this.Name = "DetalleVenta";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetalleVenta";
            this.Load += new System.EventHandler(this.DetalleVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewprods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MaskedTextBox PatentemaskedTextBox;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label label17;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ruttxb;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbldescuento;
    }
}