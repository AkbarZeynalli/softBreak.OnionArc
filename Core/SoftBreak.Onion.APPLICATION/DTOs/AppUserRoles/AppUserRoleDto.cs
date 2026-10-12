using System;
using System.Collections.Generic;
using System.Text;

namespace SoftBreak.Onion.APPLICATION.DTOs.AppUserRoles
{
    public class AppUserRoleDto : BaseDto
    {
        public int AppUserId { get; set; }
        public int AppRoleId { get; set; }
    }
}
