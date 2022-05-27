using Microsoft.Extensions.DependencyInjection;
using TesteStefanini.Cadastros.Dominios.Interfaces.Repositorios.Cidades;
using TesteStefanini.Cadastros.Dominios.Interfaces.Repositorios.Pessoas;
using TesteStefanini.Cadastros.Infra.Data.Repositorios.Cidades;
using TesteStefanini.Cadastros.Infra.Data.Repositorios.Pessoas;

namespace TesteStefanini.Cadastros.Infra.CrossCutting
{
    public class RepositoryInjection
    {
        public static void RepositoryInject(IServiceCollection services)
        {
            services.AddScoped<ICidadeRepositorio, CidadeRepositorio>();
            services.AddScoped<IPessoaRepositorio, PessoaRepositorio>();
        }
    }
}
