using Blazored.Toast;
using BlazorTraining;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var apiUrl = new Uri("https://jsonplaceholder.typicode.com");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = apiUrl });
builder.Services.AddHttpClient("SuperApi", client => client.BaseAddress = apiUrl);

builder.Services.AddBlazoredToast();

await builder.Build().RunAsync();
