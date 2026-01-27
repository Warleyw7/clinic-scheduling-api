using Microsoft.AspNetCore.Mvc;
using SistemaAgendamento.Application.DTOs.Agendamentos;
using SistemaAgendamento.Infrastructure.Context;

namespace SistemaAgendamento.Api.Controllers;
[ApiController]
[Route("[controller]")]
public class AgendamentoController(ClinicaDbContext context) : ControllerBase
{
    private readonly ClinicaDbContext _context = context;

    [HttpGet("{Id:int}")]
    public async Task<IActionResult> ObterPorId([FromRoute]int id)
    {
        var agendamento = await _context.Agendamentos.FindAsync(id);
        if(agendamento == null)
            return NotFound();
        return Ok();
    }
    [HttpPost]
    public async Task<IActionResult> Create([FromBody]CriaAgendamentoRequest agendamento)
    {
        if (agendamento == null)
            return NotFound();

        _context.Add(agendamento);
        _context.SaveChanges();
        return Ok();
    }
}