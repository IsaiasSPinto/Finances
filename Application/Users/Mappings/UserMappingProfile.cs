using Application.Users.Commands.CreateUser;
using Application.Users.Commands.UpdateUser;
using Application.Users.Queries;
using AutoMapper;
using Domain.Users;

namespace Application.Users.Mappings;

public class UserMappingProfile : Profile
{
    public UserMappingProfile()
    {
        CreateMap<CreateUserCommand, User>();
        CreateMap<User, UserDto>();
        CreateMap<UpdateUserCommand, User>();
    }
}
