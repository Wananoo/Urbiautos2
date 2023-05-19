namespace Urbiautos
{
    partial class BusquedaPatente
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
            this.patentelbl = new System.Windows.Forms.Label();
            this.PatentemaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnRegistros = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ruttxb = new System.Windows.Forms.TextBox();
            this.btnbuscarRut = new System.Windows.Forms.Button();
            this.btnbuscarrangofecha = new System.Windows.Forms.Button();
            this.btnFacturas = new System.Windows.Forms.Button();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.btnNotas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // patentelbl
            // 
            this.patentelbl.AutoSize = true;
            this.patentelbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patentelbl.Location = new System.Drawing.Point(12, 21);
            this.patentelbl.Name = "patentelbl";
            this.patentelbl.Size = new System.Drawing.Size(111, 19);
            this.patentelbl.TabIndex = 0;
            this.patentelbl.Text = "Ingrese Patente";
            this.patentelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PatentemaskedTextBox
            // 
            this.PatentemaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PatentemaskedTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatentemaskedTextBox.Location = new System.Drawing.Point(129, 19);
            this.PatentemaskedTextBox.Mask = ">AA-AA-AA";
            this.PatentemaskedTextBox.Name = "PatentemaskedTextBox";
            this.PatentemaskedTextBox.Size = new System.Drawing.Size(92, 27);
            this.PatentemaskedTextBox.TabIndex = 0;
            this.PatentemaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PatentemaskedTextBox.TextChanged += new System.EventHandler(this.PatentemaskedTextBox_TextChanged);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(227, 19);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(149, 27);
            this.btnIngresar.TabIndex = 1;
            this.btnIngresar.Text = "Buscar por Patente";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnRegistros
            // 
            this.btnRegistros.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnRegistros.Location = new System.Drawing.Point(220, 116);
            this.btnRegistros.Name = "btnRegistros";
            this.btnRegistros.Size = new System.Drawing.Size(178, 33);
            this.btnRegistros.TabIndex = 2;
            this.btnRegistros.Text = "Todos los Registros";
            this.btnRegistros.UseVisualStyleBackColor = true;
            this.btnRegistros.Click += new System.EventHandler(this.btnRegistros_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese RUT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ruttxb
            // 
            this.ruttxb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ruttxb.Font = new System.Drawing.Font("Calibri", 12F);
            this.ruttxb.Location = new System.Drawing.Point(129, 62);
            this.ruttxb.Name = "ruttxb";
            this.ruttxb.Size = new System.Drawing.Size(93, 27);
            this.ruttxb.TabIndex = 5;
            this.ruttxb.TextChanged += new System.EventHandler(this.ruttxb_TextChanged);
            // 
            // btnbuscarRut
            // 
            this.btnbuscarRut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarRut.Location = new System.Drawing.Point(227, 62);
            this.btnbuscarRut.Name = "btnbuscarRut";
            this.btnbuscarRut.Size = new System.Drawing.Size(149, 27);
            this.btnbuscarRut.TabIndex = 1;
            this.btnbuscarRut.Text = "Buscar por RUT";
            this.btnbuscarRut.UseVisualStyleBackColor = true;
            this.btnbuscarRut.Click += new System.EventHandler(this.btnbuscarRut_Click);
            // 
            // btnbuscarrangofecha
            // 
            this.btnbuscarrangofecha.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnbuscarrangofecha.Location = new System.Drawing.Point(12, 116);
            this.btnbuscarrangofecha.Name = "btnbuscarrangofecha";
            this.btnbuscarrangofecha.Size = new System.Drawing.Size(178, 33);
            this.btnbuscarrangofecha.TabIndex = 2;
            this.btnbuscarrangofecha.Text = "Buscar por rango de fecha";
            this.btnbuscarrangofecha.UseVisualStyleBackColor = true;
            this.btnbuscarrangofecha.Click += new System.EventHandler(this.btnbuscarrangofecha_Click);
            // 
            // btnFacturas
            // 
            this.btnFacturas.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnFacturas.Location = new System.Drawing.Point(12, 166);
            this.btnFacturas.Name = "btnFacturas";
            this.btnFacturas.Size = new System.Drawing.Size(178, 33);
            this.btnFacturas.TabIndex = 2;
            this.btnFacturas.Text = "Facturas";
            this.btnFacturas.UseVisualStyleBackColor = true;
            this.btnFacturas.Click += new System.EventHandler(this.btnFacturas_Click);
            // 
            // btnIngreso
            // 
            this.btnIngreso.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnIngreso.Location = new System.Drawing.Point(220, 166);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(178, 33);
            this.btnIngreso.TabIndex = 2;
            this.btnIngreso.Text = "Ingreso de Vehiculos";
            this.btnIngreso.UseVisualStyleBackColor = true;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // btnNotas
            // 
            this.btnNotas.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnNotas.Location = new System.Drawing.Point(116, 216);
            this.btnNotas.Name = "btnNotas";
            this.btnNotas.Size = new System.Drawing.Size(178, 33);
            this.btnNotas.TabIndex = 6;
            this.btnNotas.Text = "Notas de Credito";
            this.btnNotas.UseVisualStyleBackColor = true;
            this.btnNotas.Click += new System.EventHandler(this.btnNotas_Click);
            // 
            // BusquedaPatente
            // 
            this.AcceptButton = this.btnIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(410, 261);
            this.Controls.Add(this.btnNotas);
            this.Controls.Add(this.ruttxb);
            this.Controls.Add(this.btnFacturas);
            this.Controls.Add(this.btnbuscarrangofecha);
            this.Controls.Add(this.btnIngreso);
            this.Controls.Add(this.btnRegistros);
            this.Controls.Add(this.btnbuscarRut);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.PatentemaskedTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patentelbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(426, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(426, 300);
            this.Name = "BusquedaPatente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BusquedaPatente_FormClosing);
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label patentelbl;
        private System.Windows.Forms.MaskedTextBox PatentemaskedTextBox;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnRegistros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ruttxb;
        private System.Windows.Forms.Button btnbuscarRut;
        private System.Windows.Forms.Button btnbuscarrangofecha;
        private System.Windows.Forms.Button btnFacturas;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.Button btnNotas;
    }
}