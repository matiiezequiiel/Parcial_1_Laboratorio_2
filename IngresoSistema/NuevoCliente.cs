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
    public partial class NuevoCliente : Form
    {
        Cliente nuevoCliente;
        ErrorProvider error = new ErrorProvider();
        MenuPrincipal auxMenu;

        public NuevoCliente(MenuPrincipal m)
        {
            InitializeComponent();
            auxMenu = m;
        }

   
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre;
            string apellido;
            int dni;

            if(this.txtNombre.TextLength>0 && txtApellido.TextLength>0 && int.TryParse(this.txtDNI.Text,out dni))
            {
                nombre = this.txtNombre.Text;
                apellido = this.txtApellido.Text;

                nuevoCliente = new Cliente(nombre, apellido, dni);
                if (Comercio.AgregarCliente(nuevoCliente))
                {
                    auxMenu.CargarListaCliente();
                    MessageBox.Show("Cliente agregado correctamente.");

                }
                else
                {
                    MessageBox.Show("Cliente ya existe.");

                }

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
            this.txtApellido.Text = "";
            this.txtDNI.Text = "";

        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            for (int i = 0; i < txtNombre.TextLength; i++)
            {
                if (char.IsDigit(this.txtNombre.Text[i]))
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

        private void txtApellido_Validating(object sender, CancelEventArgs e)
        {
            for (int i = 0; i < txtApellido.TextLength; i++)
            {
                if (char.IsDigit(this.txtApellido.Text[i]))
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

        private void txtApellido_Validated(object sender, EventArgs e)
        {
            error.SetError(this.txtApellido, "");
        }

        private void txtDNI_Validating(object sender, CancelEventArgs e)
        {
            for (int i = 0; i < txtDNI.TextLength; i++)
            {
                if (!char.IsDigit(this.txtDNI.Text[i]))
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

        private void txtDNI_Validated(object sender, EventArgs e)
        {
            error.SetError(this.txtDNI, "");
        }

  

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            UserPass.formMenu.Show();
        }

      
    }
}
