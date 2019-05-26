using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ejemplo operadores logicos

            bool A = true;
            bool B = false;
            bool resultado = A && B;

            Console.WriteLine("{0} and {1} da {2}", A, B, resultado);

            resultado = A || B;

            Console.WriteLine("{0} or {1} da {2}", A, B, resultado);

            resultado = !A;

            Console.WriteLine("not {0} da {1}", A, resultado);

            Console.ReadKey();
            */

            /*Ejemplo operadores relacionales

            int a = 10;
            int b = 5;

            Console.WriteLine("{0} es mayor que {1}? {2}", a, b, a > b);
            Console.WriteLine("{0} es menor que {1}? {2}", a, b, a < b);

            Console.ReadKey();*/

            /*Ejercicio incremento/decremento
            int a = 10;
            int b = 12;

            Console.WriteLine("a: {0} b: {1}", a, b);

            a = b--;

            Console.WriteLine("a: {0} b: {1}", a, b);

            a = --b;

            Console.WriteLine("a: {0} b: {1}", a, b);
            Console.ReadKey();*/
            /*Ejercicio IF
            int entero = 3;

            if (entero == 3){ 
                Console.WriteLine("La condicion se cumplio");
            }else{
                Console.WriteLine("La condicion no se cumplio");
            }

            Console.ReadKey();*/

            /*Ejemplo system.convert
            double dnumber = 100.49;
            int numero;

            numero = System.Convert.ToInt32(dnumber);

            Console.WriteLine("{0}", numero);
            Console.ReadKey();*/

            /*  Conversion explicita a entero con objeto convert
            int a = 0;

            Console.Write("Ingrese un numero: ");
            a = System.Convert.ToInt32(Console.ReadLine());

            if (a == 10){
                Console.WriteLine("{0} es igual a 10", a);
            }else{
                Console.WriteLine("{0} es distinto a 10", a);
            }

            Console.ReadKey();*/

            /*Conversion explicita con boxing
            int a = 0;
            string ingreso;

            Console.Write("Ingrese un numero: ");
            ingreso = Console.ReadLine();


            if (a == 10)
            {
                Console.WriteLine("{0} es igual a 10", a);
            }
            else
            {
                Console.WriteLine("{0} es distinto a 10", a);
            }

            Console.ReadKey();
            */

            /*Conversion explicita con metodo Parse
            int a = 0;
            string ingreso;

            Console.Write("Ingrese un numero: ");
            ingreso = Console.ReadLine();
            a=int.Parse(ingreso);

            a = int.Parse(Console.ReadLine());

            if (a == 10)
            {
                Console.WriteLine("{0} es igual a 10", a);
            }
            else
            {
                Console.WriteLine("{0} es distinto a 10", a);
            }

            Console.ReadKey();*/

            

        }


    }

}

