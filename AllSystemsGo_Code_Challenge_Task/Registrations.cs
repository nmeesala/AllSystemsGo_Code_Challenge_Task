using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AllSystemsGo_Code_Challenge_Task.Calculator;

public static class Registrations
{
    public static ServiceProvider CreateService()
    {

        // Build the configuration
        var configuration = new ConfigurationBuilder()
             .SetBasePath(AppContext.BaseDirectory)
             .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
             .AddEnvironmentVariables()
             .Build();

        var appSettings = new AppSettings();
        configuration.GetSection("AppSettings").Bind(appSettings);

        var services = new ServiceCollection();

        services.AddSingleton<AppSettings>(appSettings);
        services.AddSingleton<Extensions>();
        services.AddSingleton<ICalculator, Calculator>();

        var builder = services.BuildServiceProvider();

        return builder;
    }
}