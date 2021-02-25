using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using pruebaAngular.Model.Map;

namespace pruebaAngular.Model
{
    public partial class LibreriaDBContext : DbContext
    {
        public LibreriaDBContext() { }

        public LibreriaDBContext(DbContextOptions<LibreriaDBContext> options)
            : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {                
                optionsBuilder.UseOracle("USER ID=ELIBRERIA;Password=Libro2021;DATA SOURCE=localhost:1521/orcl");
            }
        }
        public virtual DbSet<Autor> autor { get; set; }
        public virtual DbSet<Editorial> editorial { get; set; }
        public virtual DbSet<Genero> genero { get; set; }
        public virtual DbSet<Libro> libro { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AutorMap());
            modelBuilder.ApplyConfiguration(new EditorialMap());
            modelBuilder.ApplyConfiguration(new GeneroMap());
            modelBuilder.ApplyConfiguration(new LibroMap());
        }
    }
}
