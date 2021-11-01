using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DeskExperiment.Data;
using DeskExperiment.Models;

namespace DeskExperiment.Pages.DeskQuotes
{
    public class IndexModel : PageModel
    {
        private readonly DeskExperiment.Data.DeskExperimentContext _context;

        public IndexModel(DeskExperiment.Data.DeskExperimentContext context)
        {
            _context = context;
        }

        public IList<DeskQuote> DeskQuote { get;set; }

        public async Task OnGetAsync()
        {
            DeskQuote = await _context.DeskQuote.ToListAsync();
        }
    }
}
