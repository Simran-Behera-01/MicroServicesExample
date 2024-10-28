using AutoMapper;
using MicroServicesExample.Services.CouponApi.Models;
using MicroServicesExample.Services.CouponApi.Models.Dto;

namespace MicroServicesExample.Services.CouponApi
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
