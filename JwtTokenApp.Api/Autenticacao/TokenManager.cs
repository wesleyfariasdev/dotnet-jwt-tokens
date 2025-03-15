using JwtTokenApp.Api.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JwtTokenApp.Api.Autenticacao;

public class TokenManager(IConfiguration configuration) : ITokenManager
{
    public string GenerateToken(Heroi heroi)
    {
        var jwtSettings = configuration.GetSection("JwtSettings");
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings["SecretKey"]!));

        var claims = new Claim[]
        {
            new (JwtRegisteredClaimNames.Sub, heroi.Nome),
            new (JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };

        foreach (var item in heroi.Poderes)
        {
            claims.Append(new Claim(ClaimTypes.Role, item.Descricao));
        }

        var tempoExpiration = jwtSettings.GetValue<int>("ExpirationTimeMinutes");

        var token = new JwtSecurityToken(issuer: jwtSettings.GetValue<string>("issuer"),
                                         audience: jwtSettings.GetValue<string>("audience"),
                                         claims: claims,
                                         expires: DateTime.UtcNow.AddMinutes(tempoExpiration),
                                         signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256)
                                         );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }

    public string RefreshToken(Heroi heroi)
    {
        var jwtSettings = configuration.GetSection("JwtSettings");
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings["SecretKey"]!));

        var claims = new Claim[]
        {
            new (JwtRegisteredClaimNames.Sub, heroi.Nome),
            new (JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };

        var tempoExpiration = jwtSettings.GetValue<int>("RefresheExpirationMinutes");

        var token = new JwtSecurityToken(issuer: jwtSettings.GetValue<string>("issuer"),
                                         audience: jwtSettings.GetValue<string>("audience"),
                                         claims: claims,
                                         expires: DateTime.UtcNow.AddMinutes(tempoExpiration),
                                         signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256)
                                         );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}
