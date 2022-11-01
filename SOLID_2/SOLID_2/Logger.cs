using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_2
{
    public class Logger:ILogger
    {
        public IAppender Appender { get; set; }
        public IAppender Appender2 { get; set; }
        //public List<IAppender> Appenders { get; set; }///TODO: сделать List
        public Logger(IAppender appender, IAppender? appender2 = null)
        {
            this.Appender = appender;
            this.Appender2 = appender2;
        }
       /* public Logger(IAppender Appender)
        {
            Appenders = new List<IAppender>();
            for(int i = 0;i< appenders.Count;i++)
            {
                Appenders[i] = appenders[i];
            }
        }*/
        public void Info(string dateTime, string info)
        {
            string type = "information";
            Appender.Print(type, dateTime, info);
            if (Appender2 != null)
            {
                Appender2.Print(type, dateTime, info);

            }
        }
        public void Error(string dateTime, string info)
        {
            string type = "error";
            Appender.Print(type, dateTime, info);
            if (Appender2 != null)
            {
                Appender2.Print(type, dateTime, info);

            }
        }
    }
}
