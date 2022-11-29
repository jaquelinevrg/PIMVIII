using Microsoft.EntityFrameworkCore;
using ProjetoAds8.Models;

namespace ProjetoAds8.Repositories
{
    public class PessoaRepository : IProjetoAds8Repository
    {
        public readonly ProjetoAds8Context _context;

        public PessoaRepository(ProjetoAds8Context context) 
        {
            _context = context;
        }   
        public async Task<Pessoa> Create(Pessoa pessoa)
        {
            _context.Pessoa.Add(pessoa);
           await _context.SaveChangesAsync();

            return pessoa;
        }

        public async Task Delete(int id)
        {
            var pessoaToDelete = await _context.Pessoa.FindAsync(id);
            _context.Pessoa.Remove(pessoaToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Pessoa>> Get()
        {
            return await _context.Pessoa.ToListAsync();
        }

        public async Task<Pessoa> Get(int id)
        {
            return await _context.Pessoa.FindAsync(id);
        }

        public async Task Update(Pessoa pessoa)
        {
            _context.Entry(pessoa).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
