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
        public NuevoCliente()
        {
            InitializeComponent();
        }

        private void NuevoCliente_Load(object sender, EventArgs e)
        {
       
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre;
            string apellido;
            int dni;

            if(this.textBox1.TextLength>0 && textBox2.TextLength>0 && int.TryParse(this.textBox3.Text,out dni))
            {
                nombre = this.textBox1.Text;
                apellido = this.textBox2.Text;

                nuevoCliente = new Cliente(nombre, apellido, dni);
                Comercio.AgregarCliente(nuevoCliente);
                MenuPrincipal menu = new MenuPrincipal();
                this.Close();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Algun valor es invalido, reeingrese los datos.");
            }
            
        }
    }
}
