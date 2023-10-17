using Entidades.Comunicacion;
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
    public partial class frmMensajesRecibidos : Form
    {
        #region Atributos
        private Preceptora preceptora;
        #endregion

        #region Constructor
        public frmMensajesRecibidos(Preceptora preceptora)
        {
            InitializeComponent();
            this.Preceptora = preceptora;

            List<Mensaje> mensajesRecibidos = this.Preceptora.ObtenerMensajesRecibidos();
            MostrarMensajesRecibidos(mensajesRecibidos);
        }
        #endregion

        #region Propiedades
        public Preceptora Preceptora { get => preceptora; set => preceptora = value; }
        #endregion

        #region Metodos
        private void frmMensajesRecibidos_Load(object sender, EventArgs e)
        {
            List<Mensaje> mensajesRecibidos = this.Preceptora.ObtenerMensajesRecibidos();
            MostrarMensajesRecibidos(mensajesRecibidos);

        }

        private void MostrarMensajesRecibidos(List<Mensaje> mensajesRecibidos)
        {
            lstMensajesRecibidos.Items.Clear();

            foreach (Mensaje mensaje in mensajesRecibidos)
            {
                lstMensajesRecibidos.Items.Add($"{mensaje.Remitente.Nombre}: {mensaje.Contenido}");
            }
        }
        #endregion
    }
}
