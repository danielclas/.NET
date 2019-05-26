using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Ejercicio 4: Ingresar dos números y ofrecer al usuario un
menú con las siguientes opciones: “1-suma 2-resta 3-
producto 4-división”. Luego, mostrar el resultado de la
operación aritmética elegida
*/

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, rta;

            Console.Write("Ingrese un numero: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Ingrese otro numero: ");
            y = int.Parse(Console.ReadLine());            

            do {

                Console.Clear();
                Console.WriteLine("\n1-Suma\n2-Resta\n3-Producto\n4-Division\n5-Salir");
                rta = int.Parse(Console.ReadLine());

                switch (rta)
                {
                    case 1:
                        Console.WriteLine("\n{0} mas {1} es {2}", x, y, x+y);
                        break;
                    case 2:
                        Console.WriteLine("\n{0} menos {1} es {2}", x, y, x-y);
                        break;
                    case 3:
                        Console.WriteLine("\n{0} por {1} es {2}", x, y, x*y);
                        break;
                    case 4:
                        Console.WriteLine("\n{0} dividido {1} es {2}", x, y, x/y);
                        break;
                    default:
                        break;
                }

                Console.ReadKey();

            } while (rta != 5);

            Console.ReadKey();

        }
    }
}
