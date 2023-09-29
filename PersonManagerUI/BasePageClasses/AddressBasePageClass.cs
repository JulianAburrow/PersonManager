using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using PersonManagerUI.Models;
using System.Collections.Generic;

namespace PersonManagerUI.BasePageClasses
{
    public class AddressBasePageClass : BasePageClass
    {
        [Inject] protected IAddressHandler AddressDb { get; set; }

        [Inject] protected IAddressTypeHandler AddressTypeDb { get; set; }

        protected List<AddressTypeModel> AddressTypes { get; set; }

        protected DisplayAddressModel DisplayAddress = new();

        [Parameter] public int PersonId { get; set; }

        [Parameter] public int AddressId { get; set; }
    }
}
