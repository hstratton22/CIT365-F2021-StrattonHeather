using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie3.Data;
using RazorPagesMovie3.Models;

namespace RazorPagesMovie3.Pages.Hymns
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovie3.Data.RazorPagesMovie3Context _context;

        public IndexModel(RazorPagesMovie3.Data.RazorPagesMovie3Context context)
        {
            _context = context;
        }

        public IList<Hymn> Hymn { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public async Task OnGetAsync()
        {
            var hymns = from h in _context.Hymn
                         select h;
            if (!string.IsNullOrEmpty(SearchString))
            {
                hymns = hymns.Where(s => s.Title.Contains(SearchString));
            }

            //Hymn = await _context.Hymn.ToListAsync();
            Hymn = await hymns.ToListAsync();
        }
    }
}
