using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_For_Lab_3_Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {

            /*@
              @@
              @@@
              @@@@
              @@@@@
           
            for (int i = 1; i <= 6; i++)
            {

                for (int j = 1; j != i; j++)
                {
                    Console.Write('@');
                }

                Console.WriteLine("");
            }

            Console.ReadKey();*/

            /*@@@@@
            @@@@
            @@@         
            @@        
            @*/

            for(int i=1; i <= 6; i++)
            {
                for (int j = 6; j > i ; j--)
                {

                    Console.Write('@');

                }

                Console.WriteLine("");

            }               

            Console.ReadKey();

            /**/






        }
    }
}
