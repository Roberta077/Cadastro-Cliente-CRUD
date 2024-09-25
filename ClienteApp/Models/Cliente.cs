namespace ClienteApp.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Endereco> Enderecos{ get; set; }

    }

    public class Endereco
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Rua   { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }

    }
}