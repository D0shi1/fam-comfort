using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using fam_comfort.Core.Models;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace fam_comfort.Infrastructure;

public class JwtProvider(IOptions<JwtOptions> options)
{
    private readonly JwtOptions _options = options.Value;

    public string GenerateToken(User user)
    {
        var signingCredentials = new SigningCredentials(
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_options.SecretKey)),
            SecurityAlgorithms.HmacSha256);
        
        Claim[] claims = [new("UserId", user.Id.ToString())];
        
        var token = new JwtSecurityToken(
            signingCredentials: signingCredentials,
            claims: claims,
            audience: _options.Audience,
            issuer: _options.Issuer,
            expires: DateTime.UtcNow.AddHours(_options.ExpirationHours)
            );
        
        var tokenHandler = new JwtSecurityTokenHandler().WriteToken(token);
        
        return tokenHandler;
    }
}