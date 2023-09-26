using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System.IO;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.Person
{
    public partial class Edit
    {
        private string FullName { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var p = PersonDb.GetPerson(PersonId);

            DisplayPerson.FirstName = p.FirstName;
            DisplayPerson.LastName = p.LastName;
            DisplayPerson.EmailAddress = p.EmailAddress;
            DisplayPerson.DateOfBirth = p.DateOfBirth;
            DisplayPerson.CountryId = p.CountryId;
            DisplayPerson.StatusId = p.StatusId;
            DisplayPerson.FavouriteColourId = p.FavouriteColourId ?? -1;
            DisplayPerson.Skillset = p.Skillset;
            DisplayPerson.Picture = p.Picture;
            DisplayPerson.HasPicture = p.HasPicture;

            FullName = $"{p.FirstName} {p.LastName}";

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
            var p = new PersonModel
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

            PersonDb.UpdatePerson(p);

            NavigationManager.NavigateTo($"/data/person/details/{PersonId}");
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
}
