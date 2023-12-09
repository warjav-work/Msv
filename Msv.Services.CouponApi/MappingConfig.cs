using AutoMapper;
using Msv.Services.CouponApi.Models;
using Msv.Services.CouponApi.Models.Dto;

namespace Msv.Services.CouponApi
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>();
                config.CreateMap<Coupon, CouponDto>();
            });
            return mappingConfig;
        }        

    }
}
