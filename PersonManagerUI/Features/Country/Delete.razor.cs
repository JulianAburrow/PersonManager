namespace PersonManagerUI.Features.Country;

public partial class Delete
{
    private bool OkToDelete = true;

    protected override async Task OnInitializedAsync()
    {
        Country = await CountryDb.GetCountry(CountryId);
        if (Country.People.Count > 0)
        {
            OkToDelete = false;
        }
        MainLayout.SetHeaderValue("Delete Country");
    }

    private async Task DeleteCountry()
    {
        await CountryDb.DeleteCountry(CountryId);

        NavigationManager.NavigateTo("data/countries/index");
    }
}
