using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineMobileShop.Entity;

namespace OnlineMobileShop.App_Start
{
    public static class MapConfig
    {
        public static void Mapper()
        {
            AutoMapper.Mapper.Initialize(config =>
            {
                config.CreateMap<Models.SignUp, Account>();
                config.CreateMap<Models.LogIn, Account>();
                config.CreateMap<Models.AddMobiles, Mobile>();
                config.CreateMap<Mobile, Models.AddMobiles>();
                });
        }
    }
}