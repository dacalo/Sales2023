using Microsoft.Extensions.Logging;
using Sales.Mobile.MVVM.Models;
using Sales.Mobile.MVVM.Repository;

namespace Sales.Mobile
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<CustomerRepository>();
            builder.Services.AddSingleton<BaseRepository<Customer>>();
            builder.Services.AddSingleton<BaseRepository<Order>>();

            return builder.Build();
        }
    }
}