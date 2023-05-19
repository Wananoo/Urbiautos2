namespace Urbiautos
{
    partial class VentanaMain
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
            this.btnVenta = new System.Windows.Forms.Button();
            this.btnConultar = new System.Windows.Forms.Button();
            this.btnInv = new System.Windows.Forms.Button();
            this.btnIngresarFactura = new System.Windows.Forms.Button();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.btnNotaCredito = new System.Windows.Forms.Button();
            this.bntDevolucion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVenta
            // 
            this.btnVenta.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenta.Location = new System.Drawing.Point(12, 28);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(164, 40);
            this.btnVenta.TabIndex = 0;
            this.btnVenta.Text = "Ingresar Venta";
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // btnConultar
            // 
            this.btnConultar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConultar.Location = new System.Drawing.Point(186, 28);
            this.btnConultar.Name = "btnConultar";
            this.btnConultar.Size = new System.Drawing.Size(188, 40);
            this.btnConultar.TabIndex = 1;
            this.btnConultar.Text = "Consultar Registro";
            this.btnConultar.UseVisualStyleBackColor = true;
            this.btnConultar.Click += new System.EventHandler(this.btnConultar_Click);
            // 
            // btnInv
            // 
            this.btnInv.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInv.Location = new System.Drawing.Point(12, 143);
            this.btnInv.Name = "btnInv";
            this.btnInv.Size = new System.Drawing.Size(164, 40);
            this.btnInv.TabIndex = 4;
            this.btnInv.Text = "Inventario";
            this.btnInv.UseVisualStyleBackColor = true;
            this.btnInv.Click += new System.EventHandler(this.btnInv_Click);
            // 
            // btnIngresarFactura
            // 
            this.btnIngresarFactura.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarFactura.Location = new System.Drawing.Point(186, 85);
            this.btnIngresarFactura.Name = "btnIngresarFactura";
            this.btnIngresarFactura.Size = new System.Drawing.Size(188, 40);
            this.btnIngresarFactura.TabIndex = 3;
            this.btnIngresarFactura.Text = "Ingresar Factura";
            this.btnIngresarFactura.UseVisualStyleBackColor = true;
            this.btnIngresarFactura.Click += new System.EventHandler(this.btnIngresarFactura_Click);
            // 
            // btnIngreso
            // 
            this.btnIngreso.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnIngreso.Location = new System.Drawing.Point(12, 85);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(164, 40);
            this.btnIngreso.TabIndex = 2;
            this.btnIngreso.Text = "Ingreso de Vehiculo";
            this.btnIngreso.UseVisualStyleBackColor = true;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // btnNotaCredito
            // 
            this.btnNotaCredito.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotaCredito.Location = new System.Drawing.Point(186, 143);
            this.btnNotaCredito.Name = "btnNotaCredito";
            this.btnNotaCredito.Size = new System.Drawing.Size(188, 40);
            this.btnNotaCredito.TabIndex = 3;
            this.btnNotaCredito.Text = "Nota de Credito";
            this.btnNotaCredito.UseVisualStyleBackColor = true;
            this.btnNotaCredito.Click += new System.EventHandler(this.btnNotaCredito_Click);
            // 
            // bntDevolucion
            // 
            this.bntDevolucion.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntDevolucion.Location = new System.Drawing.Point(86, 190);
            this.bntDevolucion.Name = "bntDevolucion";
            this.bntDevolucion.Size = new System.Drawing.Size(188, 40);
            this.bntDevolucion.TabIndex = 3;
            this.bntDevolucion.Text = "Devolucion";
            this.bntDevolucion.UseVisualStyleBackColor = true;
            this.bntDevolucion.Click += new System.EventHandler(this.bntDevolucion_Click);
            // 
            // VentanaMain
            // 
            this.AcceptButton = this.btnVenta;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(384, 242);
            this.Controls.Add(this.btnInv);
            this.Controls.Add(this.btnConultar);
            this.Controls.Add(this.bntDevolucion);
            this.Controls.Add(this.btnNotaCredito);
            this.Controls.Add(this.btnIngresarFactura);
            this.Controls.Add(this.btnIngreso);
            this.Controls.Add(this.btnVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 250);
            this.Name = "VentanaMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VentanaMain_FormClosing);
            this.Load += new System.EventHandler(this.VentanaMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Button btnConultar;
        private System.Windows.Forms.Button btnInv;
        private System.Windows.Forms.Button btnIngresarFactura;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.Button btnNotaCredito;
        private System.Windows.Forms.Button bntDevolucion;
    }
}