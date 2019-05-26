using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Lab3, Ejercicio 6: Imprimir la suma de los números del 1 al 10.
namespace Lab_3_Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma=0;

            for(int i=1; i < 11; i++)
            {
                suma += i;
            }

            Console.WriteLine(suma);
            Console.ReadKey();

        }
    }
}
