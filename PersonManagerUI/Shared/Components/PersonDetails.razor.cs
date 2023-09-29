namespace PersonManagerUI.Shared.Components;

public partial class PersonDetails
{

    [Parameter] public PersonModel Person { get; set; }

    [Parameter] public bool ShowPersonName { get; set; }
}
