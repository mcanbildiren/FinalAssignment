using AutoMapper;
using FinalProject.Models;
using FinalProject.Models.ViewModels;

namespace FinalProject.Mappers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Post, PostViewModel>().ReverseMap();
            CreateMap<PostCreateViewModel, Post>().ReverseMap();
            CreateMap<PostUpdateViewModel, Post>().ReverseMap();
            CreateMap<Category, CategoryViewModel>().ReverseMap();
        }
    }
}
