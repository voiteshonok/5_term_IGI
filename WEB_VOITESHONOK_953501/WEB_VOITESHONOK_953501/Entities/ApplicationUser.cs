using Microsoft.AspNetCore.Identity;

namespace WEB_VOITESHONOK_953501.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public byte[] AvatarImage { get; set; }
    }
}
