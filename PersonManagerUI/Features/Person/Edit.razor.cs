namespace PersonManagerUI.Features.Person;

public partial class Edit
{
    private string FullName { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var personModel = PersonDb.GetPerson(PersonId);

        DisplayPerson.FirstName = personModel.FirstName;
        DisplayPerson.LastName = personModel.LastName;
        DisplayPerson.EmailAddress = personModel.EmailAddress;
        DisplayPerson.DateOfBirth = personModel.DateOfBirth;
        DisplayPerson.CountryId = personModel.CountryId;
        DisplayPerson.StatusId = personModel.StatusId;
        DisplayPerson.FavouriteColourId = personModel.FavouriteColourId ?? -1;
        DisplayPerson.Skillset = personModel.Skillset;
        DisplayPerson.Picture = personModel.Picture;
        DisplayPerson.HasPicture = personModel.HasPicture;

        FullName = $"{personModel.FirstName} {personModel.LastName}";

        Countries = await CountryDb.GetCountries();
        Statuses = await StatusDb.GetStatuses();
        Colours = await ColourDb.GetColours();
        Colours.Insert(0, new ColourModel
        {
            ColourId = -1,
            ColourName = "None"
        });
    }

    private void UpdatePerson()
    {
        try
        {
            var personModel = new PersonModel
            {
                PersonId = PersonId,
                FirstName = DisplayPerson.FirstName,
                LastName = DisplayPerson.LastName,
                EmailAddress = DisplayPerson.EmailAddress,
                DateOfBirth = DisplayPerson.DateOfBirth,
                CountryId = DisplayPerson.CountryId,
                StatusId = DisplayPerson.StatusId,
                FavouriteColourId = DisplayPerson.FavouriteColourId != -1
                ? DisplayPerson.FavouriteColourId
                    : null,
                Skillset = DisplayPerson.Skillset,
                Picture = DisplayPerson.HasPicture ? DisplayPerson.Picture : null
            };

            PersonDb.UpdatePerson(personModel);
            Snackbar.Add($"{personModel.FirstName} {personModel.LastName} successfully updated", Severity.Success);
            NavigationManager.NavigateTo($"/data/person/details/{PersonId}");
        }
        catch
        {
            Snackbar.Add("Person not updated. Please try later", Severity.Error);
        }
    }

    private async void LoadFile(InputFileChangeEventArgs e)
    {
        await using var ms = new MemoryStream();
        await e.File.OpenReadStream().CopyToAsync(ms);
        DisplayPerson.Picture = ms.ToArray();
        DisplayPerson.HasPicture = true;
    }

    private void RemovePicture()
    {
        DisplayPerson.HasPicture = false;
    }
}
