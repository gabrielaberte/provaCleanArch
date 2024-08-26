using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProvaCleanArch.Domain.Model;

namespace ProvaCleanArch.Data.Map
{
    internal class MatriculaMap : IEntityTypeConfiguration<Matricula>
    {
        public void Configure(EntityTypeBuilder<Matricula> builder)
        {
            builder.ToTable("Matricula");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.DataMatricula).IsRequired();

            builder.Property(x => x.Status).IsRequired();

            builder.HasOne(x => x.Curso) //1 matricula tem 1 curso
                    .WithMany(x => x.Matriculas) //1 curso tem varias matriculas
                    .HasForeignKey(x => x.CursoId); //unidos pelo cursoId
           
            builder.HasOne(x => x.Aluno) //1 matricula tem 1 aluno
                    .WithMany(x => x.Matriculas) //1 aluno tem varias Matriculas
                    .HasForeignKey(x =>x.AlunoId); //unidos pelo alunoid
        }
    }
}