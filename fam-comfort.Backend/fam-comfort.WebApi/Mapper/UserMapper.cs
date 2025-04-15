using fam_comfort.Core.Models;
using fam_comfort.WebApi.Contract;

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