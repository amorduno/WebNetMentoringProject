using AutoMapper;
using WebNetMentoringAPI.Dto;
using WebNetMentoringAPI.Models;

namespace WebNetMentoringAPI.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<Product, ProductDto>();
            CreateMap<CategoryDto, Category>();
            CreateMap<ProductDto, Product>();
        }
    }
}
