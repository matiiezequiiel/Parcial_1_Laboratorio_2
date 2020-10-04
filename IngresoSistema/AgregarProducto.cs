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
    public partial class AgregarProducto : Form
    {
        List<Producto> listaProductos = new List<Producto>();
        MenuPrincipal auxMenu;
        

        public AgregarProducto(MenuPrincipal m)
        {
            InitializeComponent();
            auxMenu = m;            
            
        }

   
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto nuevoProducto = new Producto();
            double aux;
            int aux2;
            double.TryParse(txtPrecio.Text, out aux);
            int.TryParse(txtStockInicial.Text, out aux2);
         

            nuevoProducto.NombreProducto = txtNombre.Text;
            nuevoProducto.PrecioProducto = aux;
            nuevoProducto.StockProducto = aux2;
            nuevoProducto.CodigoProducto = listaProductos.Count + 1;

            Comercio.AgregarProducto(nuevoProducto);
            auxMenu.CargarListaProducto();
            MessageBox.Show("Producto agregado correctamente.");
            

            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            UserPass.formMenu.Show();
        }
    }
}
