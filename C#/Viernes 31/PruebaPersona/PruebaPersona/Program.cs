using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaPersona
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Primer Ejemplo
              
            persona NuevaPersona = new persona();
            hobby nuevoHobby = new hobby();

            NuevaPersona.Apellido = "Clas";
            NuevaPersona.Nombre = "Daniel";           

            nuevoHobby.ID = 500;
            nuevoHobby.nombre = "Aeromodelismo";

            NuevaPersona.HobbyDeLaPersona = nuevoHobby;
            */

            persona NuevaPersona = new persona();           

            NuevaPersona.Apellido = "Clas";
            NuevaPersona.Nombre = "Daniel";

            NuevaPersona.HobbyDeLaPersona.ID = 500;
            NuevaPersona.HobbyDeLaPersona.nombre = "Aeromodelismo";

            Console.WriteLine("A {0} {1} le gusta el {2}", NuevaPersona.Nombre, NuevaPersona.Apellido, NuevaPersona.HobbyDeLaPersona.nombre);

            Console.ReadKey();
        }
    }
}
