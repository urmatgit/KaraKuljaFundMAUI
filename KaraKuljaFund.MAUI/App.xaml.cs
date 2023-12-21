

namespace KaraKuljaFund.MAUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
        //protected override void OnHandlerChanged()
        //{
        //    base.OnHandlerChanged();
        //    MainPage =  this.Handler.MauiContext.Services.GetRequiredService<AppShell>();
        //}
    }
}
