using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using PersonManagerUI.Models;
using System.Collections.Generic;

namespace PersonManagerUI.BasePageClasses
{
    public class PersonBasePageClass : BasePageClass
    {
        [Inject] protected ICountryData CountryDb { get; set; }

        [Inject] protected IPersonData PersonDb { get; set; }

        [Inject] protected IStatusData StatusDb { get; set; }

        [Inject] protected IColourData ColourDb { get; set; }

        [Inject] protected IAddressData AddressDb { get; set; }

        protected DisplayPersonModel DisplayPerson = new();

        protected List<CountryModel> Countries { get; set; }

        protected List<StatusModel> Statuses { get; set; }

        protected List<ColourModel> Colours { get; set; }

        [Parameter] public int PersonId { get; set; }

        protected PersonModel Person = new();
    }
}
