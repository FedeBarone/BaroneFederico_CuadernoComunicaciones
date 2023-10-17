using Entidades.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Comunicacion
{
    public class Conversacion
    {
        #region Atributos
        private Usuario preceptora;
        private Usuario familia;
        private List<Mensaje> mensajes;
        #endregion

        #region Constructor
        public Conversacion(Usuario preceptora, Usuario familia)
        {
            this.preceptora = preceptora;
            this.familia = familia;
            this.mensajes = new List<Mensaje>();
        }
        #endregion

        #region Propiedades
        public Usuario Preceptora { get => preceptora; set => preceptora = value; }
        public Usuario Familia { get => familia; set => familia = value; }
        public List<Mensaje> Mensajes { get => mensajes; set => mensajes = value; }
        #endregion

        #region Metodos
        public void EnviarMensaje(Usuario remitente, Usuario destinatario, string contenido)
        {
            Mensaje mensaje = new Mensaje(remitente, destinatario, contenido);
            Mensajes.Add(mensaje);
        }
        #endregion
    }
}
