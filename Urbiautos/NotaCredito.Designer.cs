namespace Urbiautos
{
    partial class NotaCredito
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.TextBox();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.facturasCbx = new System.Windows.Forms.ComboBox();
            this.btn_ExplorarItems = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cbx_prod = new System.Windows.Forms.ComboBox();
            this.cantidadnumericupdown = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.detallestxb = new System.Windows.Forms.RichTextBox();
            this.dataGridViewprods = new System.Windows.Forms.DataGridView();
            this.IDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblNeto = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fechatxb = new System.Windows.Forms.TextBox();
            this.nfptxb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadnumericupdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewprods)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID: ";
            // 
            // lbl_ID
            // 
            this.lbl_ID.Location = new System.Drawing.Point(43, 17);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(34, 27);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.TextChanged += new System.EventHandler(this.lbl_ID_TextChanged);
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Location = new System.Drawing.Point(147, 20);
            this.lbl_Fecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(67, 19);
            this.lbl_Fecha.TabIndex = 2;
            this.lbl_Fecha.Text = "%fecha%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Factura: ";
            // 
            // facturasCbx
            // 
            this.facturasCbx.FormattingEnabled = true;
            this.facturasCbx.Location = new System.Drawing.Point(86, 106);
            this.facturasCbx.Name = "facturasCbx";
            this.facturasCbx.Size = new System.Drawing.Size(188, 27);
            this.facturasCbx.TabIndex = 1;
            this.facturasCbx.SelectedIndexChanged += new System.EventHandler(this.facturasCbx_SelectedIndexChanged);
            // 
            // btn_ExplorarItems
            // 
            this.btn_ExplorarItems.BackColor = System.Drawing.SystemColors.Control;
            this.btn_ExplorarItems.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExplorarItems.Location = new System.Drawing.Point(494, 107);
            this.btn_ExplorarItems.Name = "btn_ExplorarItems";
            this.btn_ExplorarItems.Size = new System.Drawing.Size(36, 23);
            this.btn_ExplorarItems.TabIndex = 3;
            this.btn_ExplorarItems.Text = "...";
            this.btn_ExplorarItems.UseVisualStyleBackColor = false;
            this.btn_ExplorarItems.Click += new System.EventHandler(this.btn_ExplorarItems_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(412, 149);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Tag = "Perma";
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cbx_prod
            // 
            this.cbx_prod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_prod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_prod.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_prod.Location = new System.Drawing.Point(315, 107);
            this.cbx_prod.Name = "cbx_prod";
            this.cbx_prod.Size = new System.Drawing.Size(172, 27);
            this.cbx_prod.TabIndex = 2;
            this.cbx_prod.Tag = "Perma";
            // 
            // cantidadnumericupdown
            // 
            this.cantidadnumericupdown.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadnumericupdown.Location = new System.Drawing.Point(371, 145);
            this.cantidadnumericupdown.Name = "cantidadnumericupdown";
            this.cantidadnumericupdown.Size = new System.Drawing.Size(36, 27);
            this.cantidadnumericupdown.TabIndex = 4;
            this.cantidadnumericupdown.Tag = "Perma";
            this.cantidadnumericupdown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(344, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 19);
            this.label12.TabIndex = 38;
            this.label12.Text = "Productos faltantes";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(298, 149);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 19);
            this.label14.TabIndex = 39;
            this.label14.Text = "Cantidad";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(353, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 19);
            this.label13.TabIndex = 40;
            this.label13.Text = "Codigo o Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 19);
            this.label5.TabIndex = 38;
            this.label5.Text = "Pedido Afectado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(683, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 19);
            this.label6.TabIndex = 38;
            this.label6.Text = "Detalles";
            // 
            // detallestxb
            // 
            this.detallestxb.Location = new System.Drawing.Point(588, 109);
            this.detallestxb.Name = "detallestxb";
            this.detallestxb.Size = new System.Drawing.Size(252, 96);
            this.detallestxb.TabIndex = 6;
            this.detallestxb.Text = "";
            // 
            // dataGridViewprods
            // 
            this.dataGridViewprods.AllowUserToAddRows = false;
            this.dataGridViewprods.AllowUserToDeleteRows = false;
            this.dataGridViewprods.AllowUserToOrderColumns = true;
            this.dataGridViewprods.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewprods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewprods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProducto,
            this.DescProducto,
            this.Precio,
            this.Eliminar});
            this.dataGridViewprods.Location = new System.Drawing.Point(12, 211);
            this.dataGridViewprods.Name = "dataGridViewprods";
            this.dataGridViewprods.RowHeadersVisible = false;
            this.dataGridViewprods.Size = new System.Drawing.Size(828, 273);
            this.dataGridViewprods.TabIndex = 42;
            this.dataGridViewprods.Tag = "Perma";
            this.dataGridViewprods.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewprods_CellContentClick);
            // 
            // IDProducto
            // 
            this.IDProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDProducto.HeaderText = "ID Producto";
            this.IDProducto.Name = "IDProducto";
            // 
            // DescProducto
            // 
            this.DescProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DescProducto.HeaderText = "Descripcion";
            this.DescProducto.Name = "DescProducto";
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 50;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            this.Eliminar.Width = 80;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(765, 490);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 38);
            this.btnIngresar.TabIndex = 7;
            this.btnIngresar.Tag = "Perma";
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblNeto
            // 
            this.lblNeto.AutoSize = true;
            this.lblNeto.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblNeto.Location = new System.Drawing.Point(147, 500);
            this.lblNeto.Name = "lblNeto";
            this.lblNeto.Size = new System.Drawing.Size(60, 19);
            this.lblNeto.TabIndex = 56;
            this.lblNeto.Text = "%neto%";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 12F);
            this.label15.Location = new System.Drawing.Point(96, 499);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 19);
            this.label15.TabIndex = 55;
            this.label15.Text = "Neto: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 177);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "Numero: ";
            // 
            // fechatxb
            // 
            this.fechatxb.Enabled = false;
            this.fechatxb.Location = new System.Drawing.Point(86, 141);
            this.fechatxb.Name = "fechatxb";
            this.fechatxb.Size = new System.Drawing.Size(188, 27);
            this.fechatxb.TabIndex = 1;
            // 
            // nfptxb
            // 
            this.nfptxb.Enabled = false;
            this.nfptxb.Location = new System.Drawing.Point(86, 174);
            this.nfptxb.Name = "nfptxb";
            this.nfptxb.Size = new System.Drawing.Size(188, 27);
            this.nfptxb.TabIndex = 1;
            // 
            // NotaCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(857, 537);
            this.Controls.Add(this.lblNeto);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.dataGridViewprods);
            this.Controls.Add(this.detallestxb);
            this.Controls.Add(this.btn_ExplorarItems);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbx_prod);
            this.Controls.Add(this.cantidadnumericupdown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.facturasCbx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Fecha);
            this.Controls.Add(this.nfptxb);
            this.Controls.Add(this.fechatxb);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(873, 576);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(873, 576);
            this.Name = "NotaCredito";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nota de Credito";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NotaCredito_FormClosing);
            this.Load += new System.EventHandler(this.NotaCredito_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NotaCredito_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.cantidadnumericupdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewprods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lbl_ID;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox facturasCbx;
        private System.Windows.Forms.Button btn_ExplorarItems;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cbx_prod;
        private System.Windows.Forms.NumericUpDown cantidadnumericupdown;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox detallestxb;
        private System.Windows.Forms.DataGridView dataGridViewprods;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblNeto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox fechatxb;
        private System.Windows.Forms.TextBox nfptxb;
    }
}