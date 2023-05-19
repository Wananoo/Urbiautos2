namespace Urbiautos
{
    partial class Devolucion
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
            this.btnIngresar = new System.Windows.Forms.Button();
            this.dataGridViewprods = new System.Windows.Forms.DataGridView();
            this.IDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.detallestxb = new System.Windows.Forms.RichTextBox();
            this.btn_ExplorarItems = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cbx_prod = new System.Windows.Forms.ComboBox();
            this.cantidadnumericupdown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Ventascbx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.fechatxb = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBuscarVenta = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbltotal2 = new System.Windows.Forms.Label();
            this.lbltotal1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDetalles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewprods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadnumericupdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(767, 486);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 38);
            this.btnIngresar.TabIndex = 58;
            this.btnIngresar.Tag = "Perma";
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
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
            this.dataGridViewprods.Location = new System.Drawing.Point(14, 238);
            this.dataGridViewprods.Name = "dataGridViewprods";
            this.dataGridViewprods.RowHeadersVisible = false;
            this.dataGridViewprods.Size = new System.Drawing.Size(395, 242);
            this.dataGridViewprods.TabIndex = 64;
            this.dataGridViewprods.Tag = "Perma";
            this.dataGridViewprods.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewprods_CellContentClick);
            this.dataGridViewprods.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewprods_CellEndEdit);
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
            // detallestxb
            // 
            this.detallestxb.Location = new System.Drawing.Point(590, 105);
            this.detallestxb.Name = "detallestxb";
            this.detallestxb.Size = new System.Drawing.Size(252, 96);
            this.detallestxb.TabIndex = 57;
            this.detallestxb.Text = "";
            // 
            // btn_ExplorarItems
            // 
            this.btn_ExplorarItems.BackColor = System.Drawing.SystemColors.Control;
            this.btn_ExplorarItems.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExplorarItems.Location = new System.Drawing.Point(515, 102);
            this.btn_ExplorarItems.Name = "btn_ExplorarItems";
            this.btn_ExplorarItems.Size = new System.Drawing.Size(36, 23);
            this.btn_ExplorarItems.TabIndex = 50;
            this.btn_ExplorarItems.Text = "...";
            this.btn_ExplorarItems.UseVisualStyleBackColor = false;
            this.btn_ExplorarItems.Click += new System.EventHandler(this.btn_ExplorarItems_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(433, 144);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 56;
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
            this.cbx_prod.Location = new System.Drawing.Point(336, 102);
            this.cbx_prod.Name = "cbx_prod";
            this.cbx_prod.Size = new System.Drawing.Size(172, 27);
            this.cbx_prod.TabIndex = 48;
            this.cbx_prod.Tag = "Perma";
            // 
            // cantidadnumericupdown
            // 
            this.cantidadnumericupdown.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadnumericupdown.Location = new System.Drawing.Point(392, 140);
            this.cantidadnumericupdown.Name = "cantidadnumericupdown";
            this.cantidadnumericupdown.Size = new System.Drawing.Size(36, 27);
            this.cantidadnumericupdown.TabIndex = 55;
            this.cantidadnumericupdown.Tag = "Perma";
            this.cantidadnumericupdown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(100, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 19);
            this.label5.TabIndex = 61;
            this.label5.Text = "Venta Afectada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(685, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 19);
            this.label6.TabIndex = 60;
            this.label6.Text = "Detalles";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(379, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 19);
            this.label12.TabIndex = 59;
            this.label12.Text = "Productos";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(319, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 19);
            this.label14.TabIndex = 62;
            this.label14.Text = "Cantidad";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(368, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 19);
            this.label13.TabIndex = 63;
            this.label13.Text = "Codigo o Nombre";
            // 
            // Ventascbx
            // 
            this.Ventascbx.FormattingEnabled = true;
            this.Ventascbx.Location = new System.Drawing.Point(88, 102);
            this.Ventascbx.Name = "Ventascbx";
            this.Ventascbx.Size = new System.Drawing.Size(153, 21);
            this.Ventascbx.TabIndex = 47;
            this.Ventascbx.SelectedIndexChanged += new System.EventHandler(this.Ventascbx_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Fecha: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Venta: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Fecha: ";
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Location = new System.Drawing.Point(149, 16);
            this.lbl_Fecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(50, 13);
            this.lbl_Fecha.TabIndex = 49;
            this.lbl_Fecha.Text = "%fecha%";
            // 
            // fechatxb
            // 
            this.fechatxb.Enabled = false;
            this.fechatxb.Location = new System.Drawing.Point(89, 129);
            this.fechatxb.Name = "fechatxb";
            this.fechatxb.Size = new System.Drawing.Size(188, 20);
            this.fechatxb.TabIndex = 45;
            // 
            // lbl_ID
            // 
            this.lbl_ID.Location = new System.Drawing.Point(45, 13);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(34, 20);
            this.lbl_ID.TabIndex = 44;
            this.lbl_ID.TextChanged += new System.EventHandler(this.lbl_ID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "ID: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewButtonColumn1});
            this.dataGridView1.Location = new System.Drawing.Point(447, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(395, 242);
            this.dataGridView1.TabIndex = 65;
            this.dataGridView1.Tag = "Perma";
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Producto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Eliminar";
            this.dataGridViewButtonColumn1.MinimumWidth = 50;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Text = "Eliminar";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn1.Width = 80;
            // 
            // btnBuscarVenta
            // 
            this.btnBuscarVenta.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscarVenta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarVenta.Location = new System.Drawing.Point(247, 100);
            this.btnBuscarVenta.Name = "btnBuscarVenta";
            this.btnBuscarVenta.Size = new System.Drawing.Size(29, 23);
            this.btnBuscarVenta.TabIndex = 66;
            this.btnBuscarVenta.Text = "...";
            this.btnBuscarVenta.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(126, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 19);
            this.label8.TabIndex = 67;
            this.label8.Text = "Productos devueltos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(578, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 19);
            this.label9.TabIndex = 68;
            this.label9.Text = "Productos a cambio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 483);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 19);
            this.label10.TabIndex = 69;
            this.label10.Text = "Total: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(443, 483);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 19);
            this.label11.TabIndex = 70;
            this.label11.Text = "Total: ";
            // 
            // lbltotal2
            // 
            this.lbltotal2.AutoSize = true;
            this.lbltotal2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal2.Location = new System.Drawing.Point(500, 483);
            this.lbltotal2.Name = "lbltotal2";
            this.lbltotal2.Size = new System.Drawing.Size(74, 19);
            this.lbltotal2.TabIndex = 71;
            this.lbltotal2.Text = "%total2%";
            // 
            // lbltotal1
            // 
            this.lbltotal1.AutoSize = true;
            this.lbltotal1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal1.Location = new System.Drawing.Point(55, 483);
            this.lbltotal1.Name = "lbltotal1";
            this.lbltotal1.Size = new System.Drawing.Size(74, 19);
            this.lbltotal1.TabIndex = 72;
            this.lbltotal1.Text = "%total1%";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(13, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(68, 17);
            this.radioButton1.TabIndex = 73;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Devuelto";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(124, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(69, 17);
            this.radioButton2.TabIndex = 74;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "A cambio";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(323, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 42);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de producto";
            // 
            // btnDetalles
            // 
            this.btnDetalles.BackColor = System.Drawing.SystemColors.Control;
            this.btnDetalles.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnDetalles.Location = new System.Drawing.Point(88, 155);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(188, 26);
            this.btnDetalles.TabIndex = 66;
            this.btnDetalles.Text = "Ver detalles de Venta";
            this.btnDetalles.UseVisualStyleBackColor = false;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // Devolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(857, 537);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbltotal1);
            this.Controls.Add(this.lbltotal2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.btnBuscarVenta);
            this.Controls.Add(this.dataGridView1);
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
            this.Controls.Add(this.Ventascbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Fecha);
            this.Controls.Add(this.fechatxb);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(873, 576);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(873, 576);
            this.Name = "Devolucion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolucion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Devolucion_FormClosing);
            this.Load += new System.EventHandler(this.Devolucion_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Devolucion_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewprods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadnumericupdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.DataGridView dataGridViewprods;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.RichTextBox detallestxb;
        private System.Windows.Forms.Button btn_ExplorarItems;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cbx_prod;
        private System.Windows.Forms.NumericUpDown cantidadnumericupdown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox Ventascbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.TextBox fechatxb;
        private System.Windows.Forms.TextBox lbl_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.Button btnBuscarVenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbltotal2;
        private System.Windows.Forms.Label lbltotal1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDetalles;
    }
}