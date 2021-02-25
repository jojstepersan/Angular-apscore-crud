using pruebaAngular.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pruebaAngular.Repository
{
    public interface ILibroService
    {
        int Insert(Libro model);
        int Update(Libro model);
        List<Libro> GetLibros(string autor, string titulo, int anho,string editorial,string genero);
    }
}
