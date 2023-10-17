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
    public partial class frmModificacion : Form
    {
        #region Atributos
        #endregion

        #region Constructor
        public frmModificacion(Familia usuario)
        {
            InitializeComponent();
            txtNombreMod.Text = usuario.Nombre;
            txtDirCorreoMod.Text = usuario.DirCorreo;
            txtUsuarioClaveMod.Text = usuario.Clave;
            txtNombreAlumnoMod.Text = usuario.NombreAlumno;
            int.TryParse(txtGradoAlumnoMod.Text, out int gradoAlumnoNumMod);
            int gradoAlumnoMod = gradoAlumnoNumMod;
            int.TryParse(txtLegajoAlumnoMod.Text, out int legajoAlumnoNumMod);
            int numeroLegajoAlumnoMod = legajoAlumnoNumMod;

            UsuarioModificado = usuario;
        }
        #endregion

        #region Propiedades
        public Familia UsuarioModificado { get; private set; }
        #endregion

        #region Metodos
        private void frmModificacion_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardarMod_Click(object sender, EventArgs e)
        {
            string nombrePadreMadreOTutorMod = txtNombreMod.Text;
            string direccionCorreoMod = txtDirCorreoMod.Text;
            string claveMod = txtUsuarioClaveMod.Text;
            string nombreAlumnoMod = txtNombreAlumnoMod.Text;
            int.TryParse(txtGradoAlumnoMod.Text, out int gradoAlumnoNumMod);
            int gradoAlumnoMod = gradoAlumnoNumMod;
            int.TryParse(txtLegajoAlumnoMod.Text, out int legajoAlumnoNumMod);
            int numeroLegajoAlumnoMod = legajoAlumnoNumMod;

            UsuarioModificado.Nombre = nombrePadreMadreOTutorMod;
            UsuarioModificado.DirCorreo = direccionCorreoMod;
            UsuarioModificado.Clave = claveMod;
            UsuarioModificado.NombreAlumno = nombreAlumnoMod;
            UsuarioModificado.GradoAlumno = gradoAlumnoMod;
            UsuarioModificado.NumeroLegajoAlumno = numeroLegajoAlumnoMod;

            DialogResult = DialogResult.OK;
            Close();

        }

        private void btnCancelarMod_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();

        }
        #endregion
    }
}
