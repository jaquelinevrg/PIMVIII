using Microsoft.EntityFrameworkCore;

namespace ProjetoAds8.Models
{
    public class ProjetoAds8Context : DbContext
    {
        public ProjetoAds8Context(DbContextOptions<ProjetoAds8Context> options) : base(options)
        {
            Database.EnsureCreated();   
        }

        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Telefone> Telefone { get; set; }
        public DbSet<TipoTelefone> TipoTelefone { get; set; }

    }
}
