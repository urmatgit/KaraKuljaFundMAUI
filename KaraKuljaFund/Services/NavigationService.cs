using KaraKuljaFund.Navigator.Interfaces.Services;
using KaraKuljaFund.Navigator.Interfaces.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraKuljaFund.Services
{
    public class NavigationService : INavigationService
    {
        private const string ParametersKey = "Parameters";

        private readonly IList<PageType> rootPages = new List<PageType> {
        PageType.MainPage,
        PageType.RurlaGovListPage,
        PageType.AboutPage,
        
        };

        public void GoBack()
        {
            Shell.Current.GoToAsync("..");
        }

        public async void GoTo(PageType pageType, IParameters parameters = null)
        {
            await Shell.Current.GoToAsync(GetPageRoute(pageType), true, new Dictionary<string, object>
            {
                [ParametersKey] = parameters
            });
        }
        private string GetPageRoute(PageType pageType)
        {
            if (rootPages.Contains(pageType))
                return $"///{pageType.ToString()}";
            return pageType.ToString();
        }
    }
}
