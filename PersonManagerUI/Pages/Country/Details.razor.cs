﻿using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc.Formatters;
using PersonManagerUI.Components;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.Country
{
    public partial class Details
    {
        [Inject] ICountryData _countryDb { get; set; }

        [Parameter]
        public int CountryId { get; set; }

        private CountryModel country;

        protected async override Task OnInitializedAsync()
        {
            country = await _countryDb.GetCountry(CountryId);
        }

    }
}
