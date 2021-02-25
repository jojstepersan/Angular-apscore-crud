using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pruebaAngular.Model
{
    public class Editorial
    {
        public int idEditorial { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string direccion { get; set; }
        [Required]
        public string telefono { get; set; }
        [Required]
        public string correo { get; set; }
        public Nullable<int> maximoLibros { get; set; }
        
    }
}
