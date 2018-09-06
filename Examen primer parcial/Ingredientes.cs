using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_primer_parcial
{
    class Ingrediente
    {
         private string Nombre { get; set; }
         private string Identificador { get; set; }

        private Ingrediente ()
        {
            Nombre = "Nuevo Ingrediente";
            Identificador = "0";
        }
        private Ingrediente (string nombre, string identificador)
        {
            Nombre = nombre;
            Identificador = identificador;
        }
    }

}
