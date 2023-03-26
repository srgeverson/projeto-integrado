namespace api_csharp
{
    public class User
    {
      public  long user_pk_id {get;set;}
      public  String user_name {get;set;}
      public  String user_login {get;set;}
      public  String user_password {get;set;}
      public  DateTime user_last_login {get;set;}
      public  String user_image {get;set;}
      public  Boolean user_status {get;set;}
      public  Authority authority {get;set;}
    }
}