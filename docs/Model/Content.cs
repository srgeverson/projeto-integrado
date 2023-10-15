namespace Docs
{
    public class Conteudo
    {
        public long pk_id {get; set;}
        public String component {get; set;}
        public String title {get; set;}
        public String subtitle {get; set;}
        public String text {get; set;}
        public String image {get; set;}
        public String link {get; set;}
        public Boolean status {get; set;}
        public Pagina page {get; set;}
        public Usuario usuario {get; set;}
    }
}