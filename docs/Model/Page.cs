namespace Docs
{
    public class Page
    {
        public long page_pk_id { get; set; }
        public String page_name { get; set; }
        public String page_description { get; set; }
        public String page_icon { get; set; }
        public String page_label { get; set; }
        public Boolean page_status { get; set; }
        public User user { get; set; }
    }
}