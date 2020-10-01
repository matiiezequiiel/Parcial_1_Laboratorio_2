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

        private void lsvEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lsvEmpleados_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string nombreEmpleado = "";
            string apellidoEmpleado = "";
            
            CheckBoxIndices(e.Index);


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
                ListViewItem aux = new ListViewItem(item.ToString());
                lsvTicketsVendidos.Items.Add(aux);
            }
            
        }

        private void CheckBoxIndices(int indice)
        {

            foreach (ListViewItem auxLista in lsvEmpleados.Items)
            {
                if (indice != auxLista.Index)
                {
                    auxLista.Checked = false;
                }

            }
        }

    }
}
