using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pruebaAngular.Model
{
    public class Libro
    {
        public int idLibro { get; set; }
        [Required]
        public string titulo { get; set; }
        [Required]
        public int anho { get; set; }
        [Required]
        public int idGenero { get; set; }
        [Required]
        public int idEditorial { get; set; }
        [Required]
        public int idAutor { get; set; }
        [Required]
        public int numPaginas { get; set; }
        public string nameAutor { get; set; }
        public string nameEditorial { get; set; }
        public string nameGenero { get; set; }

    }
}
