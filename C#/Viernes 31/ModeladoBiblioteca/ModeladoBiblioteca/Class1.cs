using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeladoBiblioteca
{
    class autor
    {
       public int idAutor { get; set; }
       public string autorNombre { get; set; }
       public string autorApellido { get; set; }

        static int idAu = 1000;
        public autor()
        {
            idAutor = idAu;
            idAu++;
        }
    }

    class genero
    {
        static int idGen = 1000;
        public int idGenero { get; set; }
        public string descGenero { get; set; }

        public genero()
        {
            idGenero = idGen;
            idGen++;
        }
    }

    class editorial
    {
        static int idEd = 1000;
        public int idEditorial { get; set; }
        public string descEditorial { get; set; }

        public editorial()
        {
            idEditorial = idEd;
            idEd++;
        }
    }

    class libro
    {
        public autor autorLibro { get; set; }
        public genero generoLibro { get; set; }
        public editorial editorialLibro { get; set; }
        public string titulo { get; set; }
        public int paginas { get; set; }
        static int id = 1000;
        public int idLibro { get; set; }

        public libro()
        {
            autorLibro = new autor();
            generoLibro = new genero();
            editorialLibro = new editorial();
            idLibro = id;
            id++;
        }

        public libro(string name, string lname, string gen, string ed)
        {
            autorLibro = new autor();
            generoLibro = new genero();
            editorialLibro = new editorial();

            autorLibro.autorNombre = name;
            autorLibro.autorApellido = lname;
            generoLibro.descGenero = gen;
            editorialLibro.descEditorial = ed;

            idLibro = id;
            id++;
        }

    }
}
