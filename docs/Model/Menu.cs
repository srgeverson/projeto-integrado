namespace Docs.Model
{
    public class Menu
    {
        public long id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public Boolean status { get; set; }
        public string classe { get; set; }
        public string url { get; set; }
        public string image { get; set; }
        public string icone { get; set; }
        public Sistema sistema { get; set; }
        public Usuario usuario { get; set; }
    }
}