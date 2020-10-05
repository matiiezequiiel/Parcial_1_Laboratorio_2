using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngresoSistema
{
    public partial class MenuPrincipal : Form
    {
        List<Producto> listaAuxProdEnCompra=new List<Producto>();
        List<Producto> listaAuxProd = new List<Producto>();
        List<Cliente> listaAuxCliente = new List<Cliente>();
        List<Producto> carroDeCompras = new List<Producto>();
   
        
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@" C:\Users\maguirre\source\repos\Parcial_1_Laboratorio_2\AperturaPuerta.wav");
            player.Play();
            CargarMenuCompras(false);
            CargarListaCliente();
            CargarListaProducto();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@" C:\Users\maguirre\source\repos\Parcial_1_Laboratorio_2\AperturaPuerta.wav");
            player.Play();
        }

        private void nuevaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarMenuCompras(true);
        }

        private void CargarMenuCompras(bool estado)
        {
            if (estado)
            {
                lblEmpleadoLogeado.Visible = true;
                txtEmpleadoLogeado.Visible = true;
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
                lblEmpleadoLogeado.Visible = false;
                txtEmpleadoLogeado.Visible = false;
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

        public void CargarListaProducto()
        {

            lsvProductos.Items.Clear();
            listaAuxProd = Comercio.RetornarListaProductos();

            foreach (Producto item in listaAuxProd)
            {
                string nombre = item.NombreProducto;
                int stock = item.StockProducto;
                string categoria = item.CategoriaProducto;
                int codigo = item.CodigoProducto;
                double precio = item.PrecioProducto;

                listaAuxProdEnCompra.Add(new Producto(nombre, categoria, precio, stock, codigo));
            }


            foreach (Producto item in listaAuxProd)
            {
                ListViewItem aux = new ListViewItem(item.NombreProducto);
                aux.SubItems.Add(item.StockProducto.ToString());
                aux.SubItems.Add(item.PrecioProducto.ToString());
                lsvProductos.Items.Add(aux);

            }
        }

        private void RefrescarListaProducto()
        {
            lsvProductos.Items.Clear();
         
            
           
            foreach (Producto item in listaAuxProdEnCompra)
            {
                ListViewItem aux = new ListViewItem(item.NombreProducto);
                aux.SubItems.Add(item.StockProducto.ToString());
                aux.SubItems.Add(item.PrecioProducto.ToString());
                lsvProductos.Items.Add(aux);

            }
           
        }    
        private void RefrescarCarrito()
        {
            lsvProductos.Items.Clear();
           
         
            foreach (Producto item in listaAuxProd)
            {
                ListViewItem aux = new ListViewItem(item.NombreProducto);
                aux.SubItems.Add(item.StockProducto.ToString());
                aux.SubItems.Add(item.PrecioProducto.ToString());
                lsvProductos.Items.Add(aux);

            }

            listaAuxProdEnCompra.Clear();

            foreach (Producto item in listaAuxProd)
            {
                string nombre = item.NombreProducto;
                int stock = item.StockProducto;
                string categoria = item.CategoriaProducto;
                int codigo = item.CodigoProducto;
                double precio = item.PrecioProducto;

                listaAuxProdEnCompra.Add(new Producto(nombre, categoria, precio, stock, codigo));
            }
           
        }
        private void lsvClientes_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int indiceCheck;

            indiceCheck = e.Index;

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
            try
            {
                int linea = lsvProductos.HitTest(e.X, e.Y).Item.Index;
                lsvProductos.DoDragDrop(linea, DragDropEffects.Copy);
            }
            catch (Exception)
            {
               
                
            }
  
        }

        private void lsvCarrito_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void lsvCarrito_DragDrop(object sender, DragEventArgs e)
        {
            bool seleccionoCliente = false;
            
            foreach (ListViewItem auxLista in lsvClientes.Items)
            {
                if (auxLista.Checked == true)
                {
                    lsvClientes.CheckBoxes = false;
                    seleccionoCliente = true;
                    break;
                }
                
            }

            if(seleccionoCliente)
            {
                int lineaArrastrada = Convert.ToInt32(e.Data.GetData(Type.GetType("System.Int32")));


                foreach (ListViewItem aux in lsvProductos.Items)
                {
                    if (lineaArrastrada == aux.Index)
                    {
                        if(aux.SubItems[1].Text!="0")
                        {
                            ListViewItem nuevoProducto = new ListViewItem(aux.Text);
                            lsvCarrito.Items.Add(nuevoProducto);
                            ActualizarStockListaAux(aux.Text);
                            break;

                        }
                        else
                        {
                            MessageBox.Show("No hay stock del producto seleccionado");
                            if(lsvCarrito.Items.Count==0)
                            {
                                lsvClientes.CheckBoxes = true;
                            }
                            
                        }
                        
                    }
                }

            }
         
           
        }

        private void ActualizarStockListaAux (string productoActualizar)
        {

            foreach (Producto item in listaAuxProdEnCompra)
            {
                if(item.NombreProducto==productoActualizar)
                {
                    item.StockProducto = item.StockProducto - 1;
                    carroDeCompras.Add(item);
                    SacarTotales();
                    RefrescarListaProducto();
                    break;
                   
                }
            }
        }

        private void btnVaciarCarrito_Click(object sender, EventArgs e)
        {
            if(carroDeCompras.Count>0)
            {
                lsvCarrito.Items.Clear();
                carroDeCompras.Clear();
                lsvClientes.CheckBoxes = true;
                this.lblTotalCompra.Text = "";
                this.lblTotalDescuento.Text = "";
                RefrescarCarrito();

            }
            else
            {
                MessageBox.Show("El carrito esta vacio.");
            }
            
            
        }
        
        private void SacarTotales()
        {
            double total=0;
            double totalDesc = 0;
            double descuentoProducto = 0;



            foreach (ListViewItem auxLista in lsvClientes.Items)
            {
                if (auxLista.Checked ==true)
                {
                    string nombre = auxLista.SubItems[0].Text;
                    string apellido = auxLista.SubItems[1].Text;

                    if (apellido == "Simpson")
                    {
                        foreach (Producto prod in carroDeCompras)
                        {
                            total = total + prod.PrecioProducto;
                            descuentoProducto = prod.PrecioProducto * 15 / 100;
                            totalDesc = totalDesc + descuentoProducto;

                        }
                        this.lblTotalCompra.Text = "$" + total.ToString();
                        this.lblTotalDescuento.Text = "$" + totalDesc.ToString();
                    }
                    else
                    {
                        foreach (Producto prod in carroDeCompras)
                        {
                            total = total + prod.PrecioProducto;

                        }
                        this.lblTotalCompra.Text = "$" + total.ToString();
                    }



                }

            }

            
        }

        private void btnConfirmarCompra_Click(object sender, EventArgs e)
        {
            int nroTicket;

            if(carroDeCompras.Count>0)
            {
                nroTicket=Comercio.CargarVenta(carroDeCompras,this.txtEmpleadoLogeado.Text);
                GenerarTicket(carroDeCompras,nroTicket);
                Comercio.ActualizarListaStock(listaAuxProdEnCompra);
                listaAuxProdEnCompra.Clear();
                lsvCarrito.Items.Clear();
                lblTotalCompra.Text = "";
                lblTotalDescuento.Text = ""; 
                lsvClientes.CheckBoxes = true;
                carroDeCompras.Clear();
                CargarListaProducto();

                MessageBox.Show("GRACIAS VUELVA PRONTOS!!!");
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@" C:\Users\maguirre\source\repos\Parcial_1_Laboratorio_2\GraciasVuelvaPronto.wav");
                player.Play();

            }
            else
            {
                MessageBox.Show("El carrito esta vacio.");
            }
        }

        private void GenerarTicket(List<Producto> carritoDeCompras,int nroTicket)
        {
            string nombreTicket = nroTicket.ToString();
            Stream fs = new FileStream("C:/Users/maguirre/source/repos/Parcial_1_Laboratorio_2/TicketsDeCompra/Ticket " + nroTicket+".txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
         

            sw.WriteLine("Usted fue atendido por: " + this.txtEmpleadoLogeado.Text);
            sw.WriteLine("Fecha: " + DateTime.Now);

            foreach (ListViewItem item in lsvClientes.Items)
            {
                if (item.Checked == true)
                {
                    sw.WriteLine("Cliente: " + item.Text + " " + item.SubItems[1].Text);
                  
                }
 
            }

            sw.WriteLine("");
            sw.WriteLine("");
            sw.WriteLine("Lista de productos: ");
            sw.WriteLine("------------------------------");

            foreach (Producto item in carritoDeCompras)
            {
                sw.WriteLine(item.NombreProducto+"           " +"$"+ item.PrecioProducto);
            }
            sw.WriteLine("------------------------------");

            sw.WriteLine("Total: " + this.lblTotalCompra.Text);
            sw.WriteLine("");
            sw.WriteLine("Descuento: " + this.lblTotalDescuento.Text);
            sw.WriteLine("");
            sw.WriteLine("Nro de ticket: " + nroTicket);

            sw.Close();


        }

        private void lblNuevoCliente_Click(object sender, EventArgs e)
        {
            NuevoCliente formAgregarCliente = new NuevoCliente(this);
            this.Hide();
            formAgregarCliente.Show();
        }

        private void comprasPorEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComprasPorEmpleado formCompraPorEmpleado = new ComprasPorEmpleado();
            this.Hide();
            formCompraPorEmpleado.Show();
        }

        private void stockDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaStock formStock = new ListaStock();
            this.Hide();
            formStock.Show();
        }

        private void altaProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarProducto formAgregarProducto = new AgregarProducto(this);
            this.Hide();
            formAgregarProducto.Show();
        }

        private void productoConMenosDe10UnidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockMenosProductos formStock10Un = new StockMenosProductos();
            this.Hide();
            formStock10Un.Show();
        }
    }
}
