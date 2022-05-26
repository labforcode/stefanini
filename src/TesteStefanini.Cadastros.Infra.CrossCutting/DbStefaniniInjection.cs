using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TesteStefanini.Cadastros.Infra.Data.Contextos;

namespace TesteStefanini.Cadastros.Infra.CrossCutting
{
    public class DbStefaniniInjection
    {
        public static void ContextInject(IServiceCollection services, IConfiguration configuration)
        {
            var connection = configuration.GetConnectionString("dbstefanini");
            services.AddDbContext<DbStefanini>(options => options.UseSqlServer(connection));
            services.AddScoped<DbStefanini>();
        }
    }
}
