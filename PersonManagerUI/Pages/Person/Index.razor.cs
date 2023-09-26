using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;

namespace PersonManagerUI.Pages.Person
{
    public partial class Index
    {
        [Parameter] public string FirstInitial { get; set; }

        protected string Header = "People";

        protected List<PersonModel> People;

        protected string SearchTerm;

        protected List<string> FirstInitials;

        private bool FirstNameIsAscending { get; set; }

        protected bool LastNameIsAscending { get; set; }

        protected const string FirstName = "FirstName";

        protected const string LastName = "LastName";

        protected override void OnInitialized()
        {
            GetPeople();
            GetInitials();
        }

        protected void SearchPeople()
        {
            if (SearchTerm == null) return;

            SearchTerm = SearchTerm.ToLower();

            People = PersonDb.GetPeople()
                .Where(p =>
                    p.FirstName.ToLower().Contains(SearchTerm) ||
                    p.LastName.ToLower().Contains(SearchTerm))
                .OrderBy(p => p.FirstName)
                .ToList();

            Header = $"People with names containing '{SearchTerm}'";
        }

        protected void ClearSearch()
        {
            FirstInitial = null;
            SearchTerm = null;
            GetPeople();
            Header = "People";
            NavigationManager.NavigateTo("/data/people/index");
        }

        private void GetPeople()
        {
            People = PersonDb.GetPeople()
                .ToList();

            if (FirstInitial != null)
            {
                People = People
                    .Where(p => p.FirstName.StartsWith(FirstInitial))
                    .ToList();

                Header = $"People beginning with {FirstInitial.ToUpper()}";
            }

            People = People.OrderBy(p => p.FirstName).ToList();

            FirstNameIsAscending = true;
            LastNameIsAscending = false;
        }

        private void GetInitials()
        {
            FirstInitials = PersonDb.GetInitials();
        }

        protected void SortGrid(string whichColumn)
        {
            switch (whichColumn)
            {
                case FirstName:
                    People = FirstNameIsAscending
                        ? People.OrderByDescending(p => p.FirstName).ToList()
                        : People.OrderBy(p => p.FirstName).ToList();

                    FirstNameIsAscending = !FirstNameIsAscending;
                    LastNameIsAscending = false;
                    break;
                case LastName:
                    People = LastNameIsAscending
                        ? People.OrderByDescending(p => p.LastName).ToList()
                        : People = People.OrderBy(p => p.LastName).ToList();

                    LastNameIsAscending = !LastNameIsAscending;
                    FirstNameIsAscending = false;
                    break;
            }
        }
    }
}
