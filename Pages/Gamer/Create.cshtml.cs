using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using bingbong.Models;

namespace bingbong.Pages.Gamer2
{
    public class CreateModel : PageModel
    {
        private readonly bingbong.Models.GamerContext _context;

        public CreateModel(bingbong.Models.GamerContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Gamer Gamer { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Gamer.Add(Gamer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
