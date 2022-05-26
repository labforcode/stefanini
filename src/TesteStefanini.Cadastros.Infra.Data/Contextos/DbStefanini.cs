using Microsoft.EntityFrameworkCore;
using TesteStefanini.Cadastros.Dominios.Entidades.Cidades;
using TesteStefanini.Cadastros.Dominios.Entidades.Pessoas;
using TesteStefanini.Cadastros.Infra.Data.Maps.Cidades;
using TesteStefanini.Cadastros.Infra.Data.Maps.Pessoas;

namespace TesteStefanini.Cadastros.Infra.Data.Contextos
{
    public class DbStefanini : DbContext
    {
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }

        public DbStefanini(DbContextOptions<DbStefanini> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema("public");

            builder.ApplyConfiguration(new CidadeMap());
            builder.ApplyConfiguration(new PessoaMap());
        }
    }
}
