using IfPoc.Settings;

namespace IfPoc.Configs;

public static class SettingsConfigs
{
    public static void AddSettingsConfigs(this IServiceCollection services)
    {
        services.AddSingleton<DatabaseSettings>();
    }
}
