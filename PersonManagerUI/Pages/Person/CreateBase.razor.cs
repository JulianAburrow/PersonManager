using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using PersonManagerUI.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PersonManagerUI.Pages.Person
{
    public class CreateBase : ComponentBase
    {
        [Inject] ICountryData _countriesDb { get; set; }
        [Inject] IPersonData _peopleDb { get; set; }
        [Inject] IStatusData _statusesDb { get; set; }
        [Inject] IColourData _colourDb { get; set; }
        [Inject] NavigationManager _navigationManager { get; set; }

        protected DisplayPersonModel newPerson = new();

        protected List<CountryModel> Countries { get; set; }

        protected List<StatusModel> Statuses { get; set; }

        protected List<ColourModel> Colours { get; set; }

        protected override void OnInitialized()
        {
            newPerson.CountryId = -1;
            newPerson.StatusId = -1;
            newPerson.FavouriteColourId = -1;

            const string pleaseSelect = "Please select";

            Countries = _countriesDb.GetCountries()
                .OrderBy(c => c.CountryName)
                .ToList();
            Countries.Insert(0, new CountryModel
            {
                CountryId = -1,
                CountryName = pleaseSelect
            });
            Statuses = _statusesDb.GetStatuses()
                .ToList();
            Statuses.Insert(0, new StatusModel
            {
                StatusId = -1,
                StatusName = pleaseSelect
            });
            Colours = _colourDb.GetColours()
                .OrderBy(c => c.ColourName)
                .ToList();
            Colours.Insert(0, new ColourModel
            {
                ColourId = -1,
                ColourName = "None"
            });
        }

        protected void InsertPerson()
        {
            var p = new PersonModel
            {
                FirstName = newPerson.FirstName,
                LastName = newPerson.LastName,
                EmailAddress = newPerson.EmailAddress,
                DateOfBirth = newPerson.DateOfBirth,
                CountryId = newPerson.CountryId,
                StatusId = newPerson.StatusId,
                FavouriteColourId = newPerson.FavouriteColourId != -1
                    ? newPerson.FavouriteColourId
                    : null,
                Picture = newPerson.Picture
            };

            _peopleDb.InsertPerson(p);

            _navigationManager.NavigateTo("/data/people/index");
        }

        protected async void LoadFile(InputFileChangeEventArgs e)
        {
            await using var ms = new MemoryStream();
            await e.File.OpenReadStream().CopyToAsync(ms);
            newPerson.Picture = ms.ToArray();
        }
    }
}
