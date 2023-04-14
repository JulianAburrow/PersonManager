using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.AddressType
{
    public partial class Index
    {
        [Inject] private IAddressTypeData AddressTypeDb { get; set; }
     
        private List<AddressTypeModel> addressTypes;

        protected override async Task OnInitializedAsync()
        {
            addressTypes = await AddressTypeDb.GetAddressTypes();
        }
    }
}
