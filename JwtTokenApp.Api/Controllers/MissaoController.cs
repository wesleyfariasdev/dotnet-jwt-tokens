using JwtTokenApp.Api.Autenticacao;
using JwtTokenApp.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace JwtTokenApp.Api.Controllers;

[Route("api/[controller]")]
[ApiController]

public class MissaoController(ITokenManager tokenManager) : ControllerBase
{
    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest loginRequest)
    {
        if (string.IsNullOrWhiteSpace(loginRequest.Heroi))
            return NotFound();

        var heroi = Db.Herois.FirstOrDefault(x => x.Nome.ToLower() == loginRequest.Heroi.ToLower());

        if (heroi is null)
            return NotFound();

        var token = tokenManager.GenerateToken(heroi);

        return Ok(new LoginResponse(token));
    }
}

public record LoginRequest(string Heroi);

public record LoginResponse(string Token);