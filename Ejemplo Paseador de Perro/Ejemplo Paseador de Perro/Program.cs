using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Paseador_de_Perro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPaseadorDePerros oHumano = new PaseadorDePerroHumano();
            IPaseadorDePerros oRobot = new PaseadorDePerroRobot();

            Perrera oPaseador = new Perrera(oHumano);
            oPaseador.Pasear();

            Console.WriteLine("------------------------------------");

            oPaseador = new Perrera(oRobot);
            oPaseador.Pasear();

            Console.WriteLine("------------------------------------");
        }
    }
}
