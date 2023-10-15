using Docs;

namespace Docs.Model
{
    public class UsuarioGrupo
    {
        public Grupo grupo { get; set; }
        public Usuario usuario { get; set; }
        public Usuario usuarioOperacao { get; set; }
        public Boolean status { get; set; }
    }
}
