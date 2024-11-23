namespace Docs
{
    public class Content
    {
        public long conte_pk_id {get; set;}
        public String conte_component {get; set;}
        public String conte_title {get; set;}
        public String conte_subtitle {get; set;}
        public String conte_text {get; set;}
        public String conte_image {get; set;}
        public String conte_link {get; set;}
        public Boolean conte_status {get; set;}
        public Page page {get; set;}
        public User usuario {get; set;}
    }
}