namespace SistemaAgendamento.Application.DTOs.Servicos;
public class AtualizarServicoRequest
{
    public string Nome { get; set; } = string.Empty;
    public int DuracaoMinutos { get; set; }
    public decimal? Preco { get; set; }
    public bool Ativo { get; set; }
    
}