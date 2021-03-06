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
    public class IndexModel : PageModel
    {
        private readonly bingbong.Models.GamerContext _context;

        public IndexModel(bingbong.Models.GamerContext context)
        {
            _context = context;
        }

        public IList<Gamer> Gamer { get;set; }

        public async Task OnGetAsync()
        {
            Gamer = await _context.Gamer.ToListAsync();
        }
    }
}
