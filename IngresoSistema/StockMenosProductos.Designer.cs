namespace IngresoSistema
{
    partial class StockMenosProductos
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
            this.lsvProductos = new System.Windows.Forms.ListView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lsvProductos
            // 
            this.lsvProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvProductos.FullRowSelect = true;
            this.lsvProductos.GridLines = true;
            this.lsvProductos.HideSelection = false;
            this.lsvProductos.Location = new System.Drawing.Point(28, 22);
            this.lsvProductos.Name = "lsvProductos";
            this.lsvProductos.Size = new System.Drawing.Size(273, 280);
            this.lsvProductos.TabIndex = 0;
            this.lsvProductos.UseCompatibleStateImageBehavior = false;
            this.lsvProductos.View = System.Windows.Forms.View.Details;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(112, 308);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(89, 41);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Producto";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Stock";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Categoria";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Precio";
            // 
            // StockMenosProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 361);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lsvProductos);
            this.Name = "StockMenosProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockMenosProductos";
            this.Load += new System.EventHandler(this.StockMenosProductos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvProductos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnSalir;
    }
}