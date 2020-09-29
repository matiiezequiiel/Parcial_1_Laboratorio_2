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
        public string nombreUsuario;

        public FormIngresoSistema()
        {
            InitializeComponent();
        }

        private void FormIngresoSistema_Load(object sender, EventArgs e)
        {
           
            Comercio.CargarHardcodeo();
            dtgLogin.DataSource= Comercio.RetornarListaEmpleados();
         
        }

        private void dtgLogin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            

            if (e.RowIndex >= 0)
            {
                DataGridViewRow linea = this.dtgLogin.Rows[e.RowIndex];
                nombreUsuario = linea.Cells["nombreEmpleado"].Value.ToString();
            }

            this.Hide();

            UserPass formInicioSesion = new UserPass();
            formInicioSesion.txtUsuario.Text = nombreUsuario;
            formInicioSesion.Show();



        }

    }
}
