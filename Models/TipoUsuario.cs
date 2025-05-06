using System.Reflection.Metadata;

namespace API_Projeto_Livros.Models
{
    public class TipoUsuario
    {
        public int TipoUsuarioId { get; set; }
        public String DescricaoTipo { get; set; }
        public List<Usuario> Usuarios { get; set; } = new();
    }
}
