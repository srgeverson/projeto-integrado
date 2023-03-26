namespace api_csharp
{
    public class Contact
    {
        public long cont_pk_id { get; set; }
        public String cont_description { get; set; }
        public String cont_phone { get; set; }
        public String cont_cell_phone { get; set; }
        public String cont_whatsapp { get; set; }
        public String cont_email { get; set; }
        public String cont_facebook { get; set; }
        public String cont_instagram { get; set; }
        public String cont_twitter { get; set; }
        public Boolean cont_status { get; set; }
        public String cont_text { get; set; }
        public User user { get; set; }
    }
}