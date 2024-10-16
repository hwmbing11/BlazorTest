using BlazorApp2.Client.BlazorBlob;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddTransient<BlobStreamService>();

await builder.Build().RunAsync();