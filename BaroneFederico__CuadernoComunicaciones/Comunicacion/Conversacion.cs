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
        public Usuario Usuario1 { get; private set; }
        public Usuario Usuario2 { get; private set; }
        public List<Mensaje> Mensajes { get; private set; }

        public Conversacion(Usuario usuario1, Usuario usuario2)
        {
            Usuario1 = usuario1;
            Usuario2 = usuario2;
            Mensajes = new List<Mensaje>();
        }

        public void EnviarMensaje(Usuario remitente, Usuario destinatario, string contenido)
        {
            Mensaje mensaje = new Mensaje(remitente, destinatario, contenido);
            Mensajes.Add(mensaje);
        }
    }
}
