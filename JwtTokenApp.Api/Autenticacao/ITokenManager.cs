using JwtTokenApp.Api.Models;

namespace JwtTokenApp.Api.Autenticacao;

public interface ITokenManager
{
    string GenerateToken(Heroi heroi);
    string RefreshToken(Heroi heroi);
    Task<(bool isValid, string? nomeHeroi)> ValidateToken(string token);
}
