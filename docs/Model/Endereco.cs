namespace Docs
{
    public class Endereco
    {
        public long id { get; set; }
        public String logradouro { get; set; }
        public String numero { get; set; }
        public String bairro { get; set; }
        public String cep { get; set; }
        public Boolean status { get; set; }
        public Cidade cidade { get; set; }
        public Usuario user { get; set; }
    }
}