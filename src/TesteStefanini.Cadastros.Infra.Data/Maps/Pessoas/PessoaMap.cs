using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteStefanini.Cadastros.Dominios.Entidades.Pessoas;

namespace TesteStefanini.Cadastros.Infra.Data.Maps.Pessoas
{
    public class PessoaMap : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("pessoas");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                   .HasColumnName("id")
                   .UseIdentityColumn()
                   .IsRequired();

            builder.Property(c => c.Nome)
                   .HasColumnName("nome")
                   .HasColumnType("varchar(120)")
                   .IsRequired();

            builder.Property(c => c.Cpf)
                   .HasColumnName("cpf")
                   .HasColumnType("varchar(11)")
                   .IsRequired();

            builder.Property(c => c.DataNascimento)
                   .HasColumnName("data_nascimento")
                   .IsRequired();

            builder.Property(c => c.CidadeId)
                   .HasColumnName("cidade_id")
                   .IsRequired();

            builder.HasOne(x => x.Cidade)
                   .WithMany(b => b.Pessoas)
                   .HasForeignKey(b => b.CidadeId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
