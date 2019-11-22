using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using hw3.Data;
using hw3.Models;

namespace hw3.Pages.Authors
{
    public class DetailsModel : PageModel
    {
        private readonly hw3.Data.hw3Context _context;

        public DetailsModel(hw3.Data.hw3Context context)
        {
            _context = context;
        }

        public Author Author { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Author = await _context.Author.FirstOrDefaultAsync(m => m.ID == id);

            if (Author == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
