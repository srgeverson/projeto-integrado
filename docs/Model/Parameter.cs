namespace Docs
{
    public class Parametro
    {
        public long id { get; set; }
        public String chave { get; set; }
        public String valor { get; set; }
        public String descricao { get; set; }
        public Boolean status { get; set; }
        public Usuario user { get; set; }
    }
}