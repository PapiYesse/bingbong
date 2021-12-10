using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using bingbong.Models;

namespace bingbong.Pages.Gamer2
{
    public class DetailsModel : PageModel
    {
        private readonly bingbong.Models.GamerContext _context;

        public DetailsModel(bingbong.Models.GamerContext context)
        {
            _context = context;
        }

        public Gamer Gamer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Gamer = await _context.Gamer.FirstOrDefaultAsync(m => m.GamersId == id);

            if (Gamer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
