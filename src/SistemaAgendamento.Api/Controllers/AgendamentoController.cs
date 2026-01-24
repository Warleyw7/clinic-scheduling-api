using Microsoft.AspNetCore.Mvc;
using SistemaAgendamento.Infrastructure.Context;

namespace SistemaAgendamento.Api.Controllers;
[ApiController]
[Route("ApiController")]
public class AgendamentoController : ControllerBase
{
    private readonly ClinicaDbContext _context;

    public AgendamentoController(ClinicaDbContext context)
    {
        _context = context;
    }

    [HttpGet("{ObterPorId:int}")]
    public async Task<IActionResult> ObterPorId([FromBody]int id)
    {
        var Agendamento = await _context.Servicos.FindAsync(id);
        if(Agendamento == null)
            return NotFound();
        return Ok();
    }
}