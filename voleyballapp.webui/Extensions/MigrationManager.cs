using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using voleyballapp.data.Concrete.EfCore;
using voleyballapp.webui.Identity;

namespace voleyballapp.webui.Extensions
{
    public static class MigrationManager
    {
        public static IHost MigrateDatabase(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                using (var identityContext = scope.ServiceProvider.GetRequiredService<IdentityContext>())
                {
                    try
                    {
                        identityContext.Database.Migrate();
                    }
                    catch (System.Exception)
                    {
                        // loglama
                        throw;
                    }
                }
            }

            using (var scope = host.Services.CreateScope())
            {
                using (var voleyballContext = scope.ServiceProvider.GetRequiredService<VoleyballContext>())
                {
                    try
                    {
                        voleyballContext.Database.Migrate();
                    }
                    catch (System.Exception)
                    {
                        // loglama
                        throw;
                    }
                }
            }

            return host;
        }
    }
}