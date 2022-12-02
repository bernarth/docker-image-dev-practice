using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ConfigurationConnection
    {
        public string connectionString { get; set; }
        public ConfigurationConnection(string? connectionString)
        {
            if (connectionString == null) throw new ArgumentNullException();
            this.connectionString = connectionString;
        }
    }
}
