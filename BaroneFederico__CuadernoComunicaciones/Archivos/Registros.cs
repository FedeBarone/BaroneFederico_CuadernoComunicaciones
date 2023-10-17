using Entidades.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades.Archivos
{
    public static class Registros
    {
        #region Atributos
        public static List<Usuario> RegistroUsuarios;
        public static List<Familia> familias;
        #endregion

        #region Constructor
        static Registros()
        {
            RegistroUsuarios = new List<Usuario>();
            familias = new List<Familia>();
            HardCodearPreceptoras();

        }
        #endregion

        #region Propiedades
        public static List<Usuario> RegistroUsuarios1 { get => RegistroUsuarios; set => RegistroUsuarios = value; }
        #endregion

        #region Metodos
        private static void HardCodearPreceptoras()
        {
            RegistroUsuarios.Add(new Preceptora( 3, "Romina", "Romina5", "rt"));
            RegistroUsuarios.Add(new Preceptora(4, "Marcela", "Marcel2", "Ml"));
        }

        public static Usuario ObtenerUsuarioValido(string usuario, string clave)
        {
            //Familia familias = leerJson();
            //foreach (Usuario Usuario in familias)
            //{
            //    if(Usuario.ComprobarUsuario(usuario, clave))
            //        return Usuario;
            //}
            //return null;

            foreach (Usuario Usuario in RegistroUsuarios)
            {
                if (Usuario.ComprobarUsuario(usuario, clave))
                    return Usuario;
            }
            return null;

        }
        #endregion
    }
    
}
