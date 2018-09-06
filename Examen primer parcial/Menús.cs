using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_primer_parcial
{
    class Menú
    {
        private string Nombre { get; set; }
        private string Identificador { get; set; }
        private int Horainicio { get; set; }
        private int Horafin { get; set; }

        private Menú()
        {
            Nombre = "Nuevo Menú";
        }
        List<Menú> Menús = new List<Menú>();
    }
}
