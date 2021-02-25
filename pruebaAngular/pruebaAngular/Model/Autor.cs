using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pruebaAngular.Model
{
    public class Autor
    {
        public int idAutor { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public DateTime fechaNacimiento { get; set; }
        [Required]
        public string ciudad { get; set; }
        [Required]
        public string correo { get; set; }
    }
}
