using Microsoft.Extensions.DependencyInjection;
using TesteStefanini.Cadastros.Dominios.Comandos.Cidades;
using TesteStefanini.Cadastros.Dominios.Comandos.Pessoas;

namespace TesteStefanini.Cadastros.Infra.CrossCutting
{
    public class ComandoInjection
    {
        public static void ComandosRegister(IServiceCollection services)
        {
            services.AddScoped<ICidadeComando, CidadeComandoHandler>();
            services.AddScoped<IPessoaComando, PessoaComandoHandler>();
        }
    }
}
