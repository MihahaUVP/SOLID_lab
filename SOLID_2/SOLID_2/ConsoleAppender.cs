using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_2
{
    public class ConsoleAppender:IAppender
    {
        ILayout layout { get; set; }
        public ConsoleAppender(ILayout layout)
        {
            this.layout = layout;
        }
        public void Print(string type, string info, string message)
        {
            string str = layout.GetString(message, type, info);
            Console.WriteLine(str);
        }
    }
}
