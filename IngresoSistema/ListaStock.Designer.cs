namespace IngresoSistema
{
    partial class ListaStock
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
            this.lsvListaStock = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsvListaStock
            // 
            this.lsvListaStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvListaStock.HideSelection = false;
            this.lsvListaStock.Location = new System.Drawing.Point(32, 21);
            this.lsvListaStock.Name = "lsvListaStock";
            this.lsvListaStock.Size = new System.Drawing.Size(261, 263);
            this.lsvListaStock.TabIndex = 0;
            this.lsvListaStock.UseCompatibleStateImageBehavior = false;
            this.lsvListaStock.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Producto";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Stock";
            this.columnHeader2.Width = 46;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Categoria";
            this.columnHeader3.Width = 67;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Precio";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(90, 300);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(146, 26);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ListaStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 347);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lsvListaStock);
            this.Name = "ListaStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaStock";
            this.Load += new System.EventHandler(this.ListaStock_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvListaStock;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnSalir;
    }
}