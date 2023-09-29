namespace PersonManagerUI.Features.Address
{
    public partial class Index
    {
        [Inject] private IPersonHandler PersonDb { get; set; }

        private PersonModel personModel = new();

        private List<AddressModel> Addresses = new();

        protected override async Task OnInitializedAsync()
        {
            Addresses = await AddressDb.GetAddresses(PersonId);
            personModel = PersonDb.GetPerson(PersonId);
        }
    }
}
