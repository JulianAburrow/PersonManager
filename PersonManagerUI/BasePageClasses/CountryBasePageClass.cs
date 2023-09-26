using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using PersonManagerUI.Models;

namespace PersonManagerUI.BasePageClasses
{
    public class CountryBasePageClass : BasePageClass
    {
        [Inject] protected ICountryData CountryDb { get; set; }

        protected DisplayCountryModel DisplayCountry = new();

        [Parameter] public int CountryId { get; set; }

        protected CountryModel Country;
    }
}
