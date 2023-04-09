namespace Docs
{
    public class Funcionario
    {
        public long func_pk_id { get; set; }
        public String func_nome { get; set; }
        public String func_cpf { get; set; }
        public String func_rg { get; set; }
        public String func_pis { get; set; }
        public DateTime func_data_nascimento { get; set; }
        public Boolean func_status { get; set; }
        public User usuario { get; set; }
        public Endereco endereco { get; set; }
        public Contact contact { get; set; }
    }
}