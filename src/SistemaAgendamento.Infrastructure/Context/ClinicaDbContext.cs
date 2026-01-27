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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Servico>()
            .Property(s => s.Preco)
            .HasPrecision(18, 2); // 18 dígitos no total, 2 casas decimais

        base.OnModelCreating(modelBuilder);
    }

}
