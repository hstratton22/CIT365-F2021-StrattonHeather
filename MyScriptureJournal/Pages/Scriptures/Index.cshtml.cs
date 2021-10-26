using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyScriptureJournal.Data;
using MyScriptureJournal.Models;

namespace MyScriptureJournal.Pages.Scriptures
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournal.Data.MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournal.Data.MyScriptureJournalContext context)
        {
            _context = context;
        }

        public string BookSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentFilter2 { get; set; }
        public string CurrentSort { get; set; }
        public IList<Scripture> Scripture { get;set; }//Movie
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Topics { get; set; }//Genres
        [BindProperty(SupportsGet = true)]
        public string ScriptureTopic { get; set; }//MovieGenre

        public async Task OnGetAsync(string sortOrder, string searchString, string scriptureTopic)
        {
            //Scripture = await _context.Scripture.ToListAsync();
            BookSort = String.IsNullOrEmpty(sortOrder) ? "book_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";
            CurrentFilter = searchString;
            CurrentFilter2 = scriptureTopic;//


            IQueryable<Scripture> scriptureIQ = from o in _context.Scripture
                                                select o;

            if (!string.IsNullOrEmpty(searchString))
            {
                scriptureIQ = scriptureIQ.Where(o => o.Book.Contains(searchString));


            }
            if (!string.IsNullOrEmpty(scriptureTopic))
            {
                //scriptureIQ = scriptureIQ.Where(t => t.Topic == scriptureTopic);
                scriptureIQ = scriptureIQ.Where(t => t.Topic.Contains(scriptureTopic));

            }

                switch (sortOrder)
            {
                case "book_desc":
                    scriptureIQ = scriptureIQ.OrderByDescending(o => o.Book);
                    break;
                case "Date":
                    scriptureIQ = scriptureIQ.OrderBy(o => o.AddedDate);
                    break;
                case "date_desc": 
                    scriptureIQ = scriptureIQ.OrderByDescending(o => o.AddedDate);
                    break;
                default:
                    scriptureIQ = scriptureIQ.OrderBy(o => o.Book);
                    break;
            }
            /*
               // Use LINQ to get list of topics
               IQueryable<string> topicQuery = from s in _context.Scripture
                                              orderby s.Topic
                                              select s.Topic;
           
              var scriptures = from s in _context.Scripture
                               select s;
              if (!string.IsNullOrEmpty(SearchString))
              {
                  scriptures = scriptures.Where(sc => sc.
                  Book.Contains(SearchString));
              }
              if (!string.IsNullOrEmpty(ScriptureTopic))
              {
                  scriptures = scriptures.Where(t => t.Topic == ScriptureTopic);
              }*/
           // Topics = new SelectList(await topicQuery.Distinct().ToListAsync());

            //Scripture = await scriptures.ToListAsync();
            

            Scripture = await scriptureIQ.AsNoTracking().ToListAsync();
        }
        
    }
}
