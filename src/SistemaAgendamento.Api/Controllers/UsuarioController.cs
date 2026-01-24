using Microsoft.AspNetCore.Mvc;
using SistemaAgendamento.Infrastructure.Context;

namespace SistemaAgendamento.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase
{
    private readonly ClinicaDbContext _context;

    public UsuarioController(ClinicaDbContext context)
    {
        _context = context;
    }

}