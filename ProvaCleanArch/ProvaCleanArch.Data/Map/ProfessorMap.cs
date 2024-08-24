using Microsoft.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProvaCleanArch.Domain.Model;

namespace ProvaCleanArch.Data.Map
{
    internal class ProfessorMap : IEntityTypeConfiguration<Professor>

    {
        public void Configure(EntityTypeBuilder<Professor> builder)

        {

            builder.ToTable("Professor");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome).IsRequired();

            builder.Property(x => x.Email).IsRequired();

            //builder.HasOne(x => x.Professor).WithMany(x => x.Curso).HasForeignKey(x => x.IdCurso);

        }

    }

}
