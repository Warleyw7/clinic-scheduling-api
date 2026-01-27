using Microsoft.AspNetCore.Mvc;
using SistemaAgendamento.Application.DTOs.Agendamentos;
using SistemaAgendamento.Application.DTOs.Usuarios;
using SistemaAgendamento.Infrastructure.Context;

namespace SistemaAgendamento.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class UsuarioController(ClinicaDbContext context) : ControllerBase
{
    private readonly ClinicaDbContext _context = context;

    [HttpGet("{Id:int}")]
    public async Task<IActionResult> ObterPorId([FromRoute] int id) 
    {
        var usuario = _context.Usuarios.FindAsync(id);
        if(usuario == null)
            return NotFound();

        return Ok(usuario);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CriarUsuarioRequest usuario) 
    {
        _context.Add(usuario);
        _context.SaveChanges();
        return Ok();
    }
}