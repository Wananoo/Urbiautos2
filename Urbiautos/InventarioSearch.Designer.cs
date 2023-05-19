namespace Urbiautos
{
    partial class InventarioSearch
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txbsearch = new System.Windows.Forms.TextBox();
            this.listboxinventario = new System.Windows.Forms.ListBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.countdown = new System.Windows.Forms.Timer(this.components);
            this.pbx_loading = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_loading)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Busqueda";
            // 
            // txbsearch
            // 
            this.txbsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbsearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbsearch.Location = new System.Drawing.Point(12, 25);
            this.txbsearch.Name = "txbsearch";
            this.txbsearch.Size = new System.Drawing.Size(182, 27);
            this.txbsearch.TabIndex = 1;
            this.txbsearch.TextChanged += new System.EventHandler(this.txbsearch_TextChanged);
            this.txbsearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbsearch_KeyDown);
            // 
            // listboxinventario
            // 
            this.listboxinventario.FormattingEnabled = true;
            this.listboxinventario.Location = new System.Drawing.Point(13, 59);
            this.listboxinventario.Name = "listboxinventario";
            this.listboxinventario.Size = new System.Drawing.Size(212, 251);
            this.listboxinventario.TabIndex = 2;
            this.listboxinventario.SelectedIndexChanged += new System.EventHandler(this.listboxinventario_SelectedIndexChanged);
            // 
            // btn_OK
            // 
            this.btn_OK.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OK.Location = new System.Drawing.Point(150, 316);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 26);
            this.btn_OK.TabIndex = 3;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.Location = new System.Drawing.Point(17, 316);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(75, 26);
            this.btn_nuevo.TabIndex = 3;
            this.btn_nuevo.Text = "Nuevo...";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // countdown
            // 
            this.countdown.Enabled = true;
            this.countdown.Tick += new System.EventHandler(this.countdown_Tick);
            // 
            // pbx_loading
            // 
            this.pbx_loading.BackColor = System.Drawing.Color.Transparent;
            this.pbx_loading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx_loading.Enabled = false;
            this.pbx_loading.Image = global::Urbiautos.Properties.Resources.loading_loading_forever;
            this.pbx_loading.Location = new System.Drawing.Point(200, 25);
            this.pbx_loading.Name = "pbx_loading";
            this.pbx_loading.Size = new System.Drawing.Size(25, 25);
            this.pbx_loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_loading.TabIndex = 4;
            this.pbx_loading.TabStop = false;
            this.pbx_loading.Visible = false;
            // 
            // InventarioSearch
            // 
            this.AcceptButton = this.btn_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(237, 349);
            this.Controls.Add(this.pbx_loading);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.listboxinventario);
            this.Controls.Add(this.txbsearch);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InventarioSearch";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Explorar Inventario";
            this.Load += new System.EventHandler(this.InventarioSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_loading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbsearch;
        private System.Windows.Forms.ListBox listboxinventario;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Timer countdown;
        private System.Windows.Forms.PictureBox pbx_loading;
    }
}