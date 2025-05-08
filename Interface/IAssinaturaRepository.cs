using API_Projeto_Livros.Models;

namespace API_Projeto_Livros.Interface
{
    public interface IAssinaturaRepository
    {
        List<Assinatura> ListarTodos();
        Assinatura? ListarPorId(int id);
        void Cadastrar(Assinatura assinatura);
        Assinatura? Atualizar(int id, Assinatura assinatura);
        Assinatura? Deletar(int id);
    }
}
