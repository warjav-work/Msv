using AutoMapper;
using Msv.Services.ProductApi.Models;
using Msv.Services.ProductApi.Models.Dto;


namespace Msv.Services.ProductApi
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
