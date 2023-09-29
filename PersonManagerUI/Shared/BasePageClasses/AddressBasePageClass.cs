namespace PersonManagerUI.Shared.BasePageClasses;

public class AddressBasePageClass : BasePageClass
{
    [Inject] protected IAddressHandler AddressDb { get; set; }

    [Inject] protected IAddressTypeHandler AddressTypeDb { get; set; }

    protected List<AddressTypeModel> AddressTypes { get; set; }

    protected DisplayAddressModel DisplayAddress = new();

    [Parameter] public int PersonId { get; set; }

    [Parameter] public int AddressId { get; set; }

    protected override async Task OnInitializedAsync()
    {
        AddressTypes = await AddressTypeDb.GetAddressTypes();
    }
}
