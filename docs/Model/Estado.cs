namespace api_csharp
{
    public class Estado
    {
        public long esta_pk_id { get; set; }
        public String esta_nome { get; set; }
        public String esta_sigla { get; set; }
        public Boolean esta_status { get; set; }
        public Pais pais { get; set; }
        public User user { get; set; }
    }
}