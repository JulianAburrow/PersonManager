namespace PersonManagerUI.Features.Country;

public partial class Edit
{
    protected override async Task OnInitializedAsync()
    {
        var countryModel = await CountryDb.GetCountry(CountryId);
        DisplayCountry.CountryName = countryModel.CountryName;
        MainLayout.SetHeaderValue("Edit Country");
    }

    private async Task UpdateCountry()
    {
        var countryModel = new CountryModel
        {
            CountryId = CountryId,
            CountryName = DisplayCountry.CountryName
        };

        await CountryDb.UpdateCountry(countryModel);

        NavigationManager.NavigateTo($"/data/country/details/{CountryId}");
    }
}
