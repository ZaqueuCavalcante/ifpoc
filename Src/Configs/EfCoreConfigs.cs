using Microsoft.EntityFrameworkCore;
using IfPoc.Database;
using IfPoc.Settings;

namespace IfPoc.Configs;

public static class EfCoreConfigs
{
    public static void AddEfCoreConfigs(this IServiceCollection services)
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

        var databaseSettings = services.BuildServiceProvider().GetService<DatabaseSettings>()!;

        services.AddDbContext<IfPocDbContext>(options =>
        {
            options.UseNpgsql(databaseSettings.ConnectionString);
            options.UseSnakeCaseNamingConvention();
        });
    }
}
