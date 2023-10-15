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
    public partial class frmSeleccionModificacion : Form
    {
        public Familia UsuarioSeleccionado { get; private set; }
        public frmSeleccionModificacion(List<Familia> usuarios)
        {
            InitializeComponent();

            lstSeleccionModificacion.DataSource = usuarios;
            lstSeleccionModificacion.DisplayMember = "Nombre";
        }

        private void btnAceptarSeleccionModificacion_Click(object sender, EventArgs e)
        {
            UsuarioSeleccionado = (Familia)lstSeleccionModificacion.SelectedItem;

            DialogResult = DialogResult.OK;
            Close();

        }

        private void btnCancelarSeleccionModificacion_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();

        }
    }
}
