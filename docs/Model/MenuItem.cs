namespace Docs.Model
{
    public class MenuItem
    {
        public long id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public Boolean status { get; set; }
        public string titulo { get; set; }
        public string classe { get; set; }
        public string url { get; set; }
        public string image { get; set; }
        public string icone { get; set; }
        public MenuItem menuItem { get; set; }
        public Menu menu { get; set; }
        public User usuario { get; set; }
    }
}
