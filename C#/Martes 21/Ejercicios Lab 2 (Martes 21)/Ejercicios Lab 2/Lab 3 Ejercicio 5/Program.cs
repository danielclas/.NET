using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Imprimir los números del 1 al 30 sin imprimir
números entre el 10 y el 20 uno abajo del otro
 */
namespace Lab_3_Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i <= 30; i++)
            {
                if(i<11 || i > 19)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();

        }
    }
}
