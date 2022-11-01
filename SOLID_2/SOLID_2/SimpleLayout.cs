using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_2
{
    public class SimpleLayout:ILayout //Стандартный вывод
    {
        public string GetString(string message, string type, string time)
        {
            return type + " " + time + " " + message + " ";
        }
        ///здесь должен быть код, но его нет, потому что я не знаю что сюда писать
    }
}
