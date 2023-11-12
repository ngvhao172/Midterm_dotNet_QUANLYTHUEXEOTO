using dotNet_GK_QUANLYTHUEXEOTO.Controller;
using dotNet_GK_QUANLYTHUEXEOTO.Model.Data;
using Microsoft.Extensions.DependencyInjection;

namespace dotNet_GK_QUANLYTHUEXEOTO
{
    

    public class App
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        public static void ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddSingleton<CarTypesController>();
            serviceCollection.AddSingleton<CarController>();
            serviceCollection.AddSingleton<FeatureController>();
            serviceCollection.AddSingleton<FuelController>();
            serviceCollection.AddSingleton<BookingController>();
            serviceCollection.AddSingleton<CustomerController>();
            serviceCollection.AddSingleton<BookingCarDbContext>();

            ServiceProvider = serviceCollection.BuildServiceProvider();
        }
    }

}
