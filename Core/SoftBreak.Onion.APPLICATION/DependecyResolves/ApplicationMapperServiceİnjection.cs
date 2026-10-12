using Microsoft.Extensions.DependencyInjection;
using SoftBreak.Onion.APPLICATION.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftBreak.Onion.APPLICATION.DependecyResolves
{
    public static class ApplicationMapperServiceİnjection
    {
        public static void AddApplicationMapperService(this IServiceCollection services)
        {
            services.AddAutoMapper(cfg => cfg.AddProfile<MapProfile>());
        }
    }
}
