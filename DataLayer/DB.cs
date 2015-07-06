using System.Configuration;

namespace DataLayer
{
    public class DB
    {
        public static string ConnectionString
        {
            get { return ConfigurationManager.ConnectionStrings["AWConnection"].ConnectionString; }
        }
    }
}
