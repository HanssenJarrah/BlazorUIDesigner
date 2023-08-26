using DevExpress.Blazor;

namespace BlazorUIDesigner.Configuration;

public static partial class Configuration
{
    public static void ConfigureDevExpress(IServiceCollection services)
    {
        services.AddDevExpressBlazor(config =>
        {
            config.BootstrapVersion = BootstrapVersion.v5;
            config.SizeMode = SizeMode.Large;
        });
    }
}
