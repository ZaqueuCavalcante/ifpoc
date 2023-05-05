using System.Text.Json.Serialization;

namespace IfPoc.Configs;

public static class ControllersConfigs
{
    public static void AddControllersConfigs(this IServiceCollection services)
    {
        services.AddControllers().AddJsonOptions(
            options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles
        );
    }
}
