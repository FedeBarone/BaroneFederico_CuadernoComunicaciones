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
    public partial class frmBaja : Form
    {
        private List<Familia> usuariosDisponibles;

        public Familia UsuarioSeleccionado { get; private set; }
        public frmBaja(List<Familia> usuarios)
        {
            InitializeComponent();
            usuariosDisponibles = usuarios;
            lstBaja.DataSource = usuariosDisponibles;
            lstBaja.DisplayMember = "Nombre";
        }

        private void frmBaja_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            UsuarioSeleccionado = (Familia)lstBaja.SelectedItem;
            DialogResult = DialogResult.OK;
            Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();

        }
    }
}
