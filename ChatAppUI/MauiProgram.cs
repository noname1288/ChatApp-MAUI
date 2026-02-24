using ChatAppUI.Services;
using ChatAppUI.ViewModel;
using ChatAppUI.Views;
using Microsoft.Extensions.Logging;

namespace ChatAppUI;

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
                fonts.AddFont("Metropolis-Black.ttf", "Metropolis Black");
                fonts.AddFont("Metropolis-Light.ttf", "Metropolis Light");
                fonts.AddFont("Metropolis-Medium.ttf", "Metropolis Medium");
                fonts.AddFont("Metropolis-Regular.ttf", "Metropolis Regular");
            });
        //Service
        builder.Services.AddSingleton<MessageService>();
        builder.Services.AddSingleton<INavigationService, ShellNavigationService>();
        //ViewModel
        builder.Services.AddSingleton<HomePageViewModel>();
        builder.Services.AddTransient<DetailPageViewModel>();
        //UI
        builder.Services.AddSingleton<HomePage>();
        builder.Services.AddTransient<DetailPage>();
        

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}