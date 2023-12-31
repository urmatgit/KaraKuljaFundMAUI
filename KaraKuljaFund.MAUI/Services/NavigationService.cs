﻿using KaraKuljaFund.MAUI.Views.Pages.RuralGov;
using KaraKuljaFund.Navigator.Interfaces.Services;
using KaraKuljaFund.Navigator.Interfaces.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraKuljaFund.MAUI.Services
{
    public class NavigationService : INavigationService
    {
        private const string ParametersKey = "Parameters";

        private readonly IList<PageType> rootPages = new List<PageType> {
        PageType.HomePage,
        
        PageType.RurlaGovListPage,
        PageType.AboutPage

    };


        public NavigationService()
        {
        }
        

        public async Task GoBack()
        {
            await Shell.Current.Navigation.PopAsync();
            //            await Shell.Current.Navigation.PopAsync(true);
            //await Shell.Current.GoToAsync("..");
        }
        public async Task GoTo(PageType pageType, Dictionary<string, object> parameters = null)
        {
            await Shell.Current.GoToAsync(GetPageRoute(pageType), true, new Dictionary<string, object>
            {
                [ParametersKey] = parameters
            });
        }
        public async Task GoTo(PageType pageType, IParameters parameters = null)
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
