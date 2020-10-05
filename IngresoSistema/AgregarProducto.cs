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
        ErrorProvider error = new ErrorProvider();
        List<Producto> listaProductos = new List<Producto>();
        MenuPrincipal auxMenu;
        

        public AgregarProducto(MenuPrincipal m)
        {
            InitializeComponent();
            auxMenu = m;            
            
        }

   
        private void btnAgregar_Click(object sender, EventArgs e)
        { 
            
            Producto nuevoProd = new Producto();
            double aux;
            int aux2;

          
            if (double.TryParse(txtPrecio.Text, out aux) && int.TryParse(txtStockInicial.Text, out aux2) &&
            this.cmbCategoria.SelectedIndex != 0 )
            {
                nuevoProd.NombreProducto = txtNombre.Text;
                nuevoProd.PrecioProducto = aux;
                nuevoProd.StockProducto = aux2;
                nuevoProd.CategoriaProducto = this.cmbCategoria.Text;
                nuevoProd.CodigoProducto = listaProductos.Count + 1;

                Comercio.AgregarProducto(nuevoProd);
                auxMenu.CargarListaProducto();
                MessageBox.Show("Producto agregado correctamente.");
                LimpiarCampos();

            }
            else
            {
                MessageBox.Show("Algun valor es invalido, reeingrese los datos.");
            }
            
            
            

            
        }

        private void LimpiarCampos()
        {
            this.txtNombre.Text = "";
            this.txtPrecio.Text = "";
            this.txtStockInicial.Text = "";
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            UserPass.formMenu.Show();
        }

        private void AgregarProducto_Load(object sender, EventArgs e)
        {
            cmbCategoria.SelectedIndex = 0;
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {

             for (int i = 0; i < txtNombre.TextLength; i++)
                {
                    if (char.IsDigit(this.txtNombre.Text[i]) || string.IsNullOrEmpty(this.txtNombre.Text))
                    {
                        e.Cancel = true;
                        break;

                    }

                }

            


            if (e.Cancel)
            {
                MessageBox.Show("Solo se deben ingresar letras");

            }

        }

        private void txtNombre_Validated(object sender, EventArgs e)
        {
            error.SetError(this.txtNombre, "");
        }

        private void txtPrecio_Validating(object sender, CancelEventArgs e)
        {
           
            for (int i = 0; i < txtPrecio.TextLength; i++)
            {
                if (!char.IsDigit(this.txtPrecio.Text[i])|| string.IsNullOrEmpty(this.txtPrecio.Text))
                {
                    if (this.txtPrecio.Text[i] != ',' && this.txtPrecio.Text[i] != '.')
                    {
                        e.Cancel = true;
                        break;
                    }

                }

            }

            


            if (e.Cancel)
            {
                MessageBox.Show("Solo se deben ingresar numeros");

            }

        }

        private void txtPrecio_Validated(object sender, EventArgs e)
        {
            error.SetError(this.txtPrecio, "");
        }
        private void txtStockInicial_Validating(object sender, CancelEventArgs e)
        {
            
            for (int i = 0; i < txtStockInicial.TextLength; i++)
            {
                if (!char.IsDigit(this.txtStockInicial.Text[i]) || string.IsNullOrEmpty(this.txtStockInicial.Text))
                {

                    e.Cancel = true;
                    break;

                }

            }

            
           


            if (e.Cancel)
            {
                MessageBox.Show("Solo se deben ingresar numeros");

            }

        }

        private void txtStockInicial_Validated(object sender, EventArgs e)
        {
            error.SetError(this.txtStockInicial, "");
        }

        private void cmbCategoria_Validating(object sender, CancelEventArgs e)
        {
            if(this.cmbCategoria.SelectedIndex==0)
            {
                e.Cancel=true;
            }

            if(e.Cancel)
            {
                MessageBox.Show("Debe elegir una categoria para el producto.");
                this.cmbCategoria.SelectedIndex = 1;
            }

        }

        private void cmbCategoria_Validated(object sender, EventArgs e)
        {
            error.SetError(this.cmbCategoria, "");
        }
    }
}
