using KaraKuljaFund.Navigator.Interfaces.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace KaraKuljaFund.Navigator.Interfaces.Services
{
    public enum PageType
    {
        HomePage,
        RuraGovContributionPage,
        RurlaGovListPage,
        AboutPage
    }
    public interface INavigationService
    {
        Task GoTo(PageType pageType, IParameters? parameters = null);
        Task GoBack();
    }
}
