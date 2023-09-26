using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonManagerUI.Pages.AddressType
{
    public partial class Index
    {     
        private List<AddressTypeModel> AddressTypes;

        protected override async Task OnInitializedAsync()
        {
            AddressTypes = await AddressTypeDb.GetAddressTypes();
        }
    }
}
