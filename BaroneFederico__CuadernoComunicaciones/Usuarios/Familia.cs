using Entidades.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entidades.Usuarios
{
    [Serializable]
    public class Familia : Usuario
    {
        #region Atributos
        private string representanteLegal;
        private string nombreAlumno;
        private int gradoAlumno;
        private int numeroLegajoAlumno;
        #endregion

        #region Constructores
        [JsonConstructor]
        public Familia() : base(0, "", "", "", Rol.UsuarioFinal)
        {
            this.representanteLegal = null;
            this.nombreAlumno = null;
            this.gradoAlumno = 0;
            this.numeroLegajoAlumno = 0;

        }
        public Familia(int numLegajo, string nombre, string dirCorreo, string clave) : base(numLegajo, nombre, 
                                                                           dirCorreo, clave, Rol.UsuarioFinal)
        {
                
        }

        public Familia(int numLegajo, string nombre, string dirCorreo, string clave,
                                        string representanteLegal, string nombreAlumno, 
                                        int gradoAlumno, int legajoAlumno ) : this(numLegajo, 
                                                                       nombre, dirCorreo, clave)
                                                                               
        {
            this.representanteLegal = representanteLegal;
            this.nombreAlumno = nombreAlumno;
            this.gradoAlumno = gradoAlumno;
            this.numeroLegajoAlumno = legajoAlumno;

        }
        #endregion

        #region Propiedades
        public string RepresentanteLegal { get => representanteLegal; set => representanteLegal = value; }
        public string NombreAlumno { get => nombreAlumno; set => nombreAlumno = value; }
        public int GradoAlumno { get => gradoAlumno; set => gradoAlumno = value; }
        public int NumeroLegajoAlumno { get => numeroLegajoAlumno; set => numeroLegajoAlumno = value; }
        #endregion

        #region Metodos
        public override string ToString()
        {
            return $"{base.ToString()} {this.representanteLegal} {this.nombreAlumno} {this.gradoAlumno} {this.numeroLegajoAlumno}";
        }

        //public static bool operator ==(string destinatarioNombre, Familia familia)
        //{
        //    return familia.Nombre == destinatarioNombre;
        //}

        //public static bool operator !=(string destinatarioNombre, Familia familia)
        //{
        //    return !(familia.Nombre == destinatarioNombre);
        //}
        #endregion

    }
}
