namespace PersonManagerUI.Features.Country;

public partial class Details
{
    protected override async Task OnInitializedAsync() =>
        Country = await CountryDb.GetCountry(CountryId);
}
