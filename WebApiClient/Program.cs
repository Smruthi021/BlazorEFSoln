using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;
using WebApiClient;
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddSyncfusionBlazor();
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzY4ODAwMEAzMjM4MmUzMDJlMzBmR0lqSE92RjJzOHp2VWx0ZnFUYSsrOEt2VURNRzZrQmg5WG5va09KNjBnPQ==");
await builder.Build().RunAsync();
