using Blazored.SessionStorage;
using InnoviaReach___TFI___FrontEnd.Data;
using InnoviaReach___TFI___FrontEnd.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using MudBlazor;
using MudBlazor.Services;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);


// Agregar soporte para localización
builder.Services.AddLocalization();

// Configurar culturas soportadas
var supportedCultures = new[] { "es", "en" };

var localizationOptions = new RequestLocalizationOptions()
    .SetDefaultCulture(supportedCultures[0])
    .AddSupportedCultures(supportedCultures)
    .AddSupportedUICultures(supportedCultures);


// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddScoped<LocalizationService>();
builder.Services.AddHttpContextAccessor();
builder.Services.AddRazorPages();
builder.Services.AddBlazoredSessionStorage();
builder.Services.AddServerSideBlazor();
builder.Services.AddMudServices();
builder.Services.AddScoped<IDialogService, MudBlazor.DialogService>();
builder.Services.AddScoped<MudThemeProvider>();
builder.Services.AddHttpClient();
builder.Services.AddSingleton<HttpClient>(sp =>
{
    var httpClient = new HttpClient();
    httpClient.BaseAddress = new Uri(builder.Configuration.GetSection("ApiConfig:UrlApiBase")?.Value?.ToString() ?? "");
    return httpClient;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.MapControllers();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseRequestLocalization(localizationOptions);

app.MapGet("Culture/Set", (string culture, string redirectUri, HttpContext context) =>
{
    if (culture is not null)
    {
        context.Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName,
            CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture, culture)),
            new CookieOptions { Expires = DateTimeOffset.Now.AddDays(30) });
    }

    return Results.LocalRedirect(redirectUri);
});

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
