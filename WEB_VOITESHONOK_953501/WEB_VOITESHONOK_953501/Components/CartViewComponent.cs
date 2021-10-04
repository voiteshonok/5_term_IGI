using Microsoft.AspNetCore.Mvc;

namespace WEB_VOITESHONOK_953501.Components
{
    public class CartViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
