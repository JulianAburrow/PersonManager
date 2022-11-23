using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;

namespace PersonManagerUI.Pages.AddressType
{
    public partial class Index : ComponentBase
    {
        [Inject] IAddressTypeData _addressTypeDb { get; set; }
     
        private List<AddressTypeModel> addressTypes;

        protected override void OnInitialized()
        {
            addressTypes = _addressTypeDb.GetAddressTypes()
                .OrderBy(a => a.AddressTypeName)
                .ToList();
        }
    }
}
