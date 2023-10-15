namespace Docs
{
    public class Contato
    {
        public long id { get; set; }
        public String descricao { get; set; }
        public String telefone { get; set; }
        public String celular { get; set; }
        public String whatsapp { get; set; }
        public String email { get; set; }
        public String facebook { get; set; }
        public String instagram { get; set; }
        public String twitter { get; set; }
        public Boolean status { get; set; }
        public String texto { get; set; }
        public Usuario usuario { get; set; }
    }
}