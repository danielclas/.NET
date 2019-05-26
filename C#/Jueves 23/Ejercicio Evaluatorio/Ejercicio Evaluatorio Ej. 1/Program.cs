using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Evaluatorio_Ej._1
{
    class Program
    {
        //Aplicar validaciones de ingreso de datos y funciones al ejercicio del promedio de notas
        static void Main(string[] args)
        {

            int[] notas = new int[3];
            int suma = 0;
            float promedio;
            string mensaje;

            for(int i=0; i < notas.Length; i++)
            {
                notas[i]=conseguirNotas();
                suma += notas[i];
            }

            promedio = (float)suma / notas.Length;

            if (promedio < 3)
            {
                mensaje = "No aprobado";
            }else
            {
                if (promedio >= 7)
                {
                    mensaje = "Promocionado";
                }
                else
                {
                    mensaje= "Regular";
                }
            }

            Console.WriteLine(mensaje+", promedio: {0:N2}", promedio);
            Console.ReadKey();

        }

        static int conseguirNotas()
        {
            int nota;
            
            Console.Write("Ingrese una nota: ");
            nota = int.Parse(Console.ReadLine());

            while (nota <1 || nota>10)
            {
                Console.Write("Error, ingrese nota valida: ");
                nota = int.Parse(Console.ReadLine());
            }

            return nota;
        }
    }
}
