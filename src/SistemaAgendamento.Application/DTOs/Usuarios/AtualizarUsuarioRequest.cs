namespace SistemaAgendamento.Application.DTOs.Usuarios;
public class AtualizarUsuarioRequest
{
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public bool Ativo { get; set; } = true;
}