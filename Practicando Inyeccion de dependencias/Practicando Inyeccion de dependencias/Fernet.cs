﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicando_Inyeccion_de_dependencias
{
    internal class Fernet : IBebida
    {
        public void Preparar()
        {
            Console.WriteLine("Preparar un fernet");
        }
    }
}
