using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pruebaAngular.Model.Map
{
    public class EditorialMap : IEntityTypeConfiguration<Editorial>
    {
        public void Configure(EntityTypeBuilder<Editorial> entity)
        {
            entity.HasKey(e => e.idEditorial).HasName("PK_EDI");
            entity.ToTable("EDITORIAL");
            entity.Property(e => e.idEditorial).HasColumnName("ID_EDITORIAL");
            entity.Property(e => e.name).HasColumnName("NAME");
            entity.Property(e => e.direccion).HasColumnName("DIRECCION");
            entity.Property(e => e.telefono).HasColumnName("TELEFONO");
            entity.Property(e => e.correo).HasColumnName("CORREO");
            entity.Property(e => e.maximoLibros).HasColumnName("MAXIMO_LIBROS");
        }
    }
}
