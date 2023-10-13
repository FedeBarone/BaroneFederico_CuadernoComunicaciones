using Entidades.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Archivos
{
    //TIENEN QUE SER ARCHIVOS, PERO HARDCODEO PARA PROBAR. HAY QUE MODIFICAR
    public static class Registros
    {
        static List<Usuario> RegistroUsuarios;

        static Registros()
        {
            RegistroUsuarios = new List<Usuario>();
            HardCodeUsuarios();

        }

        private static void HardCodeUsuarios()
        {
            RegistroUsuarios.Add(new Familia("Ryu", 1, "Ryu23", "ninja"));
            RegistroUsuarios.Add(new Familia("Jin", 2, "Jin45", "tekken"));
            RegistroUsuarios.Add(new Preceptora("Romina", 3, "Romina5", "rt"));
            RegistroUsuarios.Add(new Preceptora("Marcel", 4, "Marcel2", "Ml"));
        }

        public static Usuario ObtenerUsuarioValido(string usuario, string clave)
        {
            foreach (Usuario Usuario in RegistroUsuarios)
            {
                if(Usuario.ComprobarUsuario(usuario, clave))
                    return Usuario;
            }
            return null;

        }
    }
}
