using Microsoft.Extensions.Logging;

namespace AppLibertadoresHAS
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
         
                builder.Services.AddSingleton(Preferences.Default);
                builder.Services.AddSingleton(SecureStorage.Default);
            builder.Services.AddSingleton<SessionService>();
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

            return builder.Build();
        }
    }
}
