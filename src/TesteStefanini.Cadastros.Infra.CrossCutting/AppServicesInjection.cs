using Microsoft.Extensions.DependencyInjection;
using TesteStefanini.Cadastros.Aplicacoes.Interfaces.Cidades;
using TesteStefanini.Cadastros.Aplicacoes.Interfaces.Pessoas;
using TesteStefanini.Cadastros.Aplicacoes.Services.Cidades;
using TesteStefanini.Cadastros.Aplicacoes.Services.Pessoas;

namespace TesteStefanini.Cadastros.Infra.CrossCutting
{
    public class AppServicesInjection
    {
        public static void ServicesInject(IServiceCollection services)
        {
            services.AddScoped<ICidadeAppService, CidadeAppService>();
            services.AddScoped<IPessoaAppService, PessoaAppService>();
        }
    }
}
