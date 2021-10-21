using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesMovie3.Data;
using RazorPagesMovie3.Models;

namespace RazorPagesMovie3.Pages.Hymns
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesMovie3.Data.RazorPagesMovie3Context _context;

        public CreateModel(RazorPagesMovie3.Data.RazorPagesMovie3Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Hymn Hymn { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Hymn.Add(Hymn);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
