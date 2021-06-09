using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Razor_pages.model;

namespace Razor_pages.Pages.booklist
{
    public class IndexModel : PageModel
    {

        private readonly dbclass _db;

		public IndexModel(dbclass db)
		{
            _db = db;
		}

        public IEnumerable<book> books { get; set; }
		public async Task OnGet()
        {
            books = await _db.Book.ToListAsync();
        }

        public async Task<IActionResult> OnPostDelete(int id)
		{
            var book = await _db.Book.FindAsync(id);
            if (book == null)
			{
                return NotFound();
			}
            _db.Book.Remove(book);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");

		}
    }
}
