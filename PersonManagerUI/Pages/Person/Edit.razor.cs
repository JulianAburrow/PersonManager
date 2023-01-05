using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using PersonManagerUI.Models;

namespace PersonManagerUI.Pages.Person
{
    public partial class Edit : ComponentBase
    {
        [Inject] private IPersonData PeopleDb { get; set; }
        [Inject] private ICountryData CountriesDb { get; set; }
        [Inject] private IStatusData StatusesDb { get; set; }
        [Inject] private IColourData ColoursDb { get; set; }
        [Inject] private NavigationManager NavigationManager { get; set; }

        [Parameter]
        public int PersonId { get; set; }

        private readonly DisplayPersonModel person = new();

        private List<CountryModel> Countries { get; set; }

        private List<StatusModel> Statuses { get; set; }

        private List<ColourModel> Colours { get; set; }

        private string FullName { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var p = PeopleDb.GetPerson(PersonId);

            person.FirstName = p.FirstName;
            person.LastName = p.LastName;
            person.EmailAddress = p.EmailAddress;
            person.DateOfBirth = p.DateOfBirth;
            person.CountryId = p.CountryId;
            person.StatusId = p.StatusId;
            person.FavouriteColourId = p.FavouriteColourId ?? -1;
            person.Skillset = p.Skillset;
            person.Picture = p.Picture;
            person.HasPicture = p.HasPicture;

            FullName = $"{p.FirstName} {p.LastName}";

            Countries = await CountriesDb.GetCountries();
            Statuses = await StatusesDb.GetStatuses();
            Colours = await ColoursDb.GetColours();
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
                FirstName = person.FirstName,
                LastName = person.LastName,
                EmailAddress = person.EmailAddress,
                DateOfBirth = person.DateOfBirth,
                CountryId = person.CountryId,
                StatusId = person.StatusId,
                FavouriteColourId = person.FavouriteColourId != -1
                    ? person.FavouriteColourId
                        : null,
                Skillset = person.Skillset,
                Picture = person.HasPicture ? person.Picture : null
            };

            PeopleDb.UpdatePerson(p);

            NavigationManager.NavigateTo($"/data/person/details/{PersonId}");
        }

        private async void LoadFile(InputFileChangeEventArgs e)
        {
            await using var ms = new MemoryStream();
            await e.File.OpenReadStream().CopyToAsync(ms);
            person.Picture = ms.ToArray();
            person.HasPicture = true;
        }

        private void RemovePicture()
        {
            person.HasPicture = false;
        }
    }
}
