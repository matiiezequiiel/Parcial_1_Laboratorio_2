using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngresoSistema
{
    public partial class StockMenosProductos : Form
    {
        List<Producto> listaStock = new List<Producto>();
        public StockMenosProductos()
        {
            InitializeComponent();
        }

        private void StockMenosProductos_Load(object sender, EventArgs e)
        {
            CargarListaProductos();
        }

        private void CargarListaProductos()
        {

            lsvProductos.Items.Clear();
            listaStock = Comercio.RetornarListaProductos();


            foreach (Producto item in listaStock)
            {
                if(item.stockProducto<10)
                {
                    ListViewItem aux = new ListViewItem(item.nombreProducto);
                    aux.SubItems.Add(item.stockProducto.ToString());
                    aux.SubItems.Add(item.tipoProducto.ToString());
                    aux.SubItems.Add("$" + item.precioProducto.ToString());
                    lsvProductos.Items.Add(aux);

                } 

            }
        }
  

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
            UserPass.formMenu.Show();
        }
    }
}
