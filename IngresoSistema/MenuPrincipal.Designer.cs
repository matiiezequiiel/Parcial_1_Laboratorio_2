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
            this.lsvClientes = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblListaClientes = new System.Windows.Forms.Label();
            this.lblListaProductos = new System.Windows.Forms.Label();
            this.lsvProductos = new System.Windows.Forms.ListView();
            this.nombreProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stockProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblCarrito = new System.Windows.Forms.Label();
            this.lsvCarrito = new System.Windows.Forms.ListView();
            this.lblNuevoCliente = new System.Windows.Forms.Button();
            this.btnVaciarCarrito = new System.Windows.Forms.Button();
            this.btnConfirmarCompra = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblTotalCompra = new System.Windows.Forms.Label();
            this.lblTotalDescuento = new System.Windows.Forms.Label();
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
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
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
            this.nuevaCompraToolStripMenuItem.Click += new System.EventHandler(this.nuevaCompraToolStripMenuItem_Click);
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
            // lsvClientes
            // 
            this.lsvClientes.CheckBoxes = true;
            this.lsvClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lsvClientes.FullRowSelect = true;
            this.lsvClientes.GridLines = true;
            this.lsvClientes.HideSelection = false;
            this.lsvClientes.Location = new System.Drawing.Point(45, 101);
            this.lsvClientes.Name = "lsvClientes";
            this.lsvClientes.Size = new System.Drawing.Size(151, 253);
            this.lsvClientes.TabIndex = 3;
            this.lsvClientes.UseCompatibleStateImageBehavior = false;
            this.lsvClientes.View = System.Windows.Forms.View.Details;
            this.lsvClientes.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lsvClientes_ItemCheck);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 73;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Apellido";
            this.columnHeader2.Width = 72;
            // 
            // lblListaClientes
            // 
            this.lblListaClientes.AutoSize = true;
            this.lblListaClientes.Location = new System.Drawing.Point(83, 74);
            this.lblListaClientes.Name = "lblListaClientes";
            this.lblListaClientes.Size = new System.Drawing.Size(83, 13);
            this.lblListaClientes.TabIndex = 4;
            this.lblListaClientes.Text = "Lista de clientes";
            // 
            // lblListaProductos
            // 
            this.lblListaProductos.AutoSize = true;
            this.lblListaProductos.Location = new System.Drawing.Point(287, 74);
            this.lblListaProductos.Name = "lblListaProductos";
            this.lblListaProductos.Size = new System.Drawing.Size(94, 13);
            this.lblListaProductos.TabIndex = 5;
            this.lblListaProductos.Text = "Lista de productos";
            // 
            // lsvProductos
            // 
            this.lsvProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nombreProducto,
            this.stockProducto});
            this.lsvProductos.FullRowSelect = true;
            this.lsvProductos.GridLines = true;
            this.lsvProductos.HideSelection = false;
            this.lsvProductos.Location = new System.Drawing.Point(252, 101);
            this.lsvProductos.Name = "lsvProductos";
            this.lsvProductos.Size = new System.Drawing.Size(151, 253);
            this.lsvProductos.TabIndex = 6;
            this.lsvProductos.UseCompatibleStateImageBehavior = false;
            this.lsvProductos.View = System.Windows.Forms.View.Details;
            // 
            // nombreProducto
            // 
            this.nombreProducto.Text = "Producto";
            // 
            // stockProducto
            // 
            this.stockProducto.Text = "Stock";
            this.stockProducto.Width = 41;
            // 
            // lblCarrito
            // 
            this.lblCarrito.AutoSize = true;
            this.lblCarrito.Location = new System.Drawing.Point(496, 74);
            this.lblCarrito.Name = "lblCarrito";
            this.lblCarrito.Size = new System.Drawing.Size(95, 13);
            this.lblCarrito.TabIndex = 7;
            this.lblCarrito.Text = "Carrito de compras";
            // 
            // lsvCarrito
            // 
            this.lsvCarrito.AllowDrop = true;
            this.lsvCarrito.HideSelection = false;
            this.lsvCarrito.Location = new System.Drawing.Point(470, 101);
            this.lsvCarrito.MultiSelect = false;
            this.lsvCarrito.Name = "lsvCarrito";
            this.lsvCarrito.Size = new System.Drawing.Size(151, 253);
            this.lsvCarrito.TabIndex = 8;
            this.lsvCarrito.UseCompatibleStateImageBehavior = false;
            this.lsvCarrito.View = System.Windows.Forms.View.Details;
            // 
            // lblNuevoCliente
            // 
            this.lblNuevoCliente.Location = new System.Drawing.Point(45, 360);
            this.lblNuevoCliente.Name = "lblNuevoCliente";
            this.lblNuevoCliente.Size = new System.Drawing.Size(151, 23);
            this.lblNuevoCliente.TabIndex = 9;
            this.lblNuevoCliente.Text = "Ingresar nuevo cliente";
            this.lblNuevoCliente.UseVisualStyleBackColor = true;
            // 
            // btnVaciarCarrito
            // 
            this.btnVaciarCarrito.Location = new System.Drawing.Point(627, 175);
            this.btnVaciarCarrito.Name = "btnVaciarCarrito";
            this.btnVaciarCarrito.Size = new System.Drawing.Size(146, 36);
            this.btnVaciarCarrito.TabIndex = 10;
            this.btnVaciarCarrito.Text = "VACIAR CARRITO";
            this.btnVaciarCarrito.UseVisualStyleBackColor = true;
            // 
            // btnConfirmarCompra
            // 
            this.btnConfirmarCompra.Location = new System.Drawing.Point(627, 217);
            this.btnConfirmarCompra.Name = "btnConfirmarCompra";
            this.btnConfirmarCompra.Size = new System.Drawing.Size(146, 38);
            this.btnConfirmarCompra.TabIndex = 11;
            this.btnConfirmarCompra.Text = "CONFIRMAR COMPRA";
            this.btnConfirmarCompra.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(476, 370);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "Total:";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(476, 398);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(62, 13);
            this.lblDescuento.TabIndex = 13;
            this.lblDescuento.Text = "Descuento:";
            // 
            // lblTotalCompra
            // 
            this.lblTotalCompra.AutoSize = true;
            this.lblTotalCompra.Location = new System.Drawing.Point(547, 370);
            this.lblTotalCompra.Name = "lblTotalCompra";
            this.lblTotalCompra.Size = new System.Drawing.Size(0, 13);
            this.lblTotalCompra.TabIndex = 14;
            // 
            // lblTotalDescuento
            // 
            this.lblTotalDescuento.AutoSize = true;
            this.lblTotalDescuento.Location = new System.Drawing.Point(547, 398);
            this.lblTotalDescuento.Name = "lblTotalDescuento";
            this.lblTotalDescuento.Size = new System.Drawing.Size(0, 13);
            this.lblTotalDescuento.TabIndex = 15;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.lblTotalDescuento);
            this.Controls.Add(this.lblTotalCompra);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnConfirmarCompra);
            this.Controls.Add(this.btnVaciarCarrito);
            this.Controls.Add(this.lblNuevoCliente);
            this.Controls.Add(this.lsvCarrito);
            this.Controls.Add(this.lblCarrito);
            this.Controls.Add(this.lsvProductos);
            this.Controls.Add(this.lblListaProductos);
            this.Controls.Add(this.lblListaClientes);
            this.Controls.Add(this.lsvClientes);
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
        private System.Windows.Forms.ListView lsvClientes;
        private System.Windows.Forms.Label lblListaClientes;
        private System.Windows.Forms.Label lblListaProductos;
        private System.Windows.Forms.ListView lsvProductos;
        private System.Windows.Forms.Label lblCarrito;
        private System.Windows.Forms.ListView lsvCarrito;
        private System.Windows.Forms.Button lblNuevoCliente;
        private System.Windows.Forms.Button btnVaciarCarrito;
        private System.Windows.Forms.Button btnConfirmarCompra;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblTotalCompra;
        private System.Windows.Forms.Label lblTotalDescuento;
        private System.Windows.Forms.ColumnHeader nombreProducto;
        private System.Windows.Forms.ColumnHeader stockProducto;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}