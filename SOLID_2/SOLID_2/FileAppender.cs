using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_2
{
    internal class FileAppender : IAppender
    {
        public ILayout Layout { get; set; }
        public LogFile File { get; private set; }
        public FileAppender(ILayout layout,LogFile file)
        {
            this.Layout = layout;
            this.File = file;
        }
        public void Print(string type,string info,string name)
        {
            string str = Layout.GetString(info, type, name);
            Console.WriteLine("Симуляция вывода в файл... " + str);
        }
    }
}
