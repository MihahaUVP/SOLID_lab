using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_2
{
    public interface ILogger
    {
        //IAppender Appender { get; set; }
        public void Info(string date,string info);
        public void Error(string date, string info);
    }
}
