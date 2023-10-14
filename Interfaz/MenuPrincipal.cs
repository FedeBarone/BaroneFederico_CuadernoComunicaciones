using Entidades.Enumerados;
using Entidades.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class MenuPrincipal : Form
    {
        private Usuario usuario;
        Form formulario;
        public MenuPrincipal(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            ConfigurarInterfazSegunRol();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ConfigurarInterfazSegunRol()
        {
            if (usuario != null)
            {
                if (usuario.Rol == Rol.Administrador)
                {
                    nOTASToolStripMenuItem.Visible = false;

                }
                //else if (usuario.Rol == Rol.UsuarioFinal)
                //{
                //    iNFORMESToolStripMenuItem.Visible = false;
                //    eVENTOSToolStripMenuItem.Visible = false;

                //}
            }
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.formulario = new frmAlta();
            
            this.formulario.MdiParent = this;
            this.picInicio.Visible = false;

            this.formulario.Show();

        }

        private void iNICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.formulario.Close();
            this.picInicio.Visible = true;
        }
    }
}
