using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_05_Inventory
{
    internal interface ILogger
    {
        public void Log(string message);
        public void SendSeparator();
    }
}
