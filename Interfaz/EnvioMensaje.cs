using Entidades.Comunicacion;
using Entidades.Usuarios;
using Interfaz.Herramientas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Interfaz
{
    public partial class frmEnvioMensaje : Form
    {
        #region Atributos
        private Preceptora remitente;
        private List<Familia> familias;
        #endregion

        #region Constructor
        public frmEnvioMensaje(Preceptora remitente, List<Familia> familias)
        {
            InitializeComponent();

            this.remitente = remitente;
            this.familias = familias;

            foreach (Familia familia in familias)
            {
                cboDestinatarios.Items.Add(familia.Nombre);
            }
        }
        #endregion

        #region Metodos
        private Familia EncontrarDestinatarioValidoEnFamilias(string destinatarioAux)
        {
            Familia destinatario = null;
            foreach (Familia familia in familias)
            {
                if (familia.Nombre == destinatarioAux)
                {
                    destinatario = familia;
                    break;
                }
            }
            return destinatario;

        }

        private Conversacion EncontrarDestinatarioConversacionValida(Familia destinatarioAux)
        {
            Conversacion conversacionEncontrada = null;

            foreach (Conversacion conversacion in remitente.Conversaciones)
            {
                if (conversacion.Familia == destinatarioAux)
                {
                    conversacionEncontrada = conversacion;
                    break;

                }
            }
            return conversacionEncontrada;

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string destinatarioNombre = cboDestinatarios.SelectedItem.ToString();
            string mensaje = txtTextoMensaje.Text;
            Familia destinatario = null;

            destinatario = EncontrarDestinatarioValidoEnFamilias(destinatarioNombre);

            if (destinatario != null)
            {
                Mensaje mensajeObj = new Mensaje(remitente, destinatario, mensaje);

                remitente.IniciarConversacion(destinatario);

                Conversacion conversacionEncontrada = null;

                foreach (Conversacion conversacion in remitente.Conversaciones)
                {
                    if (conversacion.Familia == destinatario)
                    {
                        conversacionEncontrada = conversacion;
                        break;

                    }
                }

                if (conversacionEncontrada != null)
                {
                    conversacionEncontrada.EnviarMensaje(remitente, destinatario, mensaje);
                    MessageBox.Show("Mensaje enviado con éxito.");
                }
                else
                {
                    MessageBox.Show("La conversación no fue encontrada.");
                }

                txtTextoMensaje.Clear();

            }
            else
            {
                MessageBox.Show("Destinatario no encontrado.");
            }
        }
        #endregion
    }
}

