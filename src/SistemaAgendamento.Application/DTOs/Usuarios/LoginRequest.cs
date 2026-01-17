namespace SistemaAgendamento.Application.DTOs.Usuarios;
public class LoginRequest
{
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}