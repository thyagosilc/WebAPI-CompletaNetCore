using Elmah.Io.AspNetCore;
using Elmah.Io.Extensions.Logging;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.Api.Configuration
{
    public static class LoggerConfig
    {
        public static IServiceCollection AddLoggerConfig(this IServiceCollection services)
        {
            services.AddElmahIo(o =>
            {
                o.ApiKey = "ef653a02033048a394e85135fb1f5335";
                o.LogId = new Guid("2e797aa3-4c3c-4f36-a2c1-a5a303d548be");
            });

           // services.AddLogging(build =>
           //{
           //    build.AddElmahIo(o =>
           //    {
           //        o.ApiKey = "ef653a02033048a394e85135fb1f5335";
           //        o.LogId = new Guid("2e797aa3-4c3c-4f36-a2c1-a5a303d548be");
           //    });

           //    build.AddFilter<ElmahIoLoggerProvider>(null, LogLevel.Warning);

           //});

            return services;
        }

        public static IApplicationBuilder UseLoggingConfiguration(this IApplicationBuilder app)
        {
            app.UseElmahIo();

            return app;
        }

    }
}

