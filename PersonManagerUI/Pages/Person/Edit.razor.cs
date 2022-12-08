using System.Collections.Generic;
using System.IO;
using System.Linq;
using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using PersonManagerUI.Models;

namespace PersonManagerUI.Pages.Person
{
    public partial class Edit : ComponentBase
    {
        [Inject] private IPersonData _peopleDb { get; set; }
        [Inject] ICountryData _countriesDb { get; set; }
        [Inject] IStatusData _statusesDb { get; set; }
        [Inject] IColourData _coloursDb { get; set; }
        [Inject] NavigationManager _navigationManager { get; set; }

        [Parameter]
        public int PersonId { get; set; }

        protected DisplayPersonModel person = new();

        protected List<CountryModel> Countries { get; set; }

        protected List<StatusModel> Statuses { get; set; }

        protected List<ColourModel> Colours { get; set; }

        protected string FullName { get; set; }

        protected override async void OnInitialized()
        {
            var p = _peopleDb.GetPerson(PersonId);

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

            Countries = await _countriesDb.GetCountries();
            Statuses = _statusesDb.GetStatuses()
                .ToList();
            Colours = _coloursDb.GetColours()
                .OrderBy(c => c.ColourName)
                .ToList();
            Colours.Insert(0, new ColourModel
            {
                ColourId = -1,
                ColourName = "None"
            });
        }

        protected void UpdatePerson()
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

            _peopleDb.UpdatePerson(p);

            _navigationManager.NavigateTo($"/data/person/details/{PersonId}");
        }

        protected async void LoadFile(InputFileChangeEventArgs e)
        {
            await using var ms = new MemoryStream();
            await e.File.OpenReadStream().CopyToAsync(ms);
            person.Picture = ms.ToArray();
            person.HasPicture = true;
        }

        protected void RemovePicture()
        {
            person.HasPicture = false;
        }
    }
}
