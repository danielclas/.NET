using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeladoBiblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            libro book = new libro() {paginas=255, titulo="Superman", generoLibro.descGenero="Comic"};

        /*public autor autorLibro;
        public genero generoLibro;
        public editorial editorialLibro;
        public string titulo { get; set; }
        public int paginas { get; set; }
        static int id = 1000;
        public int idLibro { get { return idLibro; } set { idLibro = id; id++; } }*/

        List<genero> genList = new List<genero>()
            {
                new genero() {descGenero="Novela"},
                new genero() {descGenero="Teatro"},
                new genero() {descGenero="Sci-Fi"},
                new genero() {descGenero="Historia"},
                new genero() {descGenero="Comic"},
            };

            List<autor> autList = new List<autor>()
            {
                new autor() {autorNombre="Stan", autorApellido="Lee"},
                new autor() {autorNombre="Gabriel Garcia", autorApellido="Marquez"},
                new autor() {autorNombre="Jorge Luis", autorApellido="Borges"},
                new autor() {autorNombre="Felipe", autorApellido="Pigna"},
                new autor() {autorNombre="Oscar", autorApellido="Wilde"},
            };

            List<editorial> edList = new List<editorial>()
            {
                new editorial() {descEditorial="VOX"},
                new editorial() {descEditorial="Planeta"},
                new editorial() {descEditorial="ABC"},
                new editorial() {descEditorial="La Nacion"},
                new editorial() {descEditorial="Gredos"},
            };






        }
    }
}
