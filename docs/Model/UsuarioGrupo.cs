using Docs;

namespace Docs.Model
{
    public class UsuarioGrupo
    {
        public Grupo grupo { get; set; }
        public User usuario { get; set; }
        public User usuarioOperacao { get; set; }
        public Boolean status { get; set; }
    }
}
