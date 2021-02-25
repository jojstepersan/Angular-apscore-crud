using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pruebaAngular.Model.Map
{
    public class AutorMap : IEntityTypeConfiguration<Autor>
    {
        public void Configure(EntityTypeBuilder<Autor> entity)
        {
            entity.HasKey(e => e.idAutor).HasName("PK_AUT");
            entity.ToTable("AUTOR");
            entity.Property(e => e.idAutor).HasColumnName("ID_AUTOR");
            entity.Property(e => e.name).HasColumnName("NAME");
            entity.Property(e => e.fechaNacimiento).HasColumnName("FECHA_NACIMIENTO");
            entity.Property(e => e.ciudad).HasColumnName("CIUDAD");
            entity.Property(e => e.correo).HasColumnName("CORREO");
        }
    }
}
