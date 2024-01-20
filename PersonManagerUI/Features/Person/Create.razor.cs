namespace PersonManagerUI.Features.Person;

public partial class Create
{
    protected override async Task OnInitializedAsync()
    {
        DisplayPerson.CountryId = -1;
        DisplayPerson.StatusId = -1;
        DisplayPerson.FavouriteColourId = -1;

        const string PleaseSelect = "Please select";

        Countries = await CountryDb.GetCountries();
        Countries.Insert(0, new CountryModel
        {
            CountryId = -1,
            CountryName = PleaseSelect
        });
        Statuses = await StatusDb.GetStatuses();
        Statuses.Insert(0, new StatusModel
        {
            StatusId = -1,
            StatusName = PleaseSelect
        });
        Colours = await ColourDb.GetColours();
        Colours.Insert(0, new ColourModel
        {
            ColourId = -1,
            ColourName = "None"
        });

        MainLayout.SetHeaderValue("Create Person");
    }

    private async Task InsertPerson()
    {
        try
        {
            var personModel = new PersonModel
            {
                FirstName = DisplayPerson.FirstName,
                LastName = DisplayPerson.LastName,
                Skillset = DisplayPerson.Skillset,
                EmailAddress = DisplayPerson.EmailAddress,
                DateOfBirth = DisplayPerson.DateOfBirth,
                CountryId = DisplayPerson.CountryId,
                StatusId = DisplayPerson.StatusId,
                FavouriteColourId = DisplayPerson.FavouriteColourId != -1
                ? DisplayPerson.FavouriteColourId
                : null,
                Picture = DisplayPerson.Picture
            };

            await PersonDb.InsertPerson(personModel);
            Snackbar.Add($"{personModel.FirstName} {personModel.LastName} successfully added", Severity.Success);
            NavigationManager.NavigateTo("/data/people/index");
        }
        catch
        {
            Snackbar.Add("Person not added. Please try later", Severity.Error);
        }        
    }

    private async void LoadFile(InputFileChangeEventArgs e)
    {
        await using var ms = new MemoryStream();
        await e.File.OpenReadStream().CopyToAsync(ms);
        DisplayPerson.Picture = ms.ToArray();
    }
}
