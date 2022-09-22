using FizzBuzz;
using FizzBuzz.Interfaces;
using FizzBuzz.Services;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
// Dependency Injection Host
using var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
    {
        services.AddTransient<IFizzBuzzHost, FizzBuzzHost>();
        services.AddTransient<IFizzBuzzService, FizzBuzzService>();
    })
    .Build();

// Kickoff
host.Services.GetService<IFizzBuzzHost>()?.Run(args);
await host.RunAsync();
