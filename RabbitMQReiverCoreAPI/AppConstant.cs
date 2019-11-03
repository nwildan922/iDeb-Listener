using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RabbitMQReiverCoreAPI
{
    public static class AppConstant
    {

        public static string UrlApi = "http://localhost:53514";
    }
    public class FileJson
    {
        public string JsonString { get; set; }
    }
    public static class RabbitMQSetting
    {
        //public static string exchangeName = "IDeb.E.Direct.FilenameEvent";
        public static string queueName = "IDeb.Q.FilenameEvent";
        //public static string routingKey = "FilenameEvent";
        //public static string username = "admin";
        //public static string password = "indocyber";

    }

}
