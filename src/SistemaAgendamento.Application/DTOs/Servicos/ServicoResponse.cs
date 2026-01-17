namespace SistemaAgendamento.Application.DTOs.Servicos;
public class ServicoResponse
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public int DuracaoMinutos { get; set; }
    public decimal? Preco { get; set; }
    public bool Ativo { get; set; }
}