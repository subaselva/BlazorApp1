using BlazorApp1;
using BlazorApp1.Services;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using static System.Net.WebRequestMethods;



var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
var apiBaseUrl = "https://localhost:7048/";
// Define API base address conditionally
if (builder.HostEnvironment.IsProduction())
{
     apiBaseUrl  = "https://vertical-living-atgtb5bshwahatg4.eastus2-01.azurewebsites.net/";
}

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(apiBaseUrl) });


builder.Services.AddScoped<StudentFeeService>();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<SignalRService>();
builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddMudServices();

await builder.Build().RunAsync();

