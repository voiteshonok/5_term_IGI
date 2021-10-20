using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WEB_VOITESHONOK_953501.Data;
using WEB_VOITESHONOK_953501.Entities;

namespace WEB_VOITESHONOK_953501.Areas.Admin.Pages
{
    public class IndexModel : PageModel
    {
        private readonly WEB_VOITESHONOK_953501.Data.ApplicationDbContext _context;

        public IndexModel(WEB_VOITESHONOK_953501.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Dish> Dish { get;set; }

        public async Task OnGetAsync()
        {
            Dish = await _context.Dishes
                .Include(d => d.Group).ToListAsync();
        }
    }
}
