namespace ProjetoAds8.Models
{
    public class TipoTelefone
    {
        public int Id { get; set; }

        public string Tipo { get; set; }

        public TipoTelefone(int id, string tipo)
        {
            Id = id;
            Tipo = tipo;
        }   
    }
}
