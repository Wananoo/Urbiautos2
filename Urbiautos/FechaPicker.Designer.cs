namespace Urbiautos
{
    partial class FechaPicker
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
            this.fechainiciopicker = new System.Windows.Forms.DateTimePicker();
            this.fechafinpicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMes = new System.Windows.Forms.Button();
            this.btnSemana = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAnno = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fechainiciopicker
            // 
            this.fechainiciopicker.Location = new System.Drawing.Point(13, 53);
            this.fechainiciopicker.Margin = new System.Windows.Forms.Padding(4);
            this.fechainiciopicker.Name = "fechainiciopicker";
            this.fechainiciopicker.Size = new System.Drawing.Size(265, 27);
            this.fechainiciopicker.TabIndex = 0;
            this.fechainiciopicker.ValueChanged += new System.EventHandler(this.fechainiciopicker_ValueChanged);
            // 
            // fechafinpicker
            // 
            this.fechafinpicker.CustomFormat = "";
            this.fechafinpicker.Location = new System.Drawing.Point(13, 119);
            this.fechafinpicker.Margin = new System.Windows.Forms.Padding(4);
            this.fechafinpicker.Name = "fechafinpicker";
            this.fechafinpicker.Size = new System.Drawing.Size(265, 27);
            this.fechafinpicker.TabIndex = 1;
            this.fechafinpicker.ValueChanged += new System.EventHandler(this.fechafinpicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione fecha de inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione fecha final";
            // 
            // btnMes
            // 
            this.btnMes.Location = new System.Drawing.Point(118, 240);
            this.btnMes.Name = "btnMes";
            this.btnMes.Size = new System.Drawing.Size(75, 50);
            this.btnMes.TabIndex = 3;
            this.btnMes.Tag = "";
            this.btnMes.Text = "Ultimo Mes";
            this.btnMes.UseVisualStyleBackColor = true;
            this.btnMes.Click += new System.EventHandler(this.btnMes_Click);
            // 
            // btnSemana
            // 
            this.btnSemana.Location = new System.Drawing.Point(12, 240);
            this.btnSemana.Name = "btnSemana";
            this.btnSemana.Size = new System.Drawing.Size(75, 50);
            this.btnSemana.TabIndex = 3;
            this.btnSemana.Tag = "";
            this.btnSemana.Text = "Ultima Semana";
            this.btnSemana.UseVisualStyleBackColor = true;
            this.btnSemana.Click += new System.EventHandler(this.btnSemana_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(12, 165);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 28);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Tag = "";
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAnno
            // 
            this.btnAnno.Location = new System.Drawing.Point(224, 240);
            this.btnAnno.Name = "btnAnno";
            this.btnAnno.Size = new System.Drawing.Size(75, 50);
            this.btnAnno.TabIndex = 3;
            this.btnAnno.Tag = "";
            this.btnAnno.Text = "Ultimo Año";
            this.btnAnno.UseVisualStyleBackColor = true;
            this.btnAnno.Click += new System.EventHandler(this.btnAnno_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "O seleccione una opcion: ";
            // 
            // FechaPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(316, 302);
            this.Controls.Add(this.btnAnno);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnSemana);
            this.Controls.Add(this.btnMes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fechafinpicker);
            this.Controls.Add(this.fechainiciopicker);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FechaPicker";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccione rango de Fechas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FechaPicker_FormClosing);
            this.Load += new System.EventHandler(this.FechaPicker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fechainiciopicker;
        private System.Windows.Forms.DateTimePicker fechafinpicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMes;
        private System.Windows.Forms.Button btnSemana;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAnno;
        private System.Windows.Forms.Label label3;
    }
}