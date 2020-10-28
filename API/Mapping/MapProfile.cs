using API.DTOs;
using AutoMapper;
using Core.Models;

namespace API.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();
            CreateMap<Blog, BlogDto>();
            CreateMap<BlogDto, Blog>();
            CreateMap<CategoryWithBlogDto, Category>();
            CreateMap<Category, CategoryWithBlogDto>();
            CreateMap<Blog, BlogWithCategoryDto>();
            CreateMap<BlogWithCategoryDto, Blog>();
        }
    }
}
