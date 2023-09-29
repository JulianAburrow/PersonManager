using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using PersonManagerUI.Models;
using System.Collections.Generic;

namespace PersonManagerUI.BasePageClasses
{
    public class PersonBasePageClass : BasePageClass
    {
        [Inject] protected ICountryHandler CountryDb { get; set; }

        [Inject] protected IPersonHandler PersonDb { get; set; }

        [Inject] protected IStatusHandler StatusDb { get; set; }

        [Inject] protected IColourHandler ColourDb { get; set; }

        [Inject] protected IAddressHandler AddressDb { get; set; }

        protected DisplayPersonModel DisplayPerson = new();

        protected List<CountryModel> Countries { get; set; }

        protected List<StatusModel> Statuses { get; set; }

        protected List<ColourModel> Colours { get; set; }

        [Parameter] public int PersonId { get; set; }

        protected PersonModel Person = new();
    }
}
