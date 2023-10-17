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
    public partial class VistaUsuarios : Form
    {
        #region Atributos 
        List<Familia> familias;
        #endregion

        #region Constructor
        public VistaUsuarios(List<Familia> familias)
        {
            InitializeComponent();
            this.familias = familias;
        }
        #endregion

        #region Metodos

        private void VistaUsuarios_Load(object sender, EventArgs e)
        {
            this.dtgVistaUsuarios.DataSource = null;
            this.dtgVistaUsuarios.DataSource = this.familias;

        }
        #endregion
    }
}
