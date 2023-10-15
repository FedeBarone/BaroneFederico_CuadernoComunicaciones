using Entidades.Enumerados;

namespace Entidades.Usuarios
{
    public abstract class Usuario
    {
        private string nombre;
        private int id;
        private string user;
        private string clave;
        private Rol rol;

        protected Usuario(string nombre, int id, string usuario, string clave, Rol rol)
        {
            this.nombre = nombre;
            this.id = id;
            this.user = usuario;
            this.clave = clave;
            this.rol = rol;
        }

        public Rol Rol { get => rol; set => rol = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }
        public string User { get => user; set => user = value; }
        public string Clave { get => clave; set => clave = value; }

        public bool ComprobarUsuario(string usuario, string clave)
        {
            return this.user == usuario && this.clave == clave;
        }

        public override string ToString()
        {
            return $"{this.nombre} {this.id} {this.user} {this.clave}";
        }
    }
}