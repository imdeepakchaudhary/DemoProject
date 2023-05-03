using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data
{
    public class AppConfig
    {
        public string ApplicationName { get; set; }
        public string ApplicationUrl { get; set; }
        public string Version { get; set; }
    }
    public class NexmoConfig
    {
        public string UserAgent { get; set; }
        public string Url_Rest { get; set; }
        public string Url_Api { get; set; }
        public string api_key { get; set; }
        public string api_secret { get; set; }
        public string fromnumber { get; set; }
    }
}
