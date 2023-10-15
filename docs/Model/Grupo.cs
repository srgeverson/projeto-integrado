using Docs;

namespace Docs.Model
{
    public class Grupo
    {
        public long Id { get; set; }
        public String nome { get; set; }
        public Boolean status { get; set; }
        public Usuario usuario { get; set; }
    }
}