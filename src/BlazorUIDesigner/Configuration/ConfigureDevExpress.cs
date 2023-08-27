using DevExpress.Blazor;

namespace BlazorUIDesigner.Configuration;

public static partial class ConfigurationExtensions
{
    public static void ConfigureDevExpress(this IServiceCollection services)
    {
        services.AddDevExpressBlazor(config =>
        {
            config.BootstrapVersion = BootstrapVersion.v5;
            config.SizeMode = SizeMode.Large;
        });
    }
}
