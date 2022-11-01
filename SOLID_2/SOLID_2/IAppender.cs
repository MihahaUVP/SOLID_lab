using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_2
{
    public interface IAppender
    {
        public void Print(string type, string time,string info);
    }
}
