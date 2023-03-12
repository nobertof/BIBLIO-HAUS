using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace biblio_haus.Models
{
    public class Context : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=D:\\Meus Documentos\\documentos\\programações\\BIBLIO-HAUS\\Models\\Database\\bancoDeDados.sqlite3");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbEmprestimos>()
                .HasKey(e => e.tbEmprestimos_id);

            modelBuilder.Entity<tbUsuarios>()
                .HasKey(e => e.tbUsuarios_id);

            modelBuilder.Entity<tbFichamentos>()
                .HasKey(e => e.tbFichamentos_id);

            modelBuilder.Entity<tbLivros>()
                .HasKey(e => e.tbLivros_id);
        }
        public DbSet<tbUsuarios> tbUsuarios { get; set; }
        public DbSet<tbLivros> tbLivros { get; set; }
        public DbSet<tbFichamentos> tbFichamentos { get; set; }
        public DbSet<tbEmprestimos> tbEmprestimos { get; set; }

    }
}