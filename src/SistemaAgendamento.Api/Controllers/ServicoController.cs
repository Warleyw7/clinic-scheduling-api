using Microsoft.AspNetCore.Mvc;
using SistemaAgendamento.Infrastructure.Context;
using SistemaAgendamento.Application.DTOs.Servicos;

namespace SistemaAgendamento.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ServicoController(ClinicaDbContext context) : ControllerBase
{
    private readonly ClinicaDbContext _context = context;

    [HttpGet("{Id:int}")]
    public async Task<IActionResult> ObterPorId([FromRoute]int id)
    {
        var servico = _context.Servicos.FindAsync(id);
        if (await servico == null)
            return NotFound();

        return Ok(servico);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody]CriarServicoRequest servico)
    {
        if (string.IsNullOrWhiteSpace(servico.Nome))
            return BadRequest("Nome é obrigatório.");

        if (servico.DuracaoMinutos <= 0)
            return BadRequest("Duração deve ser maior que zero.");

        _context.Add(servico);
        _context.SaveChanges();
        return Ok(servico);

    }

    

    
}