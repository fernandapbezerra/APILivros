using API_Projeto_Livros.Models;

namespace API_Projeto_Livros.Interface
{
    public interface ILivroRepository
    {
        List<Livro> ListarTodos();
        Livro? ListarPorId(int id);
        void Cadastrar(Livro livro);
        Livro? Atualizar(int id, Livro livro);
        Livro? Deletar(int id);
    }
}
