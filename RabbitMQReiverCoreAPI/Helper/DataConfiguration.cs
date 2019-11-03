using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RabbitMQReiverCoreAPI.Helper
{
    public class DataConfiguration
    {
        public static Configuration Configuration
        {
            get
            {
                string json = System.IO.File.ReadAllText("appsettings.json");
                var data = JsonConvert.DeserializeObject<Configuration>(json);
                return data;
            }
        }
    }
    public class Configuration
    {
        public AppConfiguration AppConfiguration { get; set; }
    }
    public class AppConfiguration
    {
        public string ApiServerUrlReadFile { get; set; }
    }
}
