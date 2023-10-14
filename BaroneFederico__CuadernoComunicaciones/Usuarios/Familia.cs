using Entidades.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Usuarios
{
    public class Familia : Usuario//tengo que ver si el nombre "familia" es el correcto
    {
        private string relacionConAlumno;
        private string nombreAlumno;
        private int gradoAlumno;
        private int numeroLegajoAlumno;
        public Familia(string nombre, int id, string usuario, string clave) : base(nombre, id, usuario, 
                                                                                    clave, Rol.UsuarioFinal)
        {
       
        }

        public Familia(string nombre, int id, string usuario, string clave, 
                                        string relacionConAlumno, string nombreAlumno, 
                                        int gradoAlumno, int legajoAlumno ) : this(nombre, id, usuario, clave)
                                                                               
        {
            this.relacionConAlumno = relacionConAlumno;
            this.nombreAlumno = nombreAlumno;
            this.gradoAlumno = gradoAlumno;
            this.numeroLegajoAlumno = legajoAlumno;

        }

        public override string ToString()
        {
            return $"{base.ToString()} {this.relacionConAlumno} {this.nombreAlumno} {this.gradoAlumno} {this.numeroLegajoAlumno}";
        }

        public string RelacionConAlumno { get => relacionConAlumno; set => relacionConAlumno = value; }
        public string NombreAlumno { get => nombreAlumno; set => nombreAlumno = value; }
        public int GradoAlumno { get => gradoAlumno; set => gradoAlumno = value; }
        public int NumeroLegajoAlumno { get => numeroLegajoAlumno; set => numeroLegajoAlumno = value; }
    }
}
