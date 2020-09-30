namespace IngresoSistema
{
    partial class MenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDelNegocioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasPorEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockTotalProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosConMenosDe10UnidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mToolStripMenuItem,
            this.gestionDelNegocioToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mToolStripMenuItem
            // 
            this.mToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaCompraToolStripMenuItem});
            this.mToolStripMenuItem.Name = "mToolStripMenuItem";
            this.mToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.mToolStripMenuItem.Text = "Compras";
            // 
            // nuevaCompraToolStripMenuItem
            // 
            this.nuevaCompraToolStripMenuItem.Name = "nuevaCompraToolStripMenuItem";
            this.nuevaCompraToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevaCompraToolStripMenuItem.Text = "Nueva compra";
            // 
            // gestionDelNegocioToolStripMenuItem
            // 
            this.gestionDelNegocioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadosToolStripMenuItem,
            this.productosToolStripMenuItem});
            this.gestionDelNegocioToolStripMenuItem.Name = "gestionDelNegocioToolStripMenuItem";
            this.gestionDelNegocioToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.gestionDelNegocioToolStripMenuItem.Text = "Gestion del negocio";
            // 
            // listadosToolStripMenuItem
            // 
            this.listadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprasPorEmpleadoToolStripMenuItem,
            this.stockTotalProductosToolStripMenuItem,
            this.productosConMenosDe10UnidadesToolStripMenuItem});
            this.listadosToolStripMenuItem.Name = "listadosToolStripMenuItem";
            this.listadosToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.listadosToolStripMenuItem.Text = "Listados";
            // 
            // comprasPorEmpleadoToolStripMenuItem
            // 
            this.comprasPorEmpleadoToolStripMenuItem.Name = "comprasPorEmpleadoToolStripMenuItem";
            this.comprasPorEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.comprasPorEmpleadoToolStripMenuItem.Text = "Compras por empleado";
            // 
            // stockTotalProductosToolStripMenuItem
            // 
            this.stockTotalProductosToolStripMenuItem.Name = "stockTotalProductosToolStripMenuItem";
            this.stockTotalProductosToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.stockTotalProductosToolStripMenuItem.Text = "Stock total productos";
            // 
            // productosConMenosDe10UnidadesToolStripMenuItem
            // 
            this.productosConMenosDe10UnidadesToolStripMenuItem.Name = "productosConMenosDe10UnidadesToolStripMenuItem";
            this.productosConMenosDe10UnidadesToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.productosConMenosDe10UnidadesToolStripMenuItem.Text = "Productos con menos de 10 unidades";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarProductoToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // agregarProductoToolStripMenuItem
            // 
            this.agregarProductoToolStripMenuItem.Name = "agregarProductoToolStripMenuItem";
            this.agregarProductoToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.agregarProductoToolStripMenuItem.Text = "Agregar producto";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem nuevaCompraToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem gestionDelNegocioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasPorEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockTotalProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosConMenosDe10UnidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}