using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace pruebaAngular.Model.Map
{
    public class GeneroMap : IEntityTypeConfiguration<Genero>
    {
        public void Configure(EntityTypeBuilder<Genero> entity)
        {
            entity.HasKey(e => e.idGenero).HasName("PK_GEN");
            entity.ToTable("GENERO");
            entity.Property(e => e.idGenero).HasColumnName("ID_GENERO");
            entity.Property(e => e.name).HasColumnName("NAME");
        }
    }
}
