using Docs;

namespace Docs.Model
{
    public class GrupoPermissao
    {
        public Grupo grupo { get; set; }
        public Authority permissao { get; set; }
        public Boolean status { get; set; }
        public User usuario { get; set; }
    }
}
