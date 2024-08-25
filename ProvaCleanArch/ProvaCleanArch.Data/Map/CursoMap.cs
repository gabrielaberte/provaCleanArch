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

            builder.Property(x => x.Ativo).IsRequired();

            builder.Property(x => x.Vagas).IsRequired();
            
            //um curso pode ter varias matriculas e um unico professor
            //nao conseguimos fazer os relacionamentos entre as tabelas :(

            builder.HasOne(x => x.Professor).WithMany().HasForeignKey(x => x.ProfessorId);

            builder.HasOne(x => x.Matriculas).WithMany().HasForeignKey(x => x.Matriculas);
        }
    }
}