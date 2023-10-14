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
        Familia nombrePadreMadreOTutor;

        public Familia NombrePadreMadreOTutor { get => nombrePadreMadreOTutor; }

        public frmAlta()
        {
            InitializeComponent();
        }

        private void frmAlta_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtRelacionConAlumno_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombrePadreMadreOTutor = txtNombre.Text;
            string direccionCorreo = txtDirCorreo.Text;
            int.TryParse(txtNumeroCelular.Text, out int numCelular);
            int numeroCelular = numCelular;
            string relacionConAlumno = txtRelacionConAlumno.Text;
            string clave = txtUsuarioClave.Text;
            string nombreAlumno = txtNombreAlumno.Text;
            int.TryParse(txtGradoAlumno.Text, out int gradoAlumnoNum);
            int gradoAlumno = gradoAlumnoNum;
            int.TryParse(txtLegajoAlumno.Text, out int legajoAlumnoNum);
            int numeroLegajoAlumno = legajoAlumnoNum;

            Familia unaFamilia = new Familia(nombrePadreMadreOTutor, 1, direccionCorreo, clave, relacionConAlumno,
                                             nombreAlumno, gradoAlumno, numeroLegajoAlumno);
            this.nombrePadreMadreOTutor = unaFamilia;

            this.DialogResult = DialogResult.OK;
        }
     
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
    }
}
