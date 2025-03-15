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
        var refreshToken = tokenManager.RefreshToken(heroi);

        return Ok(new LoginResponse(token, refreshToken));
    }

    public async Task<IActionResult> RefreshToken([FromBody] FereshTokenRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.token))
            return BadRequest();

        var validateToken = await tokenManager.ValidateToken(request.token);

        if (!validateToken.isValid)
            return Unauthorized();

        var heroi = Db.Herois.Where(x => x.Nome == validateToken.nomeHeroi).FirstOrDefault();

        if (heroi is null)
            return Unauthorized();

        var token = tokenManager.GenerateToken(heroi!);
        var refreshToken = tokenManager.RefreshToken(heroi!);

        return Ok(new LoginResponse(token, refreshToken));
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
        var herois = Db.Herois.ToList();

        if (herois is null)
            return NoContent();

        return Ok(herois);
    }

    [HttpGet("escalacao-missao")]
    [Authorize(Roles = Db.PODER_DESCRICAO_PODE_VOAR)]
    public IActionResult ListarHeroisEscalados()
    {
        var herois = Db.Herois
                       .Where(x => x.Poderes
                       .Any(p => p.Descricao == Db.PODER_DESCRICAO_PODE_VOAR)).ToArray();

        if (herois == null || herois.Count() == 0)
            return NoContent();

        return Ok(herois);
    }
}

public record LoginRequest(string Heroi);
public record FereshTokenRequest(string token);
public record LoginResponse(string Token, string RefreshToken);