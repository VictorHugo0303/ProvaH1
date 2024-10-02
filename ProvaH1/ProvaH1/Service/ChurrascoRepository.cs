using ProvaH1.Models;

namespace ProvaH1.Service
{
    public class ChurrascoRepository : IChurrascoRepository
    {
        private static List<Churrasco> listaChurrasco = [];

        public void Inserir(Churrasco churrasco)
        {
            listaChurrasco.Add(churrasco);
        }

        public List<Churrasco> ListarPessoas()
        {
            return listaChurrasco;
        }
    }
}
