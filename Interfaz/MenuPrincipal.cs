using Entidades.Enumerados;
using Entidades.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
        frmAlta formulario;
        List<Familia> nombresIngresados;
        public MenuPrincipal(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            this.formulario = null;

            nombresIngresados = new List<Familia>();

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
            this.picInicio.Visible = false;

            DialogResult resultado = this.formulario.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                nombresIngresados.Add(this.formulario.NombrePadreMadreOTutor);

                StringBuilder sb = new StringBuilder();
                foreach (Familia nombre in nombresIngresados)
                {
                    sb.AppendLine(nombre.ToString());
                }
                MessageBox.Show(sb.ToString());
            }
            else
            {
                MessageBox.Show($"cancelado");
            }


        }

        private void iNICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.formulario != null)
            {
                this.formulario.Close();
            }

            this.picInicio.Visible = true;
        }

        private void verUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VistaUsuarios vistaUsuarios = new VistaUsuarios(nombresIngresados);
            vistaUsuarios.MdiParent = this;
            vistaUsuarios.Show();
            this.picInicio.Visible = false;

        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }
    }
}
