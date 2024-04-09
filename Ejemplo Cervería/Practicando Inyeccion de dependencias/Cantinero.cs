using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicando_Inyeccion_de_dependencias
{
    internal class Cantinero
    {
        IBebida bebida;
        public Cantinero(IBebida _bebida)
        {
            this.bebida = _bebida;
        }
        public void Preparar()
        {
            this.bebida.Preparar();
        }
    }
}
