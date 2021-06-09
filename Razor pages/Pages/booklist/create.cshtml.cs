using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_pages.model;

namespace Razor_pages.Pages.booklist
{
    public class CreateModel : PageModel
	{
		private readonly dbclass _db;

        public CreateModel(dbclass db)
		{
            _db = db;
		}

        [BindProperty]
        public book book { get; set; }
        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
		{
            if(ModelState.IsValid)
			{
                 await _db.Book.AddAsync(book);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
			}
        else
        {
            return Page();
        }
		}

    }
}
