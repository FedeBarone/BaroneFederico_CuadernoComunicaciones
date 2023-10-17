using Entidades.Enumerados;

namespace Entidades.Usuarios
{
    public abstract class Usuario
    {
        #region Atributos
        private int numLegajo;
        private string nombre;
        private string dirCorreo;
        private string clave;
        private Rol rol;
        #endregion

        #region Constructores
        protected Usuario(int numLegajo, string nombre, string dirCorreo, string clave, Rol rol)
        {
            this.nombre = nombre;
            this.numLegajo = numLegajo;
            this.dirCorreo = dirCorreo;
            this.clave = clave;
            this.rol = rol;
        }
        #endregion

        #region Propiedades
        public int NumLegajo { get => numLegajo; set => numLegajo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string DirCorreo { get => dirCorreo; set => dirCorreo = value; }
        public string Clave { get => clave; set => clave = value; }
        public Rol Rol { get => rol; set => rol = value; }
        #endregion

        #region Metodos
        public bool ComprobarUsuario(string dirCorreo, string clave)
        {
            return this.dirCorreo == dirCorreo && this.clave == clave;
        }

        public override string ToString()
        {
            return $"{this.numLegajo} {this.nombre} {this.dirCorreo} {this.clave}";
        }
        #endregion
    }
}