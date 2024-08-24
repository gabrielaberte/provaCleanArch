using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProvaCleanArch.Domain.Model;

namespace ProvaCleanArch.Data.Map
{
    public class AlunoMap : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("Aluno");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired();
            builder.Property(x => x.Ativo).IsRequired();
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.Endereco).IsRequired();
        }

    }
}
