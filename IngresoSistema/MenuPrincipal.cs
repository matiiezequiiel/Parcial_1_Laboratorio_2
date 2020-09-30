using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngresoSistema
{
    public partial class MenuPrincipal : Form
    {
        List<Producto> listaAuxProd = new List<Producto>();
        List<Cliente> listaAuxCliente = new List<Cliente>();

        public MenuPrincipal()
        {
            InitializeComponent();

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            Comercio.CargarHardcodeo();
            CargarMenuCompras(false);
            CargarListaCliente();
            CargarListaProducto();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarMenuCompras(true);
        }

        private void CargarMenuCompras(bool estado)
        {
            if (estado)
            {
                lblCarrito.Visible = true;
                lblDescuento.Visible = true;
                lblListaClientes.Visible = true;
                lblListaProductos.Visible = true;
                lblNuevoCliente.Visible = true;
                lblTotal.Visible = true;
                lblTotalCompra.Visible = true;
                lblTotalDescuento.Visible = true;
                btnConfirmarCompra.Visible = true;
                btnVaciarCarrito.Visible = true;
                lsvCarrito.Visible = true;
                lsvClientes.Visible = true;
                lsvProductos.Visible = true;
            }
            else
            {
                lblCarrito.Visible = false;
                lblDescuento.Visible = false;
                lblListaClientes.Visible = false;
                lblListaProductos.Visible = false;
                lblNuevoCliente.Visible = false;
                lblTotal.Visible = false;
                lblTotalCompra.Visible = false;
                lblTotalDescuento.Visible = false;
                btnConfirmarCompra.Visible = false;
                btnVaciarCarrito.Visible = false;
                lsvCarrito.Visible = false;
                lsvClientes.Visible = false;
                lsvProductos.Visible = false;
            }

        }

        private void CargarListaCliente()
        {

           
            listaAuxCliente = Comercio.RetornarListaClientes();

            foreach (Cliente item in listaAuxCliente)
            {
                ListViewItem aux = new ListViewItem(item.NombrePersona);
                aux.SubItems.Add(item.ApellidoPersona);
                lsvClientes.Items.Add(aux);

            }


        }

        private void CargarListaProducto()
        {
           
            listaAuxProd = Comercio.RetornarListaProductos();

            foreach (Producto item in listaAuxProd)
            {
                ListViewItem aux = new ListViewItem(item.NombreProducto);
                aux.SubItems.Add(item.StockProducto.ToString());
                lsvProductos.Items.Add(aux);

            }
        }

        private void RefrescarListaProducto()
        {
            lsvProductos.Items.Clear();
         
            foreach (Producto item in listaAuxProd)
            {
                ListViewItem aux = new ListViewItem(item.NombreProducto);
                aux.SubItems.Add(item.StockProducto.ToString());
                lsvProductos.Items.Add(aux);

            }
           
        }
        private void lsvClientes_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int indiceCheck;
            int count;

            indiceCheck = e.Index;
            count = lsvClientes.Items.Count;

            foreach (ListViewItem auxLista in lsvClientes.Items)
            {
                if (indiceCheck != auxLista.Index)
                {
                    auxLista.Checked = false;
                }

            }

        }

        private void lsvProductos_MouseDown(object sender, MouseEventArgs e)
        {
            int linea = lsvProductos.HitTest(e.X, e.Y).Item.Index;
            // ListViewItem linea=new ListViewItem(lsvProductos.HitTest(e.X, e.Y).Item.ToString());
            lsvProductos.DoDragDrop(linea, DragDropEffects.Copy);


        }

        private void lsvCarrito_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void lsvCarrito_DragDrop(object sender, DragEventArgs e)
        {
            int lineaArrastrada = Convert.ToInt32(e.Data.GetData(Type.GetType("System.Int32")));
      
         
            foreach (ListViewItem aux in lsvProductos.Items)
            {
                if (lineaArrastrada == aux.Index)
                {
                    ListViewItem nuevoProducto = new ListViewItem(aux.Text);
                    lsvCarrito.Items.Add(nuevoProducto);
                    ActualizarStockListaAux(aux.Text);
                    break;
                }
            }
           
        }

        private void ActualizarStockListaAux (string productoActualizar)
        {
            int auxStock;

            foreach (Producto item in listaAuxProd)
            {
                if(item.NombreProducto==productoActualizar)
                {
                    auxStock = item.StockProducto;
                    item.StockProducto = auxStock - 1;
                    RefrescarListaProducto();
                    break;
                   
                }
            }
        }
        
       

    }
}
