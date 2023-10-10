using Entidades.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Usuarios
{
    public class Familia : Usuario
    {
        Rol rol;

        public Familia(string nombre, int id, string usuario, string clave) : base(nombre, id, usuario, clave)
        {
            this.rol = Rol.UsuarioFinal;
        }
    }
}
