using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Paseador_de_Perro
{
    public class Perrera
    {
        public IPaseadorDePerros _paseador { get; set; }
        public Perrera(IPaseadorDePerros paseador)
        {
            _paseador = paseador;
        }

        public void Pasear()
        {
            this._paseador.PasearPerro();
        }
    }
}
