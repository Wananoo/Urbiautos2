namespace Urbiautos
{
    partial class IngresoFactura
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
            this.descuentolabel = new System.Windows.Forms.Label();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_ExplorarItems = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.DescProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maskedTextBoxTelefono = new System.Windows.Forms.MaskedTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbliva = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblNeto = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.IDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewprods = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cbx_prod = new System.Windows.Forms.ComboBox();
            this.cantidadnumericupdown = new System.Windows.Forms.NumericUpDown();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.correotxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProvCbx = new System.Windows.Forms.ComboBox();
            this.ruttxb = new System.Windows.Forms.TextBox();
            this.btnAddProv = new System.Windows.Forms.Button();
            this.nFacttxb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewprods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadnumericupdown)).BeginInit();
            this.SuspendLayout();
            // 
            // descuentolabel
            // 
            this.descuentolabel.AutoSize = true;
            this.descuentolabel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descuentolabel.Location = new System.Drawing.Point(382, 520);
            this.descuentolabel.Name = "descuentolabel";
            this.descuentolabel.Size = new System.Drawing.Size(72, 13);
            this.descuentolabel.TabIndex = 46;
            this.descuentolabel.Text = "%descuento%";
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
            // btn_ExplorarItems
            // 
            this.btn_ExplorarItems.BackColor = System.Drawing.SystemColors.Control;
            this.btn_ExplorarItems.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExplorarItems.Location = new System.Drawing.Point(474, 139);
            this.btn_ExplorarItems.Name = "btn_ExplorarItems";
            this.btn_ExplorarItems.Size = new System.Drawing.Size(36, 23);
            this.btn_ExplorarItems.TabIndex = 5;
            this.btn_ExplorarItems.Text = "...";
            this.btn_ExplorarItems.UseVisualStyleBackColor = false;
            this.btn_ExplorarItems.Click += new System.EventHandler(this.btn_ExplorarItems_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(544, 89);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(221, 130);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Tag = "Perma";
            this.richTextBox1.Text = "";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(381, 534);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(76, 23);
            this.lbltotal.TabIndex = 47;
            this.lbltotal.Text = "%total%";
            // 
            // DescProducto
            // 
            this.DescProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DescProducto.HeaderText = "Descripcion";
            this.DescProducto.Name = "DescProducto";
            // 
            // maskedTextBoxTelefono
            // 
            this.maskedTextBoxTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBoxTelefono.Enabled = false;
            this.maskedTextBoxTelefono.Font = new System.Drawing.Font("Calibri", 12F);
            this.maskedTextBoxTelefono.Location = new System.Drawing.Point(81, 155);
            this.maskedTextBoxTelefono.Mask = "(+56\\9)00000000";
            this.maskedTextBoxTelefono.Name = "maskedTextBoxTelefono";
            this.maskedTextBoxTelefono.Size = new System.Drawing.Size(188, 27);
            this.maskedTextBoxTelefono.TabIndex = 2;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(327, 521);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(60, 13);
            this.label20.TabIndex = 53;
            this.label20.Text = "Descuento:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(330, 533);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 23);
            this.label17.TabIndex = 45;
            this.label17.Text = "Total: ";
            // 
            // lbliva
            // 
            this.lbliva.AutoSize = true;
            this.lbliva.Font = new System.Drawing.Font("Calibri", 12F);
            this.lbliva.Location = new System.Drawing.Point(235, 537);
            this.lbliva.Name = "lbliva";
            this.lbliva.Size = new System.Drawing.Size(50, 19);
            this.lbliva.TabIndex = 52;
            this.lbliva.Text = "%iva%";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 12F);
            this.label16.Location = new System.Drawing.Point(191, 537);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 19);
            this.label16.TabIndex = 51;
            this.label16.Text = "IVA: ";
            // 
            // lblNeto
            // 
            this.lblNeto.AutoSize = true;
            this.lblNeto.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblNeto.Location = new System.Drawing.Point(67, 537);
            this.lblNeto.Name = "lblNeto";
            this.lblNeto.Size = new System.Drawing.Size(60, 19);
            this.lblNeto.TabIndex = 50;
            this.lblNeto.Text = "%neto%";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 12F);
            this.label15.Location = new System.Drawing.Point(16, 536);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 19);
            this.label15.TabIndex = 49;
            this.label15.Text = "Neto: ";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(690, 527);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 38);
            this.btnIngresar.TabIndex = 11;
            this.btnIngresar.Tag = "Perma";
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(615, 56);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 19);
            this.label19.TabIndex = 24;
            this.label19.Text = "Descripcion";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // IDProducto
            // 
            this.IDProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDProducto.HeaderText = "ID Producto";
            this.IDProducto.Name = "IDProducto";
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
            this.dataGridViewprods.Location = new System.Drawing.Point(10, 248);
            this.dataGridViewprods.Name = "dataGridViewprods";
            this.dataGridViewprods.RowHeadersVisible = false;
            this.dataGridViewprods.Size = new System.Drawing.Size(755, 256);
            this.dataGridViewprods.TabIndex = 9;
            this.dataGridViewprods.Tag = "Perma";
            this.dataGridViewprods.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewprods_CellContentClick);
            this.dataGridViewprods.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewprods_CellContentClick);
            this.dataGridViewprods.Sorted += new System.EventHandler(this.dataGridViewprods_Sorted);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(392, 181);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 7;
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
            this.cbx_prod.Location = new System.Drawing.Point(295, 139);
            this.cbx_prod.Name = "cbx_prod";
            this.cbx_prod.Size = new System.Drawing.Size(172, 27);
            this.cbx_prod.TabIndex = 4;
            this.cbx_prod.Tag = "Perma";
            // 
            // cantidadnumericupdown
            // 
            this.cantidadnumericupdown.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadnumericupdown.Location = new System.Drawing.Point(351, 177);
            this.cantidadnumericupdown.Name = "cantidadnumericupdown";
            this.cantidadnumericupdown.Size = new System.Drawing.Size(36, 27);
            this.cantidadnumericupdown.TabIndex = 6;
            this.cantidadnumericupdown.Tag = "Perma";
            this.cantidadnumericupdown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fecha.Location = new System.Drawing.Point(202, 10);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(67, 19);
            this.lbl_Fecha.TabIndex = 20;
            this.lbl_Fecha.Text = "%fecha%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Fecha: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(353, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 19);
            this.label12.TabIndex = 27;
            this.label12.Text = "Producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(91, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 19);
            this.label7.TabIndex = 29;
            this.label7.Text = "Proveedor";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 19);
            this.label11.TabIndex = 36;
            this.label11.Text = "Correo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 19);
            this.label10.TabIndex = 30;
            this.label10.Text = "Telefono";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 19);
            this.label9.TabIndex = 31;
            this.label9.Text = "Nombre ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(278, 181);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 19);
            this.label14.TabIndex = 32;
            this.label14.Text = "Cantidad";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(333, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 19);
            this.label13.TabIndex = 33;
            this.label13.Text = "Codigo o Nombre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 19);
            this.label8.TabIndex = 34;
            this.label8.Text = "RUT";
            // 
            // correotxb
            // 
            this.correotxb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.correotxb.Enabled = false;
            this.correotxb.Font = new System.Drawing.Font("Calibri", 12F);
            this.correotxb.Location = new System.Drawing.Point(80, 188);
            this.correotxb.Name = "correotxb";
            this.correotxb.Size = new System.Drawing.Size(189, 27);
            this.correotxb.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID: ";
            // 
            // ProvCbx
            // 
            this.ProvCbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ProvCbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ProvCbx.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProvCbx.Location = new System.Drawing.Point(81, 86);
            this.ProvCbx.Name = "ProvCbx";
            this.ProvCbx.Size = new System.Drawing.Size(159, 27);
            this.ProvCbx.TabIndex = 0;
            this.ProvCbx.Tag = "Perma";
            this.ProvCbx.SelectedIndexChanged += new System.EventHandler(this.rutProvCbx_SelectedIndexChanged);
            // 
            // ruttxb
            // 
            this.ruttxb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ruttxb.Enabled = false;
            this.ruttxb.Font = new System.Drawing.Font("Calibri", 12F);
            this.ruttxb.Location = new System.Drawing.Point(81, 119);
            this.ruttxb.Name = "ruttxb";
            this.ruttxb.Size = new System.Drawing.Size(188, 27);
            this.ruttxb.TabIndex = 1;
            this.ruttxb.TextChanged += new System.EventHandler(this.ruttxb_TextChanged);
            // 
            // btnAddProv
            // 
            this.btnAddProv.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddProv.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProv.Location = new System.Drawing.Point(246, 87);
            this.btnAddProv.Name = "btnAddProv";
            this.btnAddProv.Size = new System.Drawing.Size(23, 23);
            this.btnAddProv.TabIndex = 55;
            this.btnAddProv.Text = "+";
            this.btnAddProv.UseVisualStyleBackColor = false;
            this.btnAddProv.Click += new System.EventHandler(this.btnAddProv_Click);
            // 
            // nFacttxb
            // 
            this.nFacttxb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nFacttxb.Font = new System.Drawing.Font("Calibri", 12F);
            this.nFacttxb.Location = new System.Drawing.Point(594, 530);
            this.nFacttxb.Name = "nFacttxb";
            this.nFacttxb.Size = new System.Drawing.Size(90, 27);
            this.nFacttxb.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(529, 534);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 66;
            this.label3.Text = "N° Fact.";
            // 
            // lbl_ID
            // 
            this.lbl_ID.Location = new System.Drawing.Point(41, 7);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(34, 27);
            this.lbl_ID.TabIndex = 67;
            this.lbl_ID.TextChanged += new System.EventHandler(this.lbl_ID_TextChanged);
            // 
            // IngresoFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(779, 581);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nFacttxb);
            this.Controls.Add(this.ruttxb);
            this.Controls.Add(this.ProvCbx);
            this.Controls.Add(this.descuentolabel);
            this.Controls.Add(this.btnAddProv);
            this.Controls.Add(this.btn_ExplorarItems);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.maskedTextBoxTelefono);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lbliva);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblNeto);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.dataGridViewprods);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbx_prod);
            this.Controls.Add(this.cantidadnumericupdown);
            this.Controls.Add(this.lbl_Fecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.correotxb);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(795, 620);
            this.MinimumSize = new System.Drawing.Size(795, 620);
            this.Name = "IngresoFactura";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso Factura";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IngresoFactura_FormClosing);
            this.Load += new System.EventHandler(this.IngresoFactura_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.IngresoFactura_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewprods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadnumericupdown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label descuentolabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.Button btn_ExplorarItems;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescProducto;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefono;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbliva;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblNeto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProducto;
        private System.Windows.Forms.DataGridView dataGridViewprods;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cbx_prod;
        private System.Windows.Forms.NumericUpDown cantidadnumericupdown;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox correotxb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ProvCbx;
        private System.Windows.Forms.TextBox ruttxb;
        private System.Windows.Forms.Button btnAddProv;
        private System.Windows.Forms.TextBox nFacttxb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lbl_ID;
    }
}