﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jueves_30___POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto MiAuto = new Auto("Renault", "Duster", "Rojo");
            Console.WriteLine("Los datos de mi coche son:");
            Console.WriteLine("	Marca: {0}", MiAuto.Marca);
            Console.WriteLine("	Modelo: {0}", MiAuto.Modelo);
            Console.WriteLine("	Color: {0}", MiAuto.Color);
            Console.WriteLine();

            MiAuto.Acelerar(100);
            Console.WriteLine("La velocidad actual es de {0} km/h \n", MiAuto.Velocidad);

            MiAuto.Frenar(120);
            Console.WriteLine("La velocidad actual es de {0} km/h \n", MiAuto.Velocidad);

            MiAuto.Girar(90);

            MiAuto.Estacionar();
            Console.WriteLine("La velocidad actual es de {0} km/h \n", MiAuto.Velocidad);

            Console.ReadKey();

        }
    }

  
}
