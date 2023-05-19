namespace Urbiautos
{
    partial class NuevoProducto
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
            this.richTextBoxdesc = new System.Windows.Forms.RichTextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbCod = new System.Windows.Forms.TextBox();
            this.numericupdownstock = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbx_pcompra = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbx_pciva = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mtbx_pventa = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mtbx_instalacion = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mtbx_pinstalado = new System.Windows.Forms.MaskedTextBox();
            this.txb_familia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericupdownstock)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxdesc
            // 
            this.richTextBoxdesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxdesc.Location = new System.Drawing.Point(107, 102);
            this.richTextBoxdesc.Name = "richTextBoxdesc";
            this.richTextBoxdesc.Size = new System.Drawing.Size(197, 62);
            this.richTextBoxdesc.TabIndex = 2;
            this.richTextBoxdesc.Tag = "Text";
            this.richTextBoxdesc.Text = "";
            this.richTextBoxdesc.TextChanged += new System.EventHandler(this.richTextBoxdesc_TextChanged);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(587, 159);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 38);
            this.btnIngresar.TabIndex = 9;
            this.btnIngresar.Tag = "Perma";
            this.btnIngresar.Text = "OK";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(19, 102);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(85, 19);
            this.label19.TabIndex = 60;
            this.label19.Text = "Descripcion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 19);
            this.label8.TabIndex = 63;
            this.label8.Text = "Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 64;
            this.label3.Text = "Codigo/ID";
            // 
            // txbCod
            // 
            this.txbCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCod.Font = new System.Drawing.Font("Calibri", 12F);
            this.txbCod.Location = new System.Drawing.Point(107, 36);
            this.txbCod.Name = "txbCod";
            this.txbCod.Size = new System.Drawing.Size(197, 27);
            this.txbCod.TabIndex = 0;
            this.txbCod.Tag = "Text";
            this.txbCod.TextChanged += new System.EventHandler(this.txbCod_TextChanged);
            // 
            // numericupdownstock
            // 
            this.numericupdownstock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericupdownstock.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericupdownstock.Location = new System.Drawing.Point(107, 69);
            this.numericupdownstock.Name = "numericupdownstock";
            this.numericupdownstock.Size = new System.Drawing.Size(120, 27);
            this.numericupdownstock.TabIndex = 1;
            this.numericupdownstock.Tag = "Stock";
            this.numericupdownstock.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 64;
            this.label1.Text = "Precio de Compra";
            // 
            // mtbx_pcompra
            // 
            this.mtbx_pcompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbx_pcompra.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbx_pcompra.Location = new System.Drawing.Point(463, 36);
            this.mtbx_pcompra.Mask = "$9999999999";
            this.mtbx_pcompra.Name = "mtbx_pcompra";
            this.mtbx_pcompra.Size = new System.Drawing.Size(105, 27);
            this.mtbx_pcompra.TabIndex = 4;
            this.mtbx_pcompra.Tag = "Precio";
            this.mtbx_pcompra.ValidatingType = typeof(int);
            this.mtbx_pcompra.TextChanged += new System.EventHandler(this.mtbx_pcompra_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(333, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 64;
            this.label2.Text = "Precio c/IVA";
            // 
            // mtbx_pciva
            // 
            this.mtbx_pciva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbx_pciva.Enabled = false;
            this.mtbx_pciva.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbx_pciva.Location = new System.Drawing.Point(463, 71);
            this.mtbx_pciva.Mask = "$9999999999";
            this.mtbx_pciva.Name = "mtbx_pciva";
            this.mtbx_pciva.Size = new System.Drawing.Size(105, 27);
            this.mtbx_pciva.TabIndex = 5;
            this.mtbx_pciva.Tag = "Precio";
            this.mtbx_pciva.ValidatingType = typeof(int);
            this.mtbx_pciva.TextChanged += new System.EventHandler(this.mtbx_pciva_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(333, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 19);
            this.label6.TabIndex = 64;
            this.label6.Text = "Precio de Venta";
            // 
            // mtbx_pventa
            // 
            this.mtbx_pventa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbx_pventa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbx_pventa.Location = new System.Drawing.Point(463, 104);
            this.mtbx_pventa.Mask = "$9999999999";
            this.mtbx_pventa.Name = "mtbx_pventa";
            this.mtbx_pventa.Size = new System.Drawing.Size(105, 27);
            this.mtbx_pventa.TabIndex = 6;
            this.mtbx_pventa.Tag = "Precio";
            this.mtbx_pventa.ValidatingType = typeof(int);
            this.mtbx_pventa.TextChanged += new System.EventHandler(this.mtbx_pventa_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(333, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 19);
            this.label7.TabIndex = 64;
            this.label7.Text = "Instalacion";
            // 
            // mtbx_instalacion
            // 
            this.mtbx_instalacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbx_instalacion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbx_instalacion.Location = new System.Drawing.Point(463, 137);
            this.mtbx_instalacion.Mask = "$9999999999";
            this.mtbx_instalacion.Name = "mtbx_instalacion";
            this.mtbx_instalacion.Size = new System.Drawing.Size(105, 27);
            this.mtbx_instalacion.TabIndex = 7;
            this.mtbx_instalacion.Tag = "Precio";
            this.mtbx_instalacion.ValidatingType = typeof(int);
            this.mtbx_instalacion.TextChanged += new System.EventHandler(this.mtbx_instalacion_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(333, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 19);
            this.label9.TabIndex = 64;
            this.label9.Text = "Precio Instalado";
            // 
            // mtbx_pinstalado
            // 
            this.mtbx_pinstalado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbx_pinstalado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbx_pinstalado.Location = new System.Drawing.Point(463, 170);
            this.mtbx_pinstalado.Mask = "$9999999999";
            this.mtbx_pinstalado.Name = "mtbx_pinstalado";
            this.mtbx_pinstalado.Size = new System.Drawing.Size(105, 27);
            this.mtbx_pinstalado.TabIndex = 8;
            this.mtbx_pinstalado.Tag = "Precio";
            this.mtbx_pinstalado.ValidatingType = typeof(int);
            // 
            // txb_familia
            // 
            this.txb_familia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_familia.Font = new System.Drawing.Font("Calibri", 12F);
            this.txb_familia.Location = new System.Drawing.Point(107, 167);
            this.txb_familia.Name = "txb_familia";
            this.txb_familia.Size = new System.Drawing.Size(197, 27);
            this.txb_familia.TabIndex = 3;
            this.txb_familia.Tag = "Text";
            this.txb_familia.TextChanged += new System.EventHandler(this.txbCod_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 64;
            this.label4.Text = "Familia";
            // 
            // NuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(674, 211);
            this.Controls.Add(this.mtbx_pinstalado);
            this.Controls.Add(this.mtbx_instalacion);
            this.Controls.Add(this.mtbx_pventa);
            this.Controls.Add(this.mtbx_pciva);
            this.Controls.Add(this.mtbx_pcompra);
            this.Controls.Add(this.numericupdownstock);
            this.Controls.Add(this.richTextBoxdesc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_familia);
            this.Controls.Add(this.txbCod);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(690, 250);
            this.MinimumSize = new System.Drawing.Size(690, 250);
            this.Name = "NuevoProducto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Producto";
            this.Load += new System.EventHandler(this.NuevoProducto_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NuevoProducto_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.numericupdownstock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxdesc;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbCod;
        private System.Windows.Forms.NumericUpDown numericupdownstock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbx_pcompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbx_pciva;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtbx_pventa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtbx_instalacion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mtbx_pinstalado;
        private System.Windows.Forms.TextBox txb_familia;
        private System.Windows.Forms.Label label4;
    }
}