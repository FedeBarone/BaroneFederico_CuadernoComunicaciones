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
        #region Atributos
        private Usuario remitente;
        private Usuario destinatario;
        private string contenido;
        private DateTime fechaEnvio;
        #endregion

        #region Constructor
        public Mensaje(Usuario remitente, Usuario destinatario, string contenido)
        {
            this.remitente = remitente;
            this.destinatario = destinatario;
            this.contenido = contenido;
            this.fechaEnvio = DateTime.Now;
        }

        #endregion

        #region Propiedades
        public Usuario Remitente { get => remitente; }
        public Usuario Destinatario { get => destinatario;}
        public string Contenido { get => contenido;}
        public DateTime FechaEnvio { get => fechaEnvio;}
        #endregion

    }
}
