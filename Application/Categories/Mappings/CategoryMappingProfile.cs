using Application.Categories.Commands.CreateCommand;
using AutoMapper;
using Domain.Categories;

namespace Application.Categories.Mappings;

public class CategoryMappingProfile : Profile
{
    public CategoryMappingProfile()
    {
        CreateMap<CreateCategoryCommand, Category>();
        CreateMap<Category, CategoryDto>();
    }
}
