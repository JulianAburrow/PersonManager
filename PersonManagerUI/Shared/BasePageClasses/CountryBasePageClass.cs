using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using PersonManagerUI.Models;

namespace PersonManagerUI.Shared.BasePageClasses
{
    public class CountryBasePageClass : BasePageClass
    {
        [Inject] protected ICountryHandler CountryDb { get; set; }

        protected DisplayCountryModel DisplayCountry = new();

        [Parameter] public int CountryId { get; set; }

        protected CountryModel Country;
    }
}
