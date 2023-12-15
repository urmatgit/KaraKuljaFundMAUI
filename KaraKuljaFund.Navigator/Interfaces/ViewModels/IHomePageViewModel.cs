﻿using KaraKuljaFund.Navigator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraKuljaFund.Navigator.Interfaces.ViewModels
{
    public interface IHomePageViewModel : IBasePageViewModel
    {
        public   List<RuralGovDto> ruralGovDtos { get; }
    }
}