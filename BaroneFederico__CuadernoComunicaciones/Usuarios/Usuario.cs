namespace Entidades.Usuarios
{
    public abstract class Usuario
    {
        private string nombre;
        private int id;
        private string usuario;
        private string clave;

        protected Usuario(string nombre, int id, string usuario, string clave)
        {
            this.nombre = nombre;
            this.id = id;
            this.usuario = usuario;
            this.clave = clave;
        }
    }
}