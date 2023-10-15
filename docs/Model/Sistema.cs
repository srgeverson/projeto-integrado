namespace Docs.Model
{
    public class Sistema
    {
        public long Id { get; set; }
        public String nome { get; set; }
        public String descricao { get; set; }
        public Boolean status { get; set; }
        public Usuario usuario { get; set; }
    }
}