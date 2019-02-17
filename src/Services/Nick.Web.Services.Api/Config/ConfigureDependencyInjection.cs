using Microsoft.Extensions.DependencyInjection;
using Nick.Web.Infra.CrossCutting;

namespace Nick.Web.Services.Api.Config
{
    public static class ConfigureDependencyInjection
    {
        public static void RegistrarDependencias(this IServiceCollection services)
        {
            NativeDependecyInjection.RegistrarDependencias(services);
        }
    }
}
