namespace api_csharp
{
    public class Endereco
    {
        public long ende_pk_id { get; set; }
        public String ende_logradouro { get; set; }
        public String ende_numero { get; set; }
        public String ende_bairro { get; set; }
        public String ende_cep { get; set; }
        public String ende_cidade { get; set; }
        public Boolean ende_status { get; set; }
        public Estado estado { get; set; }
        public User user { get; set; }
    }
}