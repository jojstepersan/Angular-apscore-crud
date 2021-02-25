using pruebaAngular.Helpers;
using pruebaAngular.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pruebaAngular.Repository
{
    public class LibroService : ILibroService
    {
        private readonly IRepositoryBase<Libro> _repository;
        public LibroService(IRepositoryBase<Libro> repository)
        {
            _repository = repository;
        }
        public List<Libro> GetLibros(string autor, string titulo, int anho, string editorial, string genero)
        {
            using (var context = new LibreriaDBContext())
            {
                return (from l in context.libro
                        join a in context.autor on l.idAutor equals a.idAutor
                        join e in context.editorial on l.idEditorial equals e.idEditorial
                        join g in context.genero on l.idGenero equals g.idGenero
                        where (autor==null || a.name.Contains(autor))
                        && (titulo==null || l.titulo.Contains(titulo))
                        && (editorial == null || e.name.Contains(editorial))
                        && (genero == null || g.name.Contains(genero))
                        && (anho == 0 || l.anho == anho)
                        select new Libro {
                            anho = l.anho,
                            idAutor = l.idAutor,
                            idEditorial = l.idEditorial,
                            idGenero = l.idGenero,
                            idLibro = l.idLibro,
                            numPaginas = l.numPaginas,
                            titulo = l.titulo,
                            nameAutor = a.name,
                            nameEditorial = e.name,
                            nameGenero = g.name
                        }).ToList(); 
            }
        }

        public int Insert(Libro model)
        {
            //validacion
            using (var context = new LibreriaDBContext())
            {
                var maxLibros = (from e in context.editorial
                                 where e.idEditorial == model.idEditorial
                                 select e.maximoLibros).FirstOrDefault();
                var librosTotales = context.libro.Where(x => x.idEditorial == model.idEditorial).Select(x => x).Count();
                //var librosTotales = (from l in context.libro
                //                     where l.idEditorial == model.idEditorial
                //                     select l.idLibro).Count();
                if (maxLibros == librosTotales) 
                {
                    throw new Exception("No es posible registrar el libro, se alcanzó el máximo permitido");
                }
                model.idLibro = SequenceTools.NextValSequence("LIBRO_SEQ");
                _repository.Insert(model);
                return model.idAutor;
            }            
        }

        public int Update(Libro model)
        {
            _repository.Update(model);
            return model.idAutor;
        }
    }
}
