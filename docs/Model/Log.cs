namespace Docs.Model
{
    public class Log
    {
        public String nome_tabela { get; set; }
        public long id_tabela { get; set; }
        public User usuario { get; set; }
        public String operacao { get; set; }
        public String campo_modificado { get; set; }
        public String valor_antigo { get; set; }
        public String valor_atual { get; set; }
        public DateTime data_operacao { get; set; }
    }
}
