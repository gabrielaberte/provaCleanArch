using ProvaCleanArch.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProvaCleanArch.Data.Map
{
    public class AlunoMap : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("Aluno");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasColumnType("nvarchar(150)").IsRequired();
            builder.Property(x => x.Ativo).IsRequired();
            builder.Property(x => x.Email).HasColumnType("nvarchar(150)").IsRequired();
            builder.Property(x => x.Endereco).HasColumnType("nvarchar(150)").IsRequired();
        }

    }
}
