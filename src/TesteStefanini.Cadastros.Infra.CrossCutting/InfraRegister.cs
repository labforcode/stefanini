using Microsoft.Extensions.DependencyInjection;
using TesteStefanini.Cadastros.Dominios.Interfaces.UoW;
using TesteStefanini.Cadastros.Infra.Data.UoW;

namespace TesteStefanini.Cadastros.Infra.CrossCutting
{
    public class InfraInjection
    {
        public static void InfraRegister(IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
