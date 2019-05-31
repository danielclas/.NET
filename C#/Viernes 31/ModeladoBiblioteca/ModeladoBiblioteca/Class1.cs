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
    }

    class genero
    {
        static int idGen = 1000;
        public int idGenero { get { return idGenero; } set {idGenero=idGen;idGen++} }
        public string descGenero { get; set; }
    }

    class editorial
    {
        static int idEd = 1000;
        public int idEditorial { get { return idEditorial; } set {idEditorial=idEd;idEd++;} }
        public string descEditorial { get; set; }
    }

    class libro
    {
        public autor autorLibro;
        public genero generoLibro;
        public editorial editorialLibro;
        public string titulo { get; set; }
        public int paginas { get; set; }
        static int id = 1000;
        public int idLibro { get { return idLibro; } set { idLibro = id; id++; } }
        
    }
}
