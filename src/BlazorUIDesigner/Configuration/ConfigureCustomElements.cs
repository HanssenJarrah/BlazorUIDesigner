using DevExpress.Blazor;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorUIDesigner.Configuration;

public static class ServerSideBlazorBuilderExtensions
{
    public static IServerSideBlazorBuilder ConfigureCustomElements(this IServerSideBlazorBuilder serverBuilder)
    {
        serverBuilder.AddCircuitOptions(options =>
        {
            options.RootComponents.RegisterCustomElement<DxButton>("dx-button");
            options.RootComponents.RegisterCustomElement<DxTextBox>("dx-text-box");
        });

        return serverBuilder;
    }
}
