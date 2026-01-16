using Microsoft.AspNetCore.Mvc;

namespace src.SistemaAgendamento.Api;

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
    public IActionResult Create(Servico servico)
    {
        _context.Add(servico);
        _context.SaveChanges();
        return Ok(servico);
    }

    
}