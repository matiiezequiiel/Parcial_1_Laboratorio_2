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
            this.lsvEmpleados = new System.Windows.Forms.ListView();
            this.lsvTicketsVendidos = new System.Windows.Forms.ListView();
            this.lsvListaCompra = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lsvEmpleados
            // 
            this.lsvEmpleados.CheckBoxes = true;
            this.lsvEmpleados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
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
            // lsvTicketsVendidos
            // 
            this.lsvTicketsVendidos.CheckBoxes = true;
            this.lsvTicketsVendidos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
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
            // 
            // lsvListaCompra
            // 
            this.lsvListaCompra.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4});
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
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ticket";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Producto";
            // 
            // ComprasPorEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsvListaCompra);
            this.Controls.Add(this.lsvTicketsVendidos);
            this.Controls.Add(this.lsvEmpleados);
            this.Name = "ComprasPorEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v";
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
    }
}