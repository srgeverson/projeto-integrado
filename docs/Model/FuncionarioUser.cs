namespace Docs
{
    public class FuncionarioUser
    {
        public long fuus_pk_id { get; set; }
        public User user { get; set; }
        public Funcionario funcionario { get; set; }
        public Boolean fuus_status { get; set; }
        public DateTime fuus_data { get; set; }
    }
}