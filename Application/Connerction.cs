using System.Configuration;
using Evolantis.Data;

namespace Application
{
    public class Connection : IDatabaseSettings
    {
        public string ConnectionString
        {
            get { return ConfigurationManager.ConnectionStrings["connectionstring"].ToString(); }
        }
    }
}
    