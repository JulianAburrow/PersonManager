namespace PersonManagerUI.Features.Person;

public partial class Delete
{
    protected override void OnInitialized()
    {
        Person = PersonDb.GetPerson(PersonId);
        MainLayout.SetHeaderValue("Delete Person");
    }        

    protected void DeletePerson()
    {
        try
        {
            AddressDb.DeleteAddress(PersonId);
            PersonDb.DeletePerson(PersonId);
            Snackbar.Add($"{Person.FirstName} {Person.LastName} successfully deleted", Severity.Success);
            NavigationManager.NavigateTo("data/people/index");
        }
        catch
        {
            Snackbar.Add("Person not deleted. Please try later", Severity.Error);
        }
    }
}
