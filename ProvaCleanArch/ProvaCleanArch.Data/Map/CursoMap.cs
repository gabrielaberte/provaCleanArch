using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProvaCleanArch.Domain;

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

            builder.Property(x => x.Ativo).IsRequired();

            builder.Property(x => x.Vagas).IsRequired();

            //builder.HasOne(x => x.Aluno).WithMany(x => x.Aluno).HasForeignKey(x => x.IdAluno);

            //builder.HasOne(x => x.Professor).HasForeignKey(x => x.IdProfessor);

            //.HasOne(x => x.Matriculas).HasForeignKey(x => x.IdMatricula);
        }
    }
}