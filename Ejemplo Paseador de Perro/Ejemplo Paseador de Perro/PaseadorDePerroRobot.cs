using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Paseador_de_Perro
{
    public class PaseadorDePerroRobot : IPaseadorDePerros
    {
        void IPaseadorDePerros.PasearPerro()
        {
            Console.WriteLine("Soy un robot paseando a un perro.");
        }
    }
}
