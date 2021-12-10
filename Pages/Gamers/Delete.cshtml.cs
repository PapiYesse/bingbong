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
    public class DeleteModel : PageModel
    {
        private readonly bingbong.Models.GamerContext _context;

        public DeleteModel(bingbong.Models.GamerContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Gamers = await _context.Gamer.FindAsync(id);

            if (Gamers != null)
            {
                _context.Gamer.Remove(Gamers);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
