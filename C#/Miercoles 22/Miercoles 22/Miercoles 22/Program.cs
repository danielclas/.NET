using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miercoles_22
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ejemplo Do While

            int a=0;

            do {

                Console.WriteLine(a);
                a++;

            } while (a <= 10);

            Console.Write("Fin de do while\n");            
            Console.WriteLine(a);
            Console.ReadKey();*/

            /*Ejemplo While Anidado

            int externo = 1, interno = 1;

            while (externo <= 4)
            {
                while (interno <= 4)
                {
                    Console.WriteLine("Externo: "+externo+"Interno: "+interno);
                    interno++;
                }
                interno = 1;
                Console.WriteLine(" ");
                externo++;
            }

            Console.ReadKey();*/

            /*Ejemplo For

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();*/

            /*Ejemplo For 2

            int i;

            for (i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Valor de I afuera "+i);
            Console.ReadKey();*/

            /*Ejemplo For 3

            for(int i = 1; i <= 4; i++)
            {
                for(int j = 1; j <= 4; j++)
                {
                    Console.WriteLine("I {0} J {1}", i, j);
                }
            }

            Console.ReadKey();*/

            /*Ejemplo For 4

            for(int a=1, b = 10; a <= b; a++, b--, Console.WriteLine("---"))
            {
                Console.WriteLine("A tiene {0} B tiene {1}", a, b); 
            }

            Console.ReadKey();*/

            /*Vectores

            int[] numeros = new int[4];
            int i;
            string[] nombres = new string[4];

            nombres[0]="Carlos";
            nombres[1]="Juan";
            nombres[2]="Jose";
            nombres[3]="Javier";

            numeros[0]=1;
            numeros[1]=2;
            numeros[2]=3;
            numeros[3]=4;

            Console.WriteLine("Ingrese indice de 0 a 3");
            i = Convert.ToInt32(Console.ReadLine());

            /*if(i>=0 && i <= 3)
            {
                Console.WriteLine(nombres[i]);
                Console.WriteLine(numeros[i]);
            }else
            {
                Console.WriteLine("Indice incorrecto");
            } 

            Console.WriteLine("Largo del arreglo es: {0}", nombres.Length);

            for(i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine(nombres[i]);
                Console.WriteLine(numeros[i]);
            }

            Console.ReadKey();*/

        }
    }
}
