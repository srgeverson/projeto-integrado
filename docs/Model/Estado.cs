namespace Docs
{
    public class Estado
    {
        public long id { get; set; }
        public String nome { get; set; }
        public String sigla { get; set; }
        public Boolean status { get; set; }
        public Pais pais { get; set; }
        public Usuario usuario { get; set; }
    }
}