using Microsoft.Extensions.Logging;
using ThunderLINQ_MAUI.ViewModel;

namespace ThunderLINQ_MAUI
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
            
            builder.Services.AddTransient<NBATeamDetailsViewModel>();
            builder.Services.AddTransient<NBATeamDetailsPage>();

            return builder.Build();
        }
    }
}