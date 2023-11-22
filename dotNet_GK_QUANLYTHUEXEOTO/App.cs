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

            serviceCollection.AddTransient<CarTypesController>();
            serviceCollection.AddTransient<CarController>();
            serviceCollection.AddTransient<FeatureController>();
            serviceCollection.AddTransient<FuelController>();
            serviceCollection.AddTransient<BookingController>();
            serviceCollection.AddTransient<CustomerController>();
            serviceCollection.AddTransient<BookingCarDbContext>();
            serviceCollection.AddTransient<AccountController>();

            ServiceProvider = serviceCollection.BuildServiceProvider();
        }
    }

}
