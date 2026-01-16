using src.SistemaAgendamento.Domain;
using Microsoft.EntityFrameworkCore;

public class ClinicaDbContext : DbContext
{

    public ClinicaDbContext(DbContextOptions<ClinicaDbContext> options) : base(options)
    {
        
    }

    public DbSet<Servico> Servicos { get; set; }
    public DbSet<Servico> Usuario { get; set; }
}