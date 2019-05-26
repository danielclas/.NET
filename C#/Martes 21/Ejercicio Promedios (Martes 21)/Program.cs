using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Promedios
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota1, nota2, nota3;
            const int aprobado = 4, promocionado = 7;
            float promedio;

            Console.Write("Ingrese nota 1: ");
            nota1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese nota 2: ");
            nota2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese nota 3: ");
            nota3 = int.Parse(Console.ReadLine());

            promedio = (float)(nota1 + nota2 + nota3) / 3;
            Console.WriteLine("Promedio: {0:N2}", promedio);

            if (promedio >= promocionado)
            {
                Console.WriteLine("\nPromocionado!");
            }
            else
            {

                if (promedio <= aprobado)
                {
                    Console.WriteLine("No aprobado");
                }
                else
                {
                    Console.Write("Aprobado");
                }

            }

            Console.ReadKey();

        }
    }
}
