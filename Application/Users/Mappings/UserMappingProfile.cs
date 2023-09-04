using Application.Users.Commands.CreateUser;
using AutoMapper;
using Domain.Users;

namespace Application.Users.Mappings;

public class UserMappingProfile : Profile
{
    public UserMappingProfile()
    {
        CreateMap<CreateUserCommand, User>();
    }
}
