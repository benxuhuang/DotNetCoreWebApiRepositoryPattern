using AutoMapper;
using DotNetCoreWebApiRepositoryPattern.Models;
using DotNetCoreWebApiRepositoryPattern.Resources;

namespace DotNetCoreWebApiRepositoryPattern.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Movie, MovieResource>();
        }
    }
}