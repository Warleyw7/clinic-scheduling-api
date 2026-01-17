using SistemaAgendamento.Domain;

namespace SistemaAgendamento.Application.DTOs.Usuarios;
public class CriarUsuarioRequest
{
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Senha { get; set; } = string.Empty;
    public PerfilUsuario perfilUsuario { get; set; }
    public bool Ativo { get; set; } = true;
}