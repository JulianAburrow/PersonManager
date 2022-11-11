using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;

namespace PersonManagerUI.Pages.Person
{
    public partial class Index : ComponentBase
    {
        [Inject] IPersonData _personDb { get; set; }
        [Inject] NavigationManager _navigationManager { get; set; }

        [Parameter]
        public string firstInitial { get; set; }

        protected string header = "People";

        protected List<PersonModel> people;

        protected string searchTerm;

        protected List<string> firstInitials;

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
            if (searchTerm == null) return;

            searchTerm = searchTerm.ToLower();

            people = _personDb.GetPeople()
                .Where(p =>
                    p.FirstName.ToLower().Contains(searchTerm) ||
                    p.LastName.ToLower().Contains(searchTerm))
                .OrderBy(p => p.FirstName)
                .ToList();

            header = $"People with names containing '{searchTerm}'";
        }

        protected void ClearSearch()
        {
            firstInitial = null;
            searchTerm = null;
            GetPeople();
            header = "People";
            _navigationManager.NavigateTo("/data/people/index");
        }

        private void GetPeople()
        {
            people = _personDb.GetPeople()
                .ToList();

            if (firstInitial != null)
            {
                people = people
                    .Where(p => p.FirstName.StartsWith(firstInitial))
                    .ToList();

                header = $"People beginning with {firstInitial.ToUpper()}";
            }

            people = people.OrderBy(p => p.FirstName).ToList();

            FirstNameIsAscending = true;
            LastNameIsAscending = false;
        }

        private void GetInitials()
        {
            firstInitials = _personDb.GetInitials();
        }

        protected void SortGrid(string whichColumn)
        {
            switch (whichColumn)
            {
                case FirstName:
                    people = FirstNameIsAscending
                        ? people.OrderByDescending(p => p.FirstName).ToList()
                        : people.OrderBy(p => p.FirstName).ToList();

                    FirstNameIsAscending = !FirstNameIsAscending;
                    LastNameIsAscending = false;
                    break;
                case LastName:
                    people = LastNameIsAscending
                        ? people.OrderByDescending(p => p.LastName).ToList()
                        : people = people.OrderBy(p => p.LastName).ToList();

                    LastNameIsAscending = !LastNameIsAscending;
                    FirstNameIsAscending = false;
                    break;
            }
        }
    }
}
