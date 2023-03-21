using MercadoLibre.SDK;
using MercadoLibre.SDK.Meta;
using Microsoft.OpenApi.Models;
using NETPC.ApiMercadoLibre.Core.Interfaces;
using NETPC.ApiMercadoLibre.Infrastructure.Services;

namespace NETPC.ApiMercadoLibre.WebAPI.Extensions
{
    internal static class ServiceCollectionExtensions
    {
        internal static void AddSwaggerExtension(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(c =>
            {
                //c.ExampleFilters();
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1.8",
                    Title = "NetPC API Mercado Libre",
                    Description = @"Put the comment here.",
                    Contact = new OpenApiContact()
                    {
                        Name = "netpc",
                        Url = new Uri("http://netpc.uy/")
                    }
                });
                //c.EnableAnnotations();
            });
            //services.AddSwaggerExamplesFromAssemblies(Assembly.GetEntryAssembly());
        }

        internal static void AddServices(this IServiceCollection services, WebApplicationBuilder builder)
        {
            IConfiguration configuration = builder.Configuration;

            var clientId = Int64.Parse(configuration.GetConnectionString("ClientId")!);

            var secret = configuration.GetConnectionString("Secret")!;           

            var api = new MeliApiService(new HttpClient())
            {
                Credentials = new MeliCredentials(MeliSite.Uruguay, clientId, secret)
            };

            services.AddSingleton(api);

            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
