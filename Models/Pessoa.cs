namespace ProjetoAds8.Models
{
    public class Pessoa
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public long Cpf { get; set; }

        public Endereco Endereco { get; set; }

        public Telefone [] Telefone { get; set; }

        public Pessoa()
        {

        }

        public Pessoa(int id, string nome, long cpf, Endereco endereco, Telefone[] telefones)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Endereco = endereco;
            Telefone = telefones;
        }   
    }


}
