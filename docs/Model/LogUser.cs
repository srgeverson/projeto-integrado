namespace Docs
{
    public class LogUser
    {
        public  long luser_id_tabela {get;set;}
        public  long luser_fk_usuario_pk_id {get;set;}
        public  String luser_operacao {get;set;}
        public  String luser_campo_modificado {get;set;}
        public  String luser_valor_antigo {get;set;}
        public  String luser_valor_atual {get;set;}
        public  DateTime luser_data_operacao {get;set;}

    }
}