namespace PersonManagerUI.Features.AddressType;

public partial class Edit
{
    private string AddressTypeDisplayName { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var a = await AddressTypeDb.GetAddressType(AddressTypeId);

        DisplayAddressType.AddressTypeName = a.AddressTypeName;

        AddressTypeDisplayName = DisplayAddressType.AddressTypeName;

        MainLayout.SetHeaderValue("Edit Address Type");
    }

    private async Task UpdateAddressType()
    {
        var addressTypeModel = new AddressTypeModel
        {
            AddressTypeId = AddressTypeId,
            AddressTypeName = DisplayAddressType.AddressTypeName
        };

        await AddressTypeDb.UpdateAddressType(addressTypeModel);

        NavigationManager.NavigateTo("/data/addresstypes/index");
    }
}
