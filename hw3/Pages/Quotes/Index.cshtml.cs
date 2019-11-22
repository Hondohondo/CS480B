using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using hw3.Data;
using hw3.Models;

namespace hw3.Pages.Quotes
{
    public class IndexModel : PageModel
    {
        private readonly hw3.Data.hw3Context _context;

        public IndexModel(hw3.Data.hw3Context context)
        {
            _context = context;
        }

        public IList<Quote> Quote { get;set; }

        public async Task OnGetAsync()
        {
            Quote = await _context.Quote.ToListAsync();
        }
    }
}
