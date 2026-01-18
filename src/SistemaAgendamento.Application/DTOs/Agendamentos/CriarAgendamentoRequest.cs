namespace SistemaAgendamento.Application.DTOs.Agendamentos;
public class CriaAgendamentoRequest
{
    public int IdPaciente { get; set; }
    public int IdProfissional { get; set; }
    public int IdServico { get; set; }
    public DateTime Inicio { get; set; }
    public string? Observacao { get; set; }
}