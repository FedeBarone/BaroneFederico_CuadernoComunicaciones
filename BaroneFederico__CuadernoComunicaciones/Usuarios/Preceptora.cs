using Entidades.Archivos;
using Entidades.Comunicacion;
using Entidades.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades.Usuarios
{
    public class Preceptora : Usuario
    {
        public List<Conversacion> Conversaciones { get; private set; }
        public Preceptora(int numLegajo, string nombre, string dirCorreo, string clave) : base(numLegajo, nombre,
                                                                              dirCorreo, clave, Rol.Administrador)
        {
            Conversaciones = new List<Conversacion>();

        }

        public void DarAltaFamilia(string nombreRepresentanteLegal, string direccionCorreo,
                            string clave, string representanteLegal, string nombreAlumno,
                            int gradoAlumno, int numeroLegajoAlumno)
        {
            Familia unaFamilia = new Familia(1, nombreRepresentanteLegal, direccionCorreo, clave, representanteLegal,
                                             nombreAlumno, gradoAlumno, numeroLegajoAlumno);
            Registros.RegistroUsuarios.Add(unaFamilia);

        }

        public void IniciarConversacion(Familia familia)
        {
            Conversacion conversacion = new Conversacion(this, familia);
            Conversaciones.Add(conversacion);
        }

        public List<Mensaje> ObtenerMensajesRecibidos()
        {
            List<Mensaje> mensajesRecibidos = new List<Mensaje>();

            foreach (Conversacion conversacion in Conversaciones)
            {
                foreach (Mensaje mensaje in conversacion.Mensajes)
                {
                    if (mensaje.Destinatario == this)
                    {
                        mensajesRecibidos.Add(mensaje);
                    }
                }
            }
            return mensajesRecibidos;
        }
    }
}
