using SistemaAgendamento.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace src.SistemaAgendamento.Infrastructure.Context;
public class ClinicaDbContext : DbContext
{

    public ClinicaDbContext(DbContextOptions<ClinicaDbContext> options) : base(options)
    {
        
    }

    public DbSet<Servico> Servicos { get; set; }
    public DbSet<Servico> Usuario { get; set; }
}