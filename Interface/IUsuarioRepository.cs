using API_Projeto_Livros.Models;

namespace API_Projeto_Livros.Interface
{
    public interface IUsuarioRepository
    {
        List<Usuario> ListarTodos();
        Usuario? ListarPorId(int id);
        void Cadastrar(Usuario usuario);
        Usuario? Atualizar(int id, Usuario usuario);
        Usuario? Deletar(int id);
    }
}
