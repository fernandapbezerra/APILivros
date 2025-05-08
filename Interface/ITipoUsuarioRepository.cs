using API_Projeto_Livros.Models;

namespace API_Projeto_Livros.Interface
{
    public interface ITipoUsuarioRepository
    {
        List<TipoUsuario> ListarTodos();
        TipoUsuario? ListarPorId(int id);
        void Cadastrar(TipoUsuario tipoUsuario);
        TipoUsuario? Atualizar(int id, TipoUsuario tipoUsuario);
        TipoUsuario? Deletar(int id);
    }
}
