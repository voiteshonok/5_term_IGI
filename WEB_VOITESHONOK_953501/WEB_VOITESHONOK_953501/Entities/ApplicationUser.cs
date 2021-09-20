﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_VOITESHONOK_953501.Entities
{
    public class ApplicationUser: IdentityUser
    {
        public byte[] AvatarImage { get; set; }
    }
}
