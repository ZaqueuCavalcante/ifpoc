using IfPoc.Configs;

namespace IfPoc;

public class Startup
{
    public static void ConfigureServices(IServiceCollection services)
    {
        services.AddSettingsConfigs();
        services.AddServicesConfigs();

        services.AddRoutingConfigs();
        services.AddControllersConfigs();

        services.AddEfCoreConfigs();

        services.AddSwaggerConfigs();
    }

    public static void Configure(IApplicationBuilder app)
    {
        app.UseRouting();

        app.UseSwaggerThings();

        app.UseEndpointsThings();
    }
}
