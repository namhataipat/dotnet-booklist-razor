using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookListRazor.Pages.BookList

{ 
    public class IndexModel : PageModel
    {

    private readonly ApplicationDBContext _db;

        public IndexModel(ApplicationDBContext db) {_db = db; } 
       
        public IEnumerable<Book> Books { get; set; }
        public void OnGet()
        {
        }
    }
}
