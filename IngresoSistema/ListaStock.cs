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
    public partial class ListaStock : Form
    {
        List<Producto> listaProductos=new List<Producto>();
        public ListaStock()
        {
            InitializeComponent();
        }

        private void ListaStock_Load(object sender, EventArgs e)
        {
            CargarListaProductos();
        }

        private void CargarListaProductos()
        {

            lsvListaStock.Items.Clear();
            listaProductos = Comercio.RetornarListaProductos();


            foreach (Producto item in listaProductos)
            {
                ListViewItem aux = new ListViewItem(item.nombreProducto);
                aux.SubItems.Add(item.stockProducto.ToString());
                aux.SubItems.Add(item.tipoProducto.ToString());
                aux.SubItems.Add("$"+item.precioProducto.ToString());
                

                lsvListaStock.Items.Add(aux);

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            UserPass.formMenu.Show();
        }

     
    }
}
