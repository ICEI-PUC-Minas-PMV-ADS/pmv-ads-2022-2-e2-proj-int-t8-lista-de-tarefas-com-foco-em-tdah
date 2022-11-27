using WebApplication2.Models;

namespace WebApplication2.Repositorio
{
    public interface IContatoRepositorio { 
        

        ContatoModel ListarPorId(int id);


        List<ContatoModel> BuscarTodos();

        ContatoModel Adicionar(ContatoModel contato);

        ContatoModel Atualizar(ContatoModel contato);

        bool ApagarAgora(int id);

        
        

    }
}
