using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicando_Inyeccion_de_dependencias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBebida oPiñaColada = new PiñaColada();
            IBebida oFernet = new Fernet();

            Cantinero oCantinero = new Cantinero(oFernet);
            oCantinero.Preparar();
        }
    }
}
