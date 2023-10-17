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
    public partial class frmAlta : Form
    {
        #region Atributos
        Familia familia;
        #endregion

        #region Constructor
        public frmAlta()
        {
            InitializeComponent();
        }
        #endregion

        #region Propiedades
        public Familia Familia { get => familia; }
        #endregion

        #region Metodos
        private void frmAlta_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombreRepresentanteLegal = txtNombre.Text;
            string direccionCorreo = txtDirCorreo.Text;
            string representanteLegal = txtRelacionConAlumno.Text;
            string clave = txtUsuarioClave.Text;
            string nombreAlumno = txtNombreAlumno.Text;
            int.TryParse(txtGradoAlumno.Text, out int gradoAlumnoNum);
            int gradoAlumno = gradoAlumnoNum;
            int.TryParse(txtLegajoAlumno.Text, out int legajoAlumnoNum);
            int numeroLegajoAlumno = legajoAlumnoNum;

            Familia unaFamilia = new Familia(1, nombreRepresentanteLegal, direccionCorreo, clave, representanteLegal,
                                             nombreAlumno, gradoAlumno, numeroLegajoAlumno);
            this.familia = unaFamilia;

            this.DialogResult = DialogResult.OK;
        }
     
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
        #endregion
    }
}
