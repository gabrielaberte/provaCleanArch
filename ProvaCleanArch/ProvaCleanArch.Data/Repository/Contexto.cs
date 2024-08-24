using Microsoft.EntityFrameworkCore;
using ProvaCleanArch.Data.Map;
using ProvaCleanArch.Domain.Model;

namespace ProvaCleanArch.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Professor> Professor { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Matricula> Matricula { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

           // optionsBuilder.UseSqlServer("Server=LAPTOP-GPMPQN74\\MSSQLSERVER02; Database=Minha1ConexaoAmbev; " +
            //    "Trusted_Connection=True; TrustServerCertificate=True")
             //   .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);

           // base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoMap());
            //modelBuilder.ApplyConfiguration(new MatriculaMap());
            //modelBuilder.ApplyConfiguration(new ProfessorMap());
            //modelBuilder.ApplyConfiguration(new CursoMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}