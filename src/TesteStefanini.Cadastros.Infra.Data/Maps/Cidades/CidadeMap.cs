using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteStefanini.Cadastros.Dominios.Entidades.Cidades;

namespace TesteStefanini.Cadastros.Infra.Data.Maps.Cidades
{
    public class CidadeMap : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
            builder.ToTable("cidades");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                   .HasColumnName("id")
                   .IsRequired();

            builder.Property(c => c.Nome)
                   .HasColumnName("nome")
                   .HasColumnType("varchar(120)")
                   .IsRequired();

            builder.Property(c => c.Uf)
                   .HasColumnName("uf")
                   .HasColumnType("varchar(2)")
                   .IsRequired();
        }
    }
}
