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
            string privilegios = txtPuesto.Text;

            if(Comercio.validarUsuario(usuario,pass))
            {
                MessageBox.Show("Acceso correcto");
                this.Hide();

                if (privilegios!="Administrador")
                {
                    MenuPrincipal formMenu = new MenuPrincipal();
                    formMenu.gestionDelNegocioToolStripMenuItem.Enabled = false;
                    formMenu.Show();

                }
                else
                {
                    MenuPrincipal formMenu = new MenuPrincipal();
                    formMenu.Show();
                }
                

            }
            else
            {
                MessageBox.Show("Acceso fallido");
            }

        }

        private void UserPass_Load(object sender, EventArgs e)
        {

        }
    }
}
