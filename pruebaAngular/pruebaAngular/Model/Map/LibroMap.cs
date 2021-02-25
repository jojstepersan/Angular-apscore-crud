using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace pruebaAngular.Model.Map
{
    public class LibroMap:IEntityTypeConfiguration<Libro>
    {
        public void Configure(EntityTypeBuilder<Libro> entity)
        {
            entity.HasKey(e => e.idAutor).HasName("PK_LIB");
            entity.ToTable("LIBROS");
            entity.Property(e => e.idLibro).HasColumnName("ID_LIBRO");
            entity.Property(e => e.titulo).HasColumnName("TITULO");
            entity.Property(e => e.anho).HasColumnName("ANHO");
            entity.Property(e => e.idGenero).HasColumnName("ID_GENERO");
            entity.Property(e => e.numPaginas).HasColumnName("NUM_PAGINAS");
            entity.Property(e => e.idEditorial).HasColumnName("ID_EDITORIAL");
            entity.Property(e => e.idAutor).HasColumnName("ID_AUTOR");
        }
    }
}
