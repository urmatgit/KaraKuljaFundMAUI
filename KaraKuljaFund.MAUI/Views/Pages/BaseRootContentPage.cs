using KaraKuljaFund.Navigator.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraKuljaFund.MAUI.Views.Pages
{
    public class BaseRootContentPage:BaseContentPage
    {
        public BaseRootContentPage(INavigationService navigationService) : base(navigationService)
        {
        }

        protected override void OnSafeAreaChanged(Thickness safeArea)
        {
            Padding = new Thickness(safeArea.Left, 0, safeArea.Right, safeArea.Bottom);
        }
    }
}
