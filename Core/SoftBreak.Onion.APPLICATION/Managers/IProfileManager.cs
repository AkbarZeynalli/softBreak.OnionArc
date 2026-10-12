using SoftBreak.Onion.APPLICATION.DTOs.Profiles;
using SoftBreak.Onion.DOMAIN.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftBreak.Onion.APPLICATION.Managers
{
    public interface IProfileManager : IManager<AppUserProfile, ProfileDto>
    {
    }
}
