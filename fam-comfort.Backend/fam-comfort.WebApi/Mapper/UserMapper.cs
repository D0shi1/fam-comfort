using fam_comfort.Application.Contract.Dto;
using fam_comfort.Core.Models;

namespace fam_comfort.WebApi.Mapper;

public static class UserMapper
{
    public static UserDto ToDto(this User user)
    {
        return new UserDto()
        {
            Username = user.Username
        };
    }
}