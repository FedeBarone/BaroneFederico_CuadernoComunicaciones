using BaroneFederico__CuadernoComunicaciones;
using Microsoft.VisualBasic.Logging;
using System.Drawing;

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
            //esto tiene que venir del archivo para validar
            if (usuario == "Federico" && clave == "1313")
            {
                //MessageBox.Show("Usuario logeado con exito", "Log in", MessageBoxButtons.OK, 
                //MessageBoxIcon.Information);
                VentanaEmergente ve = new VentanaEmergente("Log in ", "Usuario logeado con exito");
                ve.ShowDialog();
                if(ve.DialogResult == DialogResult.OK)
                {
                    MenuPrincipal mp = new MenuPrincipal();
                    mp.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Usuario/Clave incorrecta", "Log in", MessageBoxButtons.OK,
                                                                      MessageBoxIcon.Error);

            }
        }
    }
}