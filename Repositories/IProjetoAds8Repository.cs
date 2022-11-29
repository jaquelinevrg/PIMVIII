using ProjetoAds8.Models;
using System.Threading.Tasks;

namespace ProjetoAds8.Repositories
{
   public interface IProjetoAds8Repository
    {
        Task<IEnumerable<Pessoa>> Get();

        Task<Pessoa> Get(int Id);
        Task<Pessoa> Create (Pessoa pesssoa);
        Task Update (Pessoa pessoa);
        Task Delete (int Id);



    }
}
