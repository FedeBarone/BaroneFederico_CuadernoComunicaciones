using Entidades.Archivos;
using Entidades.Enumerados;
using Entidades.Usuarios;
using Interfaz.Herramientas;
using Microsoft.VisualBasic.Logging;
using System.Drawing;
using System.Windows.Forms;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Threading;

namespace Interfaz
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //Tengo que fijarme si debo guardar algo en un archivo o algo por el estilo antes de
            //que el usuario cierre
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = this.txtUsuario.Text;
            string clave = this.txtClave.Text;

            if (ValidacionDeCamposIniciales(usuario, clave))
            {
                Usuario user = Registros.ObtenerUsuarioValido(usuario, clave);

                if (user != null)
                {
                    VentanaEmergente ve = new VentanaEmergente("Log in ", "Usuario logeado con exito");
                    ve.ShowDialog();

                    if (ve.DialogResult == DialogResult.OK)
                    {
                        MenuPrincipal mp = new MenuPrincipal(user);
                        mp.Show();
                        this.Hide();

                    }

                }
            }
        }

        private bool ValidacionDeCamposIniciales(string usuario, string clave)
        {
            bool returnAux;
            if (Validador.CadenaEsInvalida(usuario) || Validador.CadenaEsInvalida(clave))
            {
                MessageBox.Show("Usuario/Clave incorrecta", "Log in", MessageBoxButtons.OK,
                                                                     MessageBoxIcon.Error);
                returnAux = false;
            }
            returnAux = true;
            return returnAux;
        }

    }
}