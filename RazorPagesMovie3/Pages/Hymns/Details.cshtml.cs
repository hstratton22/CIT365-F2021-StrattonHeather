﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesMovie3.Data.RazorPagesMovie3Context _context;

        public DetailsModel(RazorPagesMovie3.Data.RazorPagesMovie3Context context)
        {
            _context = context;
        }

        public Hymn Hymn { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Hymn = await _context.Hymn.FirstOrDefaultAsync(m => m.ID == id);

            if (Hymn == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
