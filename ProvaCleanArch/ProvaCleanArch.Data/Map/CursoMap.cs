using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProvaCleanArch.Domain.Model;

namespace ProvaCleanArch.Data.Map
{
    internal class CursoMap : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder.ToTable("Curso");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Titulo).IsRequired();

            builder.Property(x => x.Descricao).IsRequired();

            builder.Property(x => x.Ativo);

            builder.Property(x => x.Vagas);

            builder.HasMany(x => x.Matriculas) //1 curso tem varias matriculas
                   .WithOne(x => x.Curso) //mas cada matricula tem 1 curso so
                   .HasForeignKey(x => x.CursoId); //relaciona as matriculas com o curso (conecta os 2)

            builder.HasOne(x => x.Professor) //1 curso tem 1 professor
                    .WithMany(x => x.Cursos) //1 professor tem varios cursos
                    .HasForeignKey(x => x.ProfessorId); //relaciona o id do professor com o curso especifico
        }
    }
}