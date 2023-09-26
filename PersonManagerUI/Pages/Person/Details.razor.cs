namespace PersonManagerUI.Pages.Person
{
    public partial class Details
    {
        protected override void OnInitialized()
        {
            Person = PersonDb.GetPerson(PersonId);
        }
    }
}