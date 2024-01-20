namespace PersonManagerUI.Features.AddressType;

public partial class Index
{     
    private List<AddressTypeModel> AddressTypes;

    protected override async Task OnInitializedAsync()
    {
        AddressTypes = await AddressTypeDb.GetAddressTypes();
        MainLayout.SetHeaderValue("Address Types");
    }
        
}
