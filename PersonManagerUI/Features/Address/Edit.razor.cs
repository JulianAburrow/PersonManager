namespace PersonManagerUI.Features.Address;

public partial class Edit
{
    protected override async Task OnInitializedAsync()
    {
        var addressModel = await AddressDb.GetAddress(AddressId);

        DisplayAddress.AddressLine1 = addressModel.AddressLine1;
        DisplayAddress.AddressLine2 = addressModel.AddressLine2;
        DisplayAddress.Town = addressModel.Town;
        DisplayAddress.Postcode = addressModel.Postcode;
        DisplayAddress.AddressTypeId = addressModel.AddressTypeId;

        PersonId = addressModel.PersonId;

        await base.OnInitializedAsync();
    }

    private async Task UpdateAddress()
    {
        var addressModel = new AddressModel
        {
            AddressId = AddressId,
            AddressLine1 = DisplayAddress.AddressLine1,
            AddressLine2 = DisplayAddress.AddressLine2,
            Town = DisplayAddress.Town,
            Postcode = DisplayAddress.Postcode,
            AddressTypeId = DisplayAddress.AddressTypeId
        };

        await AddressDb.UpdateAddress(addressModel);

        NavigationManager.NavigateTo($"data/addresses/index/{PersonId}");
    }
}
