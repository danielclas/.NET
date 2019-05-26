using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_For_Lab_3_Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma=0;

            for(int i = 1; i < 11; i++)
            {
                if (i % 2 != 0)
                {
                    suma += i;
                }
            }

            Console.WriteLine(suma);
            Console.ReadKey();
        }
    }
}
