using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
    Ejercicio 1: Dado el siguiente código:
    int nro1 = 100, nro2 = 500, nro3 = 250;
    Informar cuál de los tres números es mayor.
 */

namespace Ejercicios_Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro1 = 1000, nro2 = 5000, nro3 = 25000;

            
            if (nro2 > nro1 && nro2>nro3)
            {
                 Console.WriteLine("El mayor es {0}", nro2);
            }
            else
            {
                if (nro3 > nro1)
                {                   
                    Console.Write("El mayor es {0}", nro3);

                }
                else
                {
                    Console.Write("El mayor es {0}", nro1);
                }
            }

            Console.ReadKey();


        }
    }
}
