namespace Docs
{
    public class FolhaPagamento
    {
      public  long fopa_pk_id {get; set;}
      public  String fopa_competencia {get; set;}
      public  String fopa_nome_arquivo {get; set;}
      public  int fopa_tamanho_arquivo {get; set;}
      public  String fopa_caminho_arquivo {get; set;}
      public  Byte[] fopa_arquivo {get; set;}
      public  Boolean fopa_status {get; set;}
      public  Funcionario funcionario {get; set;}
      public  User user {get; set;}
    }
}