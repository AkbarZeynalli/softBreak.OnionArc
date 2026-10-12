using AutoMapper;
using SoftBreak.Onion.APPLICATION.DTOs.AppRoles;
using SoftBreak.Onion.APPLICATION.DTOs.AppUserRoles;
using SoftBreak.Onion.APPLICATION.DTOs.AppUsers;
using SoftBreak.Onion.APPLICATION.DTOs.Categories;
using SoftBreak.Onion.APPLICATION.DTOs.OrderDetails;
using SoftBreak.Onion.APPLICATION.DTOs.Orders;
using SoftBreak.Onion.APPLICATION.DTOs.Profiles;
using SoftBreak.Onion.DOMAIN.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftBreak.Onion.APPLICATION.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            #region ProductMapping
            CreateMap<Product, Product>().ReverseMap();
            #endregion

            #region CategoryMapping
            CreateMap<Catregories,CategoryDto>().ReverseMap();
            #endregion

            #region OrderMapping
            CreateMap<Order, OrderDto>().ReverseMap();
            #endregion

            #region OrderDetailMapping
            CreateMap<OrderDetail, OrderDetailDto>().ReverseMap();
            #endregion

            #region AppRoleMapping
            CreateMap<AppRole, AppRoleDto>().ReverseMap();
            #endregion

            #region AppUserRoleMapping
            CreateMap<AppUserRole, AppUserRoleDto>().ReverseMap();
            #endregion

            #region AppUserProfileMapping
            CreateMap<AppUserProfile, ProfileDto>().ReverseMap();
            #endregion

            #region AppUserMapping
            CreateMap<AppUser, AppUserDto>().ReverseMap();
            #endregion

            #region
            #endregion

            #region
            #endregion
        }
    }
}
