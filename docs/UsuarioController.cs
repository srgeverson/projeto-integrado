namespace api_csharp
{
    public class UsuarioController
    {
        private string _info;
        private SistemaController _controllerSystem;
        private UsuarioDAO _usuarioDAO;
        private Usuario _usuarioAutenticado;
        private ParametroDAO _parametroDAO;

        public string Info { get => _info; set => _info = value; }
        public SistemaController ControllerSystem { get => _controllerSystem; set => _controllerSystem = value; }
        public UsuarioDAO UsuarioDAO { get => _usuarioDAO; set => _usuarioDAO = value; }
        internal Usuario UsuarioAutenticado { get => _usuarioAutenticado; set => _usuarioAutenticado = value; }
        internal ParametroDAO ParametroDAO { get => _parametroDAO; set => _parametroDAO = value; }
    }
}