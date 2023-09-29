namespace PersonManagerUI.Features.Person;

public partial class Delete
{
    protected override void OnInitialized() =>
        Person = PersonDb.GetPerson(PersonId);

    protected void DeletePerson()
    {
        AddressDb.DeleteAddress(PersonId);
        PersonDb.DeletePerson(PersonId);

        NavigationManager.NavigateTo("data/people/index");
    }
}
