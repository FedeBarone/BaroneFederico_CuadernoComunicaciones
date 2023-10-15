using Entidades.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Comunicacion
{
    public class Mensaje
    {
        public Usuario Remitente { get; private set; }
        public Usuario Destinatario { get; private set; }
        public string Contenido{ get; private set; }
        public DateTime FechaEnvio { get; private set; }

        public Mensaje(Usuario remitente, Usuario destinatario, string contenido)
        {
            Remitente = remitente;
            Destinatario = destinatario;
            Contenido = contenido;
            FechaEnvio = DateTime.Now;
        }

    }
}
