using JwtTokenApp.Api.Autenticacao;
using JwtTokenApp.Api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtTokenApp.Api.Controllers;

[Route("api/[controller]")]
[ApiController]

public class MissaoController(ITokenManager tokenManager) : ControllerBase
{
    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginRequest loginRequest)
    {
        if (string.IsNullOrWhiteSpace(loginRequest.Heroi))
            return NotFound();

        var heroi = Db.Herois.FirstOrDefault(x => x.Nome.ToLower() == loginRequest.Heroi.ToLower());

        if (heroi is null)
            return NotFound();

        var token = tokenManager.GenerateToken(heroi);

        return Ok(new LoginResponse(token));
    }

    [HttpGet("ficha-publica-herois")]
    public IActionResult ListarHeroisPublico()
    {
        var herois = Db.Herois.Select(x => x.Nome).ToList();

        if (herois is null)
            return NoContent();

        return Ok(herois);
    }

    [HttpGet("ficha-privada-herois")]
    [Authorize]
    public IActionResult ListarFichaHeroisPrivada()
    {
        var herois = Db.Herois.Select(x => x.Nome).ToList();

        if (herois is null)
            return NoContent();

        return Ok(herois);
    }
}

public record LoginRequest(string Heroi);

public record LoginResponse(string Token);