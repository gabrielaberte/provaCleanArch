using Microsoft.EntityFrameworkCore;
using ProvaCleanArch.Data.Map;
using ProvaCleanArch.Domain.Model;

namespace ProvaCleanArch.Data
{
        //DBContext serve para: configura modelo de dados; gerencia a conexao com o banco; consulta e persiste os dados no banco; rastreia ojetos;
    public class Contexto : DbContext

    {
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Professor> Professor { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Matricula> Matricula { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=SABRL5DC7423;Initial Catalog=CleanArch; " +
                "Trusted_Connection=True; TrustServerCertificate=True")
                .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoMap());
            modelBuilder.ApplyConfiguration(new ProfessorMap());
            modelBuilder.ApplyConfiguration(new CursoMap());
            modelBuilder.ApplyConfiguration(new MatriculaMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}