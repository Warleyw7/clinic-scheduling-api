using SistemaAgendamento.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace SistemaAgendamento.Infrastructure.Context;
public class ClinicaDbContext : DbContext
{

    public ClinicaDbContext(DbContextOptions<ClinicaDbContext> options) : base(options)
    {
        
    }

    public DbSet<Servico> Servicos { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Agendamento> Agendamentos { get; set; }
}