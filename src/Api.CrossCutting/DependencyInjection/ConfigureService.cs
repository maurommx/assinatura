using Api.Domain.Entities;
using Data.Mapping;
using Domain.Interfaces.Services.Assinatura;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Service.Services;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {

            serviceCollection.AddTransient<IAssinaturaService, AssinaturaService>();


            //serviceCollection.AddTransient<IUfService, UfService>();
            //serviceCollection.AddTransient<IMunicipioService, MunicipioService>();
            //serviceCollection.AddTransient<ICepService, CepService>();
        }
    }
}
