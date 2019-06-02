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
            libro book = new libro();                      

            book.titulo = "El Aleph";
            book.paginas = 215;
            book.autorLibro.autorNombre = "Jorge Luis";
            book.autorLibro.autorApellido = "Borges";
            book.generoLibro.descGenero = "Cuentos";
            book.editorialLibro.descEditorial = "Planeta";            

            List<libro> bookList = new List<libro>() {
                new libro("Paulo", "Coelho", "Novela", "Pengüin"){titulo="El Alquimista", paginas=330},
                new libro("Juan", "Galan", "Historia", "VOX"){titulo="1ra. Guerra Mundial", paginas=700},
                new libro("Julio", "Cortazar", "Novela", "ABC"){titulo="Rayuela", paginas=620},
                new libro("Ernesto", "Sabato", "Novela", "La Nacion"){titulo="El Tunel", paginas=270},
                new libro("Stan", "Lee", "Comic", "Marvel"){titulo="Superman", paginas=330}
            };

            Console.WriteLine("{0,-20}{1,-20}{2,-20}{3,-10}{4,-20}", "Titulo", "Autor", "Genero", "Paginas", "Editorial");
            Console.WriteLine("\n{0,-20}{1,-20}{2,-20}{3,-10}{4,-20}", book.titulo, book.autorLibro.autorNombre + " " + book.autorLibro.autorApellido, book.generoLibro.descGenero, book.paginas, book.editorialLibro.descEditorial);
            foreach (var item in bookList)
            {
                Console.WriteLine("\n{0,-20}{1,-20}{2,-20}{3,-10}{4,-20}", item.titulo, item.autorLibro.autorNombre+" "+item.autorLibro.autorApellido, item.generoLibro.descGenero, item.paginas, item.editorialLibro.descEditorial);
            }

            Console.ReadKey();          




        }
    }
}
