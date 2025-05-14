using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Template.Domain.Entidades;
using Template.Domain.Repositorios;

namespace Template.CrossCutting.InjecaoDependencia
{
    public static class DependencyInjection
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IAutorizacaoService, AutorizacaoService>();
            services.AddScoped<IAutorizacaoRecorrenciaRepository, AutorizacaoRecorrenciaRepository>();
        }
    }
}
