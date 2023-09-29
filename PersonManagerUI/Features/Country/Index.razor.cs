namespace PersonManagerUI.Features.Country;

public partial class Index
{
    private List<CountryModel> Countries;

    protected override async Task OnInitializedAsync() =>
        Countries = await CountryDb.GetCountries();
}
