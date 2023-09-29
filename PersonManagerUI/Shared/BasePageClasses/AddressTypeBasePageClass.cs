namespace PersonManagerUI.Shared.BasePageClasses
{
    public class AddressTypeBasePageClass : BasePageClass
    {
        [Inject] protected IAddressTypeHandler AddressTypeDb { get; set; }

        protected DisplayAddressTypeModel DisplayAddressType = new();

        [Parameter] public int AddressTypeId { get; set; }
    }
}
