namespace Docs
{
    public class Pagina
    {
        public long id { get; set; }
        public String nome{ get; set; }
        public String descricao{ get; set; }
        public String icone { get; set; }
        public String label { get; set; }
        public Boolean status { get; set; }
        public Usuario usuario { get; set; }
    }
}