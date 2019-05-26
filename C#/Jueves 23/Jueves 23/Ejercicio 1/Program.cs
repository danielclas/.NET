using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0, i = 0, aux, nro;            

            do
            {
                aux = ingresarNumero();                

                if (aux == 0)
                {
                    break;
                }
                else
                {
                    nro = aux;
                    suma += nro;
                    i++;
                }           

            } while (aux != 0);

            if (i != 0)
            {
                Console.WriteLine("\nEl promedio es {0:N2}", (float)suma / i);
            }
            else
            {
                Console.WriteLine("No pudo obtenerse el promedio");
            }

            Console.WriteLine("La cantidad de numeros es: {0}", i);
            Console.ReadKey();

        }

        static int ingresarNumero()
        {
            int aux;

            Console.Write("Ingrese un nro positivo, o 0 para finalizar: ");
            aux = int.Parse(Console.ReadLine());

            while (aux != 0 && aux < 0)
            {
                Console.Write("Error. Ingrese un nro positivo, o 0 para finalizar: ");
                aux = int.Parse(Console.ReadLine());
            }

            return aux;

        }
    }
}
