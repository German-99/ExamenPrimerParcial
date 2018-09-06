using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_primer_parcial
{
    class Platillo
    {
       private string Identificador { get; set; }
        private string Nombre { get; set; }
        private string Descripcion { get; set; }
        private float _Precio;
        private float Precio
        {
            get
            {
                _Precio = 50;
                return _Precio;
            }
            set
            {
                if(_Precio < 50)
                {
                    _Precio = 50;
                }
            }
        }
        List<Platillo> platillos = new List<Platillo>();
    }
}
