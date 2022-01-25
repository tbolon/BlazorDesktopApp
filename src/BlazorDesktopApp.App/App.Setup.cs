using BlazorDesktopApp.Data;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorDesktopApp
{
    partial class App
    {
        /// <summary>
        /// This is where all components are registered in the service collection.
        /// </summary>
        public static void SetupServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<AppState>();
            serviceCollection.AddSingleton<WeatherForecastService>();
        }
    }
}
