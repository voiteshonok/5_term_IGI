using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WEB_VOITESHONOK_953501.Data;
using WEB_VOITESHONOK_953501.Entities;
using WEB_VOITESHONOK_953501.Extensions;
using WEB_VOITESHONOK_953501.Models;

namespace WEB_VOITESHONOK_953501.Controllers
{
    public class ProductController : Controller
    {
        ApplicationDbContext _context;

        int _pageSize;

        [Route("Catalog")]
        [Route("Catalog/Page_{pageNo}")]
        public IActionResult Index(int? group, int pageNo=1)
        {
            var dishesFiltered = _context.Dishes.Where(d => !group.HasValue || d.DishGroupId == group.Value);
            // Поместить список групп во ViewData
            ViewData["Groups"] = _context.DishGroups;
            ViewData["CurrentGroup"] = group ?? 0;

            //var dishesFiltered = _dishes.Where(d => !group.HasValue || d.DishGroupId == group.Value);

            var model = ListViewModel<Dish>.GetModel(dishesFiltered, pageNo, _pageSize);
            if (Request.IsAjaxRequest())
                return PartialView("_listpartial", model);
            else
                return View(model);
        }

        public ProductController(ApplicationDbContext context)
        {
            _pageSize = 3;
            _context = context;
        }
    }
}
