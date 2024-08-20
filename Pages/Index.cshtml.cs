using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookHive.Data;
using BookHive.Model;

namespace BookHive.Pages
{
    public class IndexModel : PageModel
    {
        private readonly BookDbContext _context;

        public IndexModel(BookDbContext context)
        {
            _context = context;
        }

        public IList<Book> Books { get; set; }

        public async Task OnGetAsync()
        {
            Books = await _context.Books.ToListAsync();
        }
    }
}
