using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BookListRazor.Pages.BookList

{ 
    public class IndexModel : PageModel
    {

    private readonly ApplicationDBContext _db;

        public IndexModel(ApplicationDBContext db) {_db = db; } 
       
        public System.Collections.Generic.IEnumerable<Book> Books { get; set; }
        public async Task OnGet()
        {
            Books = await _db.Book.ToListAsync();
        }
    }
}
