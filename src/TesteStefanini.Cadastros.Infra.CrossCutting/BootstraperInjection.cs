using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TesteStefanini.Cadastros.Infra.CrossCutting
{
    public class BootstraperInjection
    {
        public static void Injector(IServiceCollection services, IConfiguration configuration)
        {
            DbStefaniniInjection.ContextInject(services, configuration);

            AppServicesInjection.ServicesInject(services);

            InfraInjection.InfraRegister(services);

            RepositoryInjection.RepositoryInject(services);
        }
    }
}
