using SistemaAgendamento.Infrastructure.Context;

namespace SistemaAgendamento.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class UsuarioController : ContrllerBase
{
    private readonly ClinicaDbContext _context { get; set; }
}