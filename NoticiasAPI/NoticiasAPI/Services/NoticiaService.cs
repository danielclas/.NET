using Microsoft.EntityFrameworkCore;
using NoticiasAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoticiasAPI.Services
{
    public class NoticiaService
    {
        private readonly NoticiaDBContext _noticiaDBContext;
        public NoticiaService(NoticiaDBContext noticiasDBContext)
        {
            _noticiaDBContext = noticiasDBContext;
        }

        public bool Agregar(Noticia _noticia)
        {
            try
            {
                _noticiaDBContext.Noticia.Add(_noticia);
                _noticiaDBContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Noticia> Obtener()
        {
            return _noticiaDBContext.Noticia.Include(x => x.Autor).ToList();
        }

        public bool EditarNoticia(Noticia _noticia)
        {
            try
            {
                var noticiaDB = _noticiaDBContext.Noticia.Where(x => x.NoticiaID == _noticia.NoticiaID).FirstOrDefault();
                noticiaDB.Titulo = _noticia.Titulo;
                noticiaDB.Descripcion = _noticia.Descripcion;
                noticiaDB.Contenido = _noticia.Contenido;
                noticiaDB.AutorID = _noticia.AutorID;
                noticiaDB.Fecha = _noticia.Fecha;
                _noticiaDBContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EliminarNoticia(int noticiaID)
        {
            try
            {
                var noticiaDB = _noticiaDBContext.Noticia.Where(x => x.NoticiaID == noticiaID).FirstOrDefault();
                _noticiaDBContext.Noticia.Remove(noticiaDB);
                _noticiaDBContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
