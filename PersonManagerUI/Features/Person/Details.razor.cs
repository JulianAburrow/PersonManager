namespace PersonManagerUI.Features.Person;

public partial class Details
{
    protected override void OnInitialized()
    {
        Person = PersonDb.GetPerson(PersonId);
        MainLayout.SetHeaderValue("Person Details");
    }        
}