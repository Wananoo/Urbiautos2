namespace Urbiautos
{
    partial class Contenedor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contenedor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirVentanaPrincipalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirVentanaPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenedorInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revisarFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.respaldarBDDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simularErrorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ConexText = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerlabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.maintimer = new System.Windows.Forms.Timer(this.components);
            this.configurarConexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirVentanaPrincipalToolStripMenuItem1,
            this.abrirVentanaPrincipalToolStripMenuItem,
            this.mantenedorInventarioToolStripMenuItem,
            this.ingresarFacturaToolStripMenuItem,
            this.revisarFacturasToolStripMenuItem,
            this.respaldarBDDToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.simularErrorToolStripMenuItem,
            this.configurarConexionToolStripMenuItem});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.archivoToolStripMenuItem.Text = "Menu";
            // 
            // abrirVentanaPrincipalToolStripMenuItem1
            // 
            this.abrirVentanaPrincipalToolStripMenuItem1.Name = "abrirVentanaPrincipalToolStripMenuItem1";
            this.abrirVentanaPrincipalToolStripMenuItem1.Size = new System.Drawing.Size(200, 22);
            this.abrirVentanaPrincipalToolStripMenuItem1.Text = "Abrir Ventana Principal";
            this.abrirVentanaPrincipalToolStripMenuItem1.Click += new System.EventHandler(this.abrirVentanaPrincipalToolStripMenuItem1_Click);
            // 
            // abrirVentanaPrincipalToolStripMenuItem
            // 
            this.abrirVentanaPrincipalToolStripMenuItem.Name = "abrirVentanaPrincipalToolStripMenuItem";
            this.abrirVentanaPrincipalToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.abrirVentanaPrincipalToolStripMenuItem.Text = "Consultar Registros";
            this.abrirVentanaPrincipalToolStripMenuItem.Click += new System.EventHandler(this.abrirBusquedaPatenteToolStripMenuItem_Click);
            // 
            // mantenedorInventarioToolStripMenuItem
            // 
            this.mantenedorInventarioToolStripMenuItem.Name = "mantenedorInventarioToolStripMenuItem";
            this.mantenedorInventarioToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.mantenedorInventarioToolStripMenuItem.Text = "Mantenedor Inventario";
            this.mantenedorInventarioToolStripMenuItem.Click += new System.EventHandler(this.mantenedorInventarioToolStripMenuItem_Click);
            // 
            // ingresarFacturaToolStripMenuItem
            // 
            this.ingresarFacturaToolStripMenuItem.Name = "ingresarFacturaToolStripMenuItem";
            this.ingresarFacturaToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.ingresarFacturaToolStripMenuItem.Text = "Ingresar Factura";
            this.ingresarFacturaToolStripMenuItem.Click += new System.EventHandler(this.ingresarFacturaToolStripMenuItem_Click);
            // 
            // revisarFacturasToolStripMenuItem
            // 
            this.revisarFacturasToolStripMenuItem.Name = "revisarFacturasToolStripMenuItem";
            this.revisarFacturasToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.revisarFacturasToolStripMenuItem.Text = "Revisar Facturas";
            this.revisarFacturasToolStripMenuItem.Click += new System.EventHandler(this.administrarClientesAutosToolStripMenuItem_Click);
            // 
            // respaldarBDDToolStripMenuItem
            // 
            this.respaldarBDDToolStripMenuItem.Name = "respaldarBDDToolStripMenuItem";
            this.respaldarBDDToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.respaldarBDDToolStripMenuItem.Text = "Respaldar BDD";
            this.respaldarBDDToolStripMenuItem.Click += new System.EventHandler(this.respaldarBDDToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // simularErrorToolStripMenuItem
            // 
            this.simularErrorToolStripMenuItem.Name = "simularErrorToolStripMenuItem";
            this.simularErrorToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.simularErrorToolStripMenuItem.Text = "Simular Error";
            this.simularErrorToolStripMenuItem.Click += new System.EventHandler(this.simularErrorToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConexText,
            this.toolStripStatusLabel1,
            this.timerlabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ConexText
            // 
            this.ConexText.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConexText.Name = "ConexText";
            this.ConexText.Size = new System.Drawing.Size(86, 17);
            this.ConexText.Text = "Urbiautos V0.5";
            this.ConexText.Click += new System.EventHandler(this.ConexText_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(646, 17);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // timerlabel
            // 
            this.timerlabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerlabel.Name = "timerlabel";
            this.timerlabel.Size = new System.Drawing.Size(53, 17);
            this.timerlabel.Text = "%timer%";
            // 
            // maintimer
            // 
            this.maintimer.Interval = 1000;
            this.maintimer.Tick += new System.EventHandler(this.maintimer_Tick);
            // 
            // configurarConexionToolStripMenuItem
            // 
            this.configurarConexionToolStripMenuItem.Name = "configurarConexionToolStripMenuItem";
            this.configurarConexionToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.configurarConexionToolStripMenuItem.Text = "Configurar Conexion";
            this.configurarConexionToolStripMenuItem.Click += new System.EventHandler(this.configurarConexionToolStripMenuItem_Click);
            // 
            // Contenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Contenedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urbiautos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Contenedor_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Contenedor_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Contenedor_DragDrop);
            this.QueryContinueDrag += new System.Windows.Forms.QueryContinueDragEventHandler(this.Contenedor_QueryContinueDrag);
            this.Enter += new System.EventHandler(this.Contenedor_Enter);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Contenedor_MouseDown);
            this.Move += new System.EventHandler(this.Contenedor_Move_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirVentanaPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ConexText;
        private System.Windows.Forms.ToolStripMenuItem revisarFacturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirVentanaPrincipalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripStatusLabel timerlabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem mantenedorInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem respaldarBDDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simularErrorToolStripMenuItem;
        public System.Windows.Forms.Timer maintimer;
        private System.Windows.Forms.ToolStripMenuItem configurarConexionToolStripMenuItem;
    }
}

