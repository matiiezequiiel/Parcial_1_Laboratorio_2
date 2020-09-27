using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace IngresoSistema
{ 
    
    public partial class FormIngresoSistema : Form
    {
        Empleado miEmpleado=new Empleado("Juan","Pablo",396757,new DateTime(),"Cajero",456);
        List<Empleado> auxLista=new List<Empleado>();
        public FormIngresoSistema()
        {
            InitializeComponent();
        }

        private void FormIngresoSistema_Load(object sender, EventArgs e)
        {
            miEmpleado=Comercio.AgregarEmpleado(miEmpleado);
            

            for (int i = 0; i < 5; i++)
            {
                this.listBox1.Items.Add(miEmpleado.NombreEmpleado);
            }
        }

    
    }
}
