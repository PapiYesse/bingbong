using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using bingbong.Models;

namespace bingbong.Pages.Gamers
{
    public class EditModel : PageModel
    {
        private readonly bingbong.Models.GamerContext _context;

        public EditModel(bingbong.Models.GamerContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Gamers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GamersExists(Gamers.GamersId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool GamersExists(int id)
        {
            return _context.Gamer.Any(e => e.GamersId == id);
        }
    }
}
