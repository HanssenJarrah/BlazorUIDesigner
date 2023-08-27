using BlazorUIDesigner.Configuration;
using DevExpress.Blazor;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

Configuration.ConfigureDevExpress(builder.Services);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor(c =>
{
    c.RootComponents.RegisterCustomElement<DxButton>("dx-button");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
