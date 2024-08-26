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

            builder.HasMany(x => x.Cursos) //1 professor tem varios cursos
                   .WithOne(x => x.Professor) //cada curso tem 1 professor
                   .HasForeignKey(x => x.ProfessorId); //conectados pelo professorId
        }

    }

}
