using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;

namespace PersonManagerUI.Components
{
    public partial class CountryDetails
    {
        [Parameter]
        public CountryModel Country { get; set; }

        [Parameter]
        public bool ShowCountryName { get; set; }
    }
}
