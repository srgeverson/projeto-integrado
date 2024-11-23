namespace Docs
{
    public class Parameter
    {
        public long para_pk_id { get; set; }
        public String para_key { get; set; }
        public String para_value { get; set; }
        public String para_description { get; set; }
        public Boolean para_status { get; set; }
        public User user { get; set; }
    }
}