using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Lab3, Ejercicio 7: Imprimir la suma de los números pares del 1 al 25.

namespace Lab_3_Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;

            for(int i = 1; i < 26; i++)
            {
                if (i % 2 == 0)
                {
                    suma += i;
                }
            }

            Console.WriteLine(suma);
            Console.ReadKey();
        }
    }
}
