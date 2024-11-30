namespace Docs
{
    public class Authority
    {

        public  long auth_pk_id {get; set;}
        public  String auth_description {get; set;}
        public   Boolean auth_status {get; set;}
        public  String auth_screen {get; set;}
        public  String auth_function {get; set;}
        public  User usuario {get; set; }
        public Authority CriarPermissao {get; set;}
    }
}