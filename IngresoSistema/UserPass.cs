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
    public partial class UserPass : Form
    {
        public UserPass()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            string usuario=txtUsuario.Text;
            string pass=txtPass.Text;

            if(Comercio.validarUsuario(usuario,pass))
            {
                MessageBox.Show("Acceso correcto");
            }
            else
            {
                MessageBox.Show("Acceso fallido");
            }

        }

     
    }
}
