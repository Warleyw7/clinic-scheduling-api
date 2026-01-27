using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaAgendamento.Domain.Entities;
public class Servico
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public int DuracaoMinutos { get; set; }
    [Column(TypeName = "decimal(18,2)")]
    public decimal Preco { get; set; }
    public bool Ativo { get; set; } = true;
    

}