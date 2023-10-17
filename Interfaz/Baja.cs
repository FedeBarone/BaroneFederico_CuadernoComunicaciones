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
        #region Atributos
        private Familia usuarioSeleccionado;
        private List<Familia> usuariosDisponibles;
        #endregion

        #region Constructor
        public frmBaja(List<Familia> usuarios)
        {
            InitializeComponent();
            usuariosDisponibles = usuarios;
            lstBaja.DataSource = usuariosDisponibles;
            lstBaja.DisplayMember = "Nombre";
        }
        #endregion

        #region Propiedades
        public Familia UsuarioSeleccionado { get => usuarioSeleccionado;}
        #endregion

        #region Metodos
        private void frmBaja_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            usuarioSeleccionado = (Familia)lstBaja.SelectedItem;
            DialogResult = DialogResult.OK;
            Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();

        }
        #endregion
    }
}
