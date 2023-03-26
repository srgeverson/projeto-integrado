namespace api_csharp
{
    public class Pais
    {
      public  long pais_pk_id {get;set;}
      public  String pais_nome {get;set;}
      public  String pais_sigla {get;set;}
      public  Boolean pais_status {get;set;}
      public  User user {get;set;}
    }
}