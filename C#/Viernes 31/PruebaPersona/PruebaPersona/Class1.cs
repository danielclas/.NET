using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaPersona
{
    class persona
    {
        private string apellido;
        private string nombre;
        private hobby hobby;      

        public persona()
        {
            hobby = new hobby();
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public hobby HobbyDeLaPersona
        {
            get { return hobby; }
            set { hobby = value; }
        }

    }

    class hobby
    {
        private int id;
        public string nombre;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

    }
}
