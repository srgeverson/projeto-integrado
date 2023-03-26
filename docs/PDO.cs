namespace api_csharp
{
    internal class PDO
    {
        private string v;
        private string? user;
        private string? pass;
        private string[][]? comp;

        public PDO(string v, string? user, string? pass, string[][]? comp)
        {
            this.v = v;
            this.user = user;
            this.pass = pass;
            this.comp = comp;
        }
    }
}