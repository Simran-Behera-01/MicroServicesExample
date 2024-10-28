using AutoMapper;
using MicroServicesExample.Services.ProductApi.Models;
using MicroServicesExample.Services.ProductApi.Models.Dto;

namespace MicroServicesExample.Services.ProductApi
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>();
                config.CreateMap<Product, ProductDto>();
            });
            return mappingConfig;
        }
    }
}
