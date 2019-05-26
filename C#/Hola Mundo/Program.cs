using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hola_Mundo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
            //Funcion o metodo del objeto 'console'
            Console.WriteLine("Hola a todos");
            Console.ReadKey();
            
             */

            /*
            Variables String

            string nombre;
            Console.Write("Cual es tu nombre? ");
            nombre = Console.ReadLine();
            //Console.WriteLine("Su nombre es {0}", nombre);
            Console.WriteLine("Su nombre es " + nombre);
            Console.ReadKey();

            */

            /*Dias semana
            const int diasSemana = 7;
            const int horasDia = 24;

            Console.WriteLine("Las horas semanales son "+ diasSemana*horasDia);
            Console.ReadKey();
            */

            /*Suma de enteros
            int a=2, b=3, c;

            c = a + b;

            Console.WriteLine("A vale " +a);
            Console.WriteLine("B vale " +b);
            Console.WriteLine("C vale " +c);
            Console.WriteLine("La suma total es {0}", a+b+c );

            Console.ReadKey();
            */

            /*Ejemplo con strings
            string p;
            string l;
            string f;

            p = "Perro";
            l = "ladra";
            f = "fuerte";

            Console.WriteLine(p + f + l);
            Console.WriteLine(p + " " + f + " " + l);           
            Console.Write("El {0} que {1} muy {2}", p, l, f);

            Console.ReadKey();
            */

            /*Ejemplo char
            char char1 = 'Z';
            char char2 = (char)88;

            Console.WriteLine(char1 + " " + char2);
            Console.ReadKey();
            */

            /*Ejemplo booleano
            bool z = true;

            Console.WriteLine(z);

            z = false;

            Console.WriteLine(z);
            Console.ReadKey();
            */

            /*Ejemplos double y float
            float fl = 0;
            double dl = 0;

            Console.WriteLine(fl);

            fl = 95.60f;

            Console.WriteLine(fl);
            Console.ReadKey();

            Console.WriteLine(dl);

            dl = 95.60;

            Console.WriteLine(dl);
            Console.ReadKey();
            */

            int x = 10;

            while (x == 10)
            {
                Console.WriteLine("OK");
                x = 9;
            }

            Console.ReadKey();
            










        }
    }
}
