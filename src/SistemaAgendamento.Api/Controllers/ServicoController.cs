using Microsoft.AspNetCore.Mvc;
using SistemaAgendamento.Infrastructure.Context;
using SistemaAgendamento.Application.DTOs;
using SistemaAgendamento.Application.DTOs.Servicos;
using SistemaAgendamento.Infrastructure.Context;

namespace SistemaAgendamento.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ServicoController : ControllerBase
{
    private readonly ClinicaDbContext _context;

    public ServicoController( ClinicaDbContext context)
    {
        _context = context;
    }    

    [HttpGet("{ObterPorId}")]
    public IActionResult ObterPorId(int id)
    {
        var servico = _context.Servicos.Find(id);
        if(servico == null )
            return NotFound();

        return Ok(servico);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CriarServicoRequest servico)
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