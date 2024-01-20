namespace PersonManagerUI.Features.AddressType
{
    public partial class Create
    {
        private bool AddressTypeAlreadyExists { get; set; }

        protected override void OnInitialized() =>
            MainLayout.SetHeaderValue("Create Address Type");

        private async Task InsertAddressType()
        {
            if (AddressTypeDb.AddressTypeExists(
                DisplayAddressType.AddressTypeName
                    .Replace(" ", "")
                    .ToLower()))
            {
                AddressTypeAlreadyExists = true;
                return;
            }

            var addressTypeModel = new AddressTypeModel { AddressTypeName = DisplayAddressType.AddressTypeName };

            await AddressTypeDb.InsertAddressType(addressTypeModel);

            NavigationManager.NavigateTo("/data/addresstypes/index");
        }
    }
}