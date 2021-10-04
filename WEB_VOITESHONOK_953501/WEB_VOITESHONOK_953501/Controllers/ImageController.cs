using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WEB_VOITESHONOK_953501.Entities;

namespace WEB_VOITESHONOK_953501.Controllers
{
    public class ImageController : Controller
    {
        UserManager<ApplicationUser> _userManager;
        IWebHostEnvironment _env;

        public ImageController(UserManager<ApplicationUser> userManager, IWebHostEnvironment env)
        {
            _userManager = userManager;
            _env = env;
        }

        public async Task<FileResult> GetAvatar()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user.AvatarImage != null)
            {
                return File(user.AvatarImage, "images/...");
            }
            else
            {
                var avatarPath = "/Images/avatar.jpg";

                return File(_env.WebRootFileProvider
                    .GetFileInfo(avatarPath)
                    .CreateReadStream(), "images/...");
            }
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
