using API_Projeto_Livros.Models;

namespace API_Projeto_Livros.Interface
{
    public interface ICategoriaRepository
    {
        Task<List<Categoria>> ListarTodosAsync();

        List<Categoria> ListarTodos();
        void Cadastrar(Categoria categoria);
        Categoria? Atualizar(int id,Categoria categoria);
        Categoria? Deletar(int id);
    }
}
