using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nick.Web.Infra.Data.Context;
using Nick.Web.Services.Api.Config;

namespace Nick.Web.Services.Api
{
    public class Startup
    {
        private IConfiguration _configuration;

        public Startup(IHostingEnvironment env)
        {
            var configurarConstrutor = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsetting.json", optional: true, reloadOnChange: true);

            _configuration = configurarConstrutor.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.RegistrarDependencias();
            ConfigurarConexaoBancoDeDados(services);            
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseMvc();
        }

        public void ConfigurarConexaoBancoDeDados(IServiceCollection services)
        {
            var conectarSql = _configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<NickWebContext>(opcao => opcao.UseSqlServer(conectarSql, m => m.MigrationsAssembly("Nick.Web.Infra.Data")));
        }
    }
}
