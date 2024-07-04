using AutoMapper;
using MiniMicroProject.API.DTOs;
using MiniMicroProject.API.Models;

namespace MiniMicroProject.API.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Categories, CategoriesDto>().ReverseMap();
            CreateMap<Categories, CreateCategoryDto>().ReverseMap();
            CreateMap<Products, ProductsDto>().ReverseMap();
            CreateMap<Products, CreateProductDto>().ReverseMap();
        }
    }
}
