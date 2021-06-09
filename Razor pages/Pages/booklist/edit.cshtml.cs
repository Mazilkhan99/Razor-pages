using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_pages.model;

namespace Razor_pages.Pages.booklist
{
    public class editModel : PageModel
    {

        private dbclass _db;

        public editModel(dbclass db)
		{
            _db = db;
		}

        [BindProperty]
        public book book { get; set; }
        public async Task OnGetAsync(int id)
        {
			book = await _db.Book.FindAsync(id);
        }

		public async Task<IActionResult> OnPost()
		{
            if(ModelState.IsValid)
			{
                var BookFromDb = await _db.Book.FindAsync(book.id);
                BookFromDb.name = book.name;
                BookFromDb.author = book.author;
                BookFromDb.ISBN = book.ISBN;

                await _db.SaveChangesAsync();

                return RedirectToPage("Index");
                
            }
            return RedirectToPage();

		}
    }
}
