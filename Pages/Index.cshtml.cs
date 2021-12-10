using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using bingbong.Models;

namespace bingbong.Pages
{
    public class IndexModel : PageModel
    {
        // private readonly GamerContext _context; //Replaces DB variable

        private readonly ILogger<IndexModel> _logger;

        public List<Gamer> Gamer {get; set;}

        // public SelectList GamerDropDown {get; set;}

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
