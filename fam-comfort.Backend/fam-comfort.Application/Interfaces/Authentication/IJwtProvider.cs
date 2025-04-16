using fam_comfort.Core.Models;

namespace fam_comfort.Application.Interfaces.Authentication;

public interface IJwtProvider
{
    string GenerateToken(User user);
}