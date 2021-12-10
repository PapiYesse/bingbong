using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using bingbong.Models;

namespace bingbong.Pages.Gamers
{
    public class DetailsModel : PageModel
    {
        private readonly bingbong.Models.GamerContext _context;

        public DetailsModel(bingbong.Models.GamerContext context)
        {
            _context = context;
        }

        public Gamers Gamers { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Gamers = await _context.Gamer.FirstOrDefaultAsync(m => m.GamersId == id);

            if (Gamers == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
