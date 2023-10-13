using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz.Herramientas
{
    public static class Validador
    {
        public static bool CadenaEsInvalida(string dato)
        {
            return string.IsNullOrEmpty(dato) || string.IsNullOrWhiteSpace(dato);
        }
    }
}
