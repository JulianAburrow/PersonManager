using DataAccessLibrary.Interfaces;
using Microsoft.AspNetCore.Components;
using PersonManagerUI.Models;

namespace PersonManagerUI.BasePageClasses
{
    public class AddressTypeBasePageClass : BasePageClass
    { 
        [Inject] protected IAddressTypeData AddressTypeDb { get; set; }

        protected DisplayAddressTypeModel DisplayAddressType = new();

        [Parameter] public int AddressTypeId { get; set; }
    }
}
