using Docs;

namespace Docs.Model
{
    public class GrupoPermissao
    {
        public Grupo grupo { get; set; }
        public Permissao permissao { get; set; }
        public Boolean status { get; set; }
        public Usuario usuario { get; set; }
    }
}
