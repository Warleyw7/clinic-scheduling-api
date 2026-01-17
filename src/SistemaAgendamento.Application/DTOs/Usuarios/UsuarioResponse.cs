using SistemaAgendamento.Domain;

namespace SistemaAgendamento.Application.DTOs.Usuarios;
public class UsuarioResponse
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public PerfilUsuario perfilUsuario { get; set; }

}