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

            //builder.HasOne(x => x.Curso).WithMany(x => x.Aluno).HasForeignKey(x => x.IdCurso);
        }
    }
}