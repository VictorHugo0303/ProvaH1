using ProvaH1.Models;

namespace ProvaH1.Service
{
    public interface IChurrascoRepository
    {
        void Inserir(Churrasco churrasco);
        List<Churrasco> ListarPessoas();
    }
}
