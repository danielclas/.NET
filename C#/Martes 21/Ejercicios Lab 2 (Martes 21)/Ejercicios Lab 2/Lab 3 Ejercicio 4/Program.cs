using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Lab3, Ejercicio 4: Imprimir los números del 1 al 10 sin imprimir
números 2,5 y 9 uno abajo del otro.     
*/
namespace Lab_3_Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i < 11; i++)
            {
                if(i!=2 && i!=5 && i != 9)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
