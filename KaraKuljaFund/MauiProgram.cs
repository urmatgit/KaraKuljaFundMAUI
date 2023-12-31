﻿using KaraKuljaFund.Services;
using KaraKuljaFund.ViewModels.Interfaces;
using KaraKuljaFund.ViewModels;

using KaraKuljaFund.Views.RuralGov;


namespace KaraKuljaFund
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
                    fonts.AddFont("Mulish-Italic.ttf", "MulishItalic");
                    fonts.AddFont("Mulish.ttf", "Mulish");
                });

#if DEBUG
		builder.Logging.AddDebug();
#endif
            builder.Services.AddTransient<IKaraKuljaFundAPI, KaraKuljaFundAPI>();
            builder.Services.AddTransient<AppShell>();
            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<RuraGovPage>();
           // builder.Services.AddSingleton<INavigationService, NavigationService>();

            builder.Services.AddTransient<IMainViewModel, MainViewModel>();
            builder.Services.AddTransient<IRuralGovViewModel, RuralGovViewModel>();



            return builder.Build();
        }
    }
}