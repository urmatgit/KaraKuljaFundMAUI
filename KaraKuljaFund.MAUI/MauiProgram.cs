using KaraKuljaFund.MAUI.Services;
using KaraKuljaFund.MAUI.ViewModels;
using KaraKuljaFund.MAUI.Views.Pages;
using KaraKuljaFund.MAUI.Views.Pages.RuralGov;
using KaraKuljaFund.Navigator.Interfaces.Services;
using KaraKuljaFund.Navigator.Interfaces.ViewModels;
using KaraKuljaFund.Navigator.ViewModels;
using Microsoft.Extensions.Logging;
using SimpleToolkit.Core;
using SimpleToolkit.SimpleShell;

namespace KaraKuljaFund.MAUI
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
                    fonts.AddFont("Nunito-Regular.ttf", "NunitoRegular");
                    fonts.AddFont("Nunito-Bold.ttf", "NunitoBold");
                    fonts.AddFont("Nunito-SemiBold.ttf", "NunitoSemiBold");
                });

            builder.UseSimpleShell();
            builder.UseSimpleToolkit();
#if IOS || ANDROID
            builder.DisplayContentBehindBars();
#endif
#if ANDROID
        builder.SetDefaultStatusBarAppearance(Colors.Transparent, false);
#endif

#if DEBUG
            builder.Logging.AddDebug();
#endif
            builder.Services.AddTransient<AppShell>();
            builder.Services.AddTransient<HomePage>();
            builder.Services.AddTransient<RuraGovContributionPage>();
            builder.Services.AddTransient<IKaraKuljaFundAPI, KaraKuljaFundAPI>();
            builder.Services.AddSingleton<INavigationService, NavigationService>();

            builder.Services.AddTransient<IHomePageViewModel, HomePageViewModel>();
            builder.Services.AddTransient<IRuraGovContributionViewModel, RuraGovContributionViewModel>();
            return builder.Build();
        }
    }
}
