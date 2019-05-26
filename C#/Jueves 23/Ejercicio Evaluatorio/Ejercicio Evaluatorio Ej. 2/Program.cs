using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Evaluatorio_Ej._2
{
    class Program
    {
        /*
            Dado el vector inflación {0.8, 0.1, 0.3, 0.4, 0.3, 0.6, 0.5, 0.3, 0.7, 0.3, 0.2, 0.9}
            Cada ítem del vector representa la inflación de un mes de tal manera que el primer ítem 
            del vector que es 0.8 representa la inflación de Enero, y el último ítem del vector 
            que es 0.9 representa la inflación de diciembre.

            Se pide:
            a) Informar la inflación anual

            b) Informar la inflación más baja, junto con el número de mes. Por ejemplo: Mes 2 = 0.1

            c) Informar la inflación más alta, junto con el número de mes. Por ejemplo: Mes 12 = 0.9

            d) Informar el promedio de inflación (inflación total / 12)
             
          */
        static void Main(string[] args)
        {
            double[] inflacion = new double[] 
            { 0.8, 0.1, 0.3, 0.4, 0.3, 0.6, 0.5, 0.3, 0.7, 0.3, 0.2, 0.9 };
            string[] meses = new string[] 
            { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            double inflacionAnual = 0;            
            int indexInflacionMenor = 0, indexInflacionMayor = 0; //Guarda el indice del array inflacion del menor valor
            
            inflacionAnual = calcularInfAnual(inflacion);//Recibe la inflacion anual total
            indexInflacionMenor = calcularInfMenor(inflacion);//Recibe el indice de la inflacion menor
            indexInflacionMayor = calcularInfMayor(inflacion);//Recibe el indice de la inflacion mayor

            Console.WriteLine("A) Inflacion anual: %{0:N2}", inflacionAnual);
            Console.WriteLine("B) Inflacion menor: %{0:N2}, mes: {1}", inflacion[indexInflacionMenor], meses[indexInflacionMenor]);
            Console.WriteLine("C) Inflacion mayor: %{0:N2}, mes: {1}", inflacion[indexInflacionMayor], meses[indexInflacionMayor]);
            Console.WriteLine("D) Inflacion promedio: {0:N2}", inflacionAnual / 12);
            Console.ReadKey();
        }

        static double calcularInfAnual(double[] inflacion)
        {
            double inflacionAnual = 0;
            //Recibe el array inflacion y lo recorre sumando los elementos al acumulador

            for (int i = 0; i < inflacion.Length; i++)
            {
                inflacionAnual += inflacion[i];
            }

            //Devuelve el valor del acumulador
            return inflacionAnual;
        }

        static int calcularInfMenor(double[] inflacion)
        {
            int indexInflacionMenor = 0;
            double inflacionMenor = inflacion[0];
            //Asigna como inflacion menor al primer elemento del arreglo

            for (int i = 1; i < inflacion.Length; i++)
            {
                //Compara con el resto de los elementos y asigna si encuentra uno menor
                if (inflacion[i] < inflacionMenor)
                {
                    inflacionMenor = inflacion[i];
                    indexInflacionMenor = i;
                }
            }

            //Devuelve el index correspondiente a la inflacion menor
            return indexInflacionMenor;
        }

        static int calcularInfMayor(double[] inflacion)
        {
            int indexInflacionMayor = 0;
            double inflacionMayor = inflacion[0];
            //Asigna como inflacion mayor al primer elemento del arreglo

            for (int i = 1; i < inflacion.Length; i++)
            {
                //Compara con el resto de los elementos y asigna si encuentra uno mayor
                if (inflacion[i] > inflacionMayor)
                {
                    inflacionMayor = inflacion[i];
                    indexInflacionMayor = i;
                }
            }
            
            //Devuelve el index correspondiente a la inflacion mayor
            return indexInflacionMayor;
        }



    }
}
