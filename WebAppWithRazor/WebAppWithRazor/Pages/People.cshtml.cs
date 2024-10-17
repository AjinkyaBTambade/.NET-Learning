using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppWithBlazor.Models; 

namespace WebAppWithRazor.Pages
{
    public class PeopleModel : PageModel
    {
        private readonly MyDbContext _context;

        public List<Person> People {get; set;} = new List<Person>();

        [BindProperty]
        public Person NewPerson { get; set; }

        // Constructor that accepts MyDbContext via dependency injection
        public PeopleModel(MyDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
          People = _context.People.ToList();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();  
            }

            _context.People.Add(NewPerson);  
            _context.SaveChanges(); 

            return RedirectToPage();  
        }
    }
}
