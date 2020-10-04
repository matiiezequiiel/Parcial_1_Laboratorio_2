namespace IngresoSistema
{
    partial class ComprasPorEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComprasPorEmpleado));
            this.lsvEmpleados = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvTicketsVendidos = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvListaCompra = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsvEmpleados
            // 
            this.lsvEmpleados.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lsvEmpleados.CheckBoxes = true;
            this.lsvEmpleados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lsvEmpleados.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvEmpleados.FullRowSelect = true;
            this.lsvEmpleados.GridLines = true;
            this.lsvEmpleados.HideSelection = false;
            this.lsvEmpleados.Location = new System.Drawing.Point(23, 64);
            this.lsvEmpleados.MultiSelect = false;
            this.lsvEmpleados.Name = "lsvEmpleados";
            this.lsvEmpleados.Size = new System.Drawing.Size(185, 287);
            this.lsvEmpleados.TabIndex = 0;
            this.lsvEmpleados.UseCompatibleStateImageBehavior = false;
            this.lsvEmpleados.View = System.Windows.Forms.View.Details;
            this.lsvEmpleados.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lsvEmpleados_ItemCheck);
            this.lsvEmpleados.SelectedIndexChanged += new System.EventHandler(this.lsvEmpleados_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 77;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Apellido";
            this.columnHeader2.Width = 104;
            // 
            // lsvTicketsVendidos
            // 
            this.lsvTicketsVendidos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lsvTicketsVendidos.CheckBoxes = true;
            this.lsvTicketsVendidos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.lsvTicketsVendidos.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvTicketsVendidos.FullRowSelect = true;
            this.lsvTicketsVendidos.GridLines = true;
            this.lsvTicketsVendidos.HideSelection = false;
            this.lsvTicketsVendidos.Location = new System.Drawing.Point(271, 64);
            this.lsvTicketsVendidos.MultiSelect = false;
            this.lsvTicketsVendidos.Name = "lsvTicketsVendidos";
            this.lsvTicketsVendidos.Size = new System.Drawing.Size(185, 287);
            this.lsvTicketsVendidos.TabIndex = 1;
            this.lsvTicketsVendidos.UseCompatibleStateImageBehavior = false;
            this.lsvTicketsVendidos.View = System.Windows.Forms.View.Details;
            this.lsvTicketsVendidos.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lsvTicketsVendidos_ItemCheck);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ticket";
            this.columnHeader3.Width = 80;
            // 
            // lsvListaCompra
            // 
            this.lsvListaCompra.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lsvListaCompra.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4});
            this.lsvListaCompra.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvListaCompra.FullRowSelect = true;
            this.lsvListaCompra.GridLines = true;
            this.lsvListaCompra.HideSelection = false;
            this.lsvListaCompra.Location = new System.Drawing.Point(514, 64);
            this.lsvListaCompra.MultiSelect = false;
            this.lsvListaCompra.Name = "lsvListaCompra";
            this.lsvListaCompra.Size = new System.Drawing.Size(185, 287);
            this.lsvListaCompra.TabIndex = 2;
            this.lsvListaCompra.UseCompatibleStateImageBehavior = false;
            this.lsvListaCompra.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Producto";
            this.columnHeader4.Width = 91;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSalir.Location = new System.Drawing.Point(604, 370);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(124, 48);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ComprasPorEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(789, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lsvListaCompra);
            this.Controls.Add(this.lsvTicketsVendidos);
            this.Controls.Add(this.lsvEmpleados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ComprasPorEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras por empleado";
            this.Load += new System.EventHandler(this.ComprasPorEmpleado_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvEmpleados;
        private System.Windows.Forms.ListView lsvTicketsVendidos;
        private System.Windows.Forms.ListView lsvListaCompra;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnSalir;
    }
}