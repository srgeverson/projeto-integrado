namespace Docs
{
    public class Permissao
    {
        public  long auth_pk_id {get; set;}
        public  String auth_description {get; set;}
        public   Boolean auth_status {get; set;}
        public  String auth_screen {get; set;}
        public  String auth_function {get; set;}
        public  Usuario usuario {get; set; }
    }
}