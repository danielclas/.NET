using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Lab 3, Ejercicio 2: Imprimir los números del 1 al 10 salteando de
a 2 uno abajo del otro.*/
namespace Lab_3_Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i<10; i=i+2)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();

        }
    }
}
