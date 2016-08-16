using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class WebContextDb : DbContext
    {
        public WebContextDb() : base("WebDeveloperConnectionString")
        {
        }

        public virtual DbSet<ModelAutor> Autor { get; set; }
        public virtual DbSet<ModelLibro> Libro { get; set; }
        public virtual DbSet<ModelLibroAutor> LibroAutor { get; set; }
         

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<ModelLibroAutor>()
                .HasMany(e => e.Autor)
                .WithRequired(e => e.ModeloAutor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ModelLibroAutor>()
               .HasMany(e => e.Libro)
               .WithRequired(e => e.ModeloAutor)
               .WillCascadeOnDelete(false);
            

        }
    }
}
