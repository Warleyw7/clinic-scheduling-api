
namespace SistemaAgendamento.Application.Dtos.Agendamentos;
public class AgendamentoResponse
{
    public int Id { get; set; }

    public int PacienteId { get; set; }
    public string PacienteNome { get; set; } = string.Empty;

    public int ProfissionalId { get; set; }
    public string ProfissionalNome { get; set; } = string.Empty;

    public int ServicoId { get; set; }
    public string ServicoNome { get; set; } = string.Empty;

    public DateTime Inicio { get; set; }
    public DateTime Fim { get; set; }

    public int DuracaoMinutos { get; set; }

    public StatusAgendamento Status { get; set; }

    public string? Observacao { get; set; }
}
