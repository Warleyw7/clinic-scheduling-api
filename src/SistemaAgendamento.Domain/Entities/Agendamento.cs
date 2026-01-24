
using SistemaAgendamento.Domain.Enums;

namespace SistemaAgendamento.Domain.Entities;
public class Agendamento
{
    public int Id { get; set; }

    public int IdPaciente { get; set; }
    public Usuario Paciente { get; set; }

    public int IdProfissional { get; set; }
    public Usuario Profissional { get; set; }

    public int IdServico { get; set; }
    public Servico Servico { get; set; }

    public DateTime Inicio { get; set; }    
    public DateTime Fim { get; set; }

    public StatusAgendamento Status { get; set;} = StatusAgendamento.Agendado;
    public string? Observacao { get; set; }
}