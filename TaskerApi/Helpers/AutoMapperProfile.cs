using AutoMapper;
using TaskerApi.Models.Dtos;
using TaskerApi.Models.Oauth;

namespace TaskerApi.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }
    }
}