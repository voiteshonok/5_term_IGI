using Microsoft.AspNetCore.Mvc;
using WEB_VOITESHONOK_953501.Extensions;
using WEB_VOITESHONOK_953501.Models;

namespace WEB_VOITESHONOK_953501.Components
{
    public class CartViewComponent : ViewComponent
    {
        private Cart _cart;
        public CartViewComponent(Cart cart)
        {
            _cart = cart;
        }

        public IViewComponentResult Invoke()
        {
            return View(_cart);
        }
    }
}
