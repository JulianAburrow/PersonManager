namespace PersonManagerUI.Shared.Components
{
    public partial class CountryDetails
    {
        [Parameter] public CountryModel Country { get; set; }

        [Parameter] public bool ShowCountryName { get; set; }
    }
}
