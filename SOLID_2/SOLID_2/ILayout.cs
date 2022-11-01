using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_2
{
    public interface ILayout
    {
        public string GetString(string message, string type, string time);
    }
}
