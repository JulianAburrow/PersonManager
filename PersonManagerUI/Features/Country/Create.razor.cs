namespace PersonManagerUI.Features.Country;

public partial class Create
{
    protected override void OnInitialized() =>
        MainLayout.SetHeaderValue("Create Country");

    private async Task InsertCountry()
    {
        var countryModel = new CountryModel
        {
            CountryName = DisplayCountry.CountryName,
        };

        await CountryDb.InsertCountry(countryModel);

        NavigationManager.NavigateTo("/data/countries/index");
    }
}
