using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using PersonManagerUI.Models;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.Person
{
    public partial class Create : ComponentBase
    {
        [Inject] private ICountryData CountriesDb { get; set; }
        [Inject] private IPersonData PeopleDb { get; set; }
        [Inject] private IStatusData StatusesDb { get; set; }
        [Inject] private IColourData ColourDb { get; set; }
        [Inject] private NavigationManager NavigationManager { get; set; }

        private readonly DisplayPersonModel newPerson = new();

        private List<CountryModel> Countries { get; set; }

        private List<StatusModel> Statuses { get; set; }

        private List<ColourModel> Colours { get; set; }

        protected override async Task OnInitializedAsync()
        {
            newPerson.CountryId = -1;
            newPerson.StatusId = -1;
            newPerson.FavouriteColourId = -1;

            const string pleaseSelect = "Please select";

            Countries = await CountriesDb.GetCountries();
            Countries.Insert(0, new CountryModel
            {
                CountryId = -1,
                CountryName = pleaseSelect
            });
            Statuses = await StatusesDb.GetStatuses();
            Statuses.Insert(0, new StatusModel
            {
                StatusId = -1,
                StatusName = pleaseSelect
            });
            Colours = await ColourDb.GetColours();
            Colours.Insert(0, new ColourModel
            {
                ColourId = -1,
                ColourName = "None"
            });
        }

        private async Task InsertPerson()
        {
            var p = new PersonModel
            {
                FirstName = newPerson.FirstName,
                LastName = newPerson.LastName,
                Skillset = newPerson.Skillset,
                EmailAddress = newPerson.EmailAddress,
                DateOfBirth = newPerson.DateOfBirth,
                CountryId = newPerson.CountryId,
                StatusId = newPerson.StatusId,
                FavouriteColourId = newPerson.FavouriteColourId != -1
                    ? newPerson.FavouriteColourId
                    : null,
                Picture = newPerson.Picture
            };

            await PeopleDb.InsertPerson(p);

            NavigationManager.NavigateTo("/data/people/index");
        }

        private async void LoadFile(InputFileChangeEventArgs e)
        {
            await using var ms = new MemoryStream();
            await e.File.OpenReadStream().CopyToAsync(ms);
            newPerson.Picture = ms.ToArray();
        }
    }
}
