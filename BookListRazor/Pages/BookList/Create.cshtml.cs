using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookListRazor.Pages.BookList
{
    public class CreateModel : PageModel
    {

        private readonly ApplicationDBContext _db;
        public CreateModel(ApplicationDBContext db)
        {
            _db = db;
        }

        public Book Book { get; set; }

        public void OnGet()
        {
        }
    }
}
