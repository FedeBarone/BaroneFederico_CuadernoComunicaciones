using Entidades.Enumerados;

namespace Entidades.Usuarios
{
    public abstract class Usuario
    {   //EN PROCESO...
        private string nombre;
        private int id;
        private string usuario;
        private string clave;
        private Rol rol;

        protected Usuario(string nombre, int id, string usuario, string clave, Rol rol)
        {
            this.nombre = nombre;
            this.id = id;
            this.usuario = usuario;
            this.clave = clave;
            this.rol = rol;
        }

        public Rol Rol { get => rol; set => rol = value; }

        public bool ComprobarUsuario(string usuario, string clave)
        {
            return this.usuario == usuario && this.clave == clave;
        }
    }
}