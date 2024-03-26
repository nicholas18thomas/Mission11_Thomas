using Microsoft.AspNetCore.Mvc;
using Mission11_Thomas.Models;

namespace Mission11_Thomas.Components
{
    public class ProjectTypesViewComponent : ViewComponent
    {
        private IBookRepository _repo;

        //Constructor
        public ProjectTypesViewComponent(IBookRepository temp) 
        {
            _repo = temp;
        }

        public IViewComponentResult Invoke()
        {
            var bookTypes = _repo.Books
                .Select(x => x.Title)
                .Distinct()
                .OrderBy(x => x)
                .ToList();

            return View(bookTypes);
        }
    }
}
