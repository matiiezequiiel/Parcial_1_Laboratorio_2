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
    
 
    public partial class ComprasPorEmpleado : Form
    {
        List<Empleado> auxEmpleado = new List<Empleado>();
        List<Venta> listaVentas = new List<Venta>();

        public ComprasPorEmpleado()
        {
            InitializeComponent();
        }

        private void ComprasPorEmpleado_Load(object sender, EventArgs e)
        {
            CargarListaEmpleados();
            CargarListaVentas();
        }

        private void CargarListaEmpleados()
        {

            auxEmpleado = Comercio.RetornarListaEmpleados();


            foreach (Empleado item in auxEmpleado)
            {
                ListViewItem aux = new ListViewItem(item.NombrePersona);
                aux.SubItems.Add(item.ApellidoPersona);
                lsvEmpleados.Items.Add(aux);

            }

        }

        private void CargarListaVentas()
        {
            listaVentas = Comercio.RetornarListaVentas();
        }

        private void lsvEmpleados_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string nombreEmpleado = "";
            string apellidoEmpleado = "";
            
            CheckBoxIndicesEmpleados(e.Index);


            if (e.Index < lsvEmpleados.Items.Count)
            {
                foreach (ListViewItem auxLista in lsvEmpleados.Items)
                {
                    if (e.Index == auxLista.Index)
                    {
                        nombreEmpleado = auxLista.SubItems[0].Text;
                        apellidoEmpleado = auxLista.SubItems[1].Text;
                        break;

                    }
                }

            }

           
            foreach (Empleado item in auxEmpleado)
            {
                if(nombreEmpleado == item.NombrePersona && apellidoEmpleado == item.ApellidoPersona)
                {
                    CargarTicketEmpledo(item);
                    break;
                }
            }
            

        }

        private void CargarTicketEmpledo(Empleado auxEmpleado)
        {
            lsvTicketsVendidos.Items.Clear();

            foreach (int item in auxEmpleado.TicketsEmpleado)
            {
                if(item!=0)
                {
                    ListViewItem aux = new ListViewItem(item.ToString());
                    lsvTicketsVendidos.Items.Add(aux);

                }
                
            }
            
        }  
        private void CargarProductosDeTicket(Venta auxProducto)
        {
            lsvListaCompra.Items.Clear();

            foreach (Producto item in auxProducto.ListaCompra)
            {
                ListViewItem aux = new ListViewItem(item.nombreProducto);
                lsvListaCompra.Items.Add(aux);
            }
            
        }

        private void CheckBoxIndicesEmpleados(int indice)
        {

            foreach (ListViewItem auxLista in lsvEmpleados.Items)
            {
                if (indice != auxLista.Index)
                {
                    auxLista.Checked = false;
                }

            }
        }
        private void CheckBoxIndicesTicket(int indice)
        {

            foreach (ListViewItem auxLista in lsvTicketsVendidos.Items)
            {
                if (indice != auxLista.Index)
                {
                    auxLista.Checked = false;
                }

            }
        }

        private void lsvTicketsVendidos_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            string nroTicketString = "";
            int nroTicket=0;
            

            CheckBoxIndicesTicket(e.Index);


            if (e.Index < lsvTicketsVendidos.Items.Count)
            {
                foreach (ListViewItem auxLista in lsvTicketsVendidos.Items)
                {
                    if (e.Index == auxLista.Index)
                    {
                        nroTicketString = auxLista.SubItems[0].Text;
                        int.TryParse(nroTicketString, out nroTicket);
                        break;

                    }
                }

            }


            foreach (Venta item in listaVentas)
            {
                if (nroTicket == item.nroTicket)
                {
                    CargarProductosDeTicket(item);
                    break;
                }
            }

        }

        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
            this.Close();
            UserPass.formMenu.Show();

        }
    }
}
