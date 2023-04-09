namespace Docs
{
    public class GenericDAO
    {
        private PDO instance;
        private string[][] comp;
        private string user;
        private string pass;
        private string query;
        private string host;
        private string dbname;
        private string port;
        public GenericDAO()
        {
            instance = new PDO("mysql:host=" + host + ";port=" + port + ";dbname=" + dbname + ";", user, pass, comp);
        }
    }
}
