using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercitacion_Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];
            int aux;
            int suma = 0;
            float promedios;

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Ingrese un numero mayor a 5 en {0}: ", i);
                aux = int.Parse(Console.ReadLine());

                while (aux <= 5)
                {
                    Console.Write("Error. Ingrese un numero mayor a 5 en {0}: ", i);
                    aux = int.Parse(Console.ReadLine());
                }

                numeros[i] = aux;
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                suma += numeros[i];
            }

            promedios = (float)suma / numeros.Length;

            Console.WriteLine("Suma: {0}||  Promedios: {1}", suma, promedios);
            Console.ReadKey();



        }
    }
}
