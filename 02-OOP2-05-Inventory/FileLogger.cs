using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_05_Inventory
{
    internal class FileLogger : ILogger
    {
        private string _filename;
        public FileLogger(string filename)
        {
            _filename = filename;
            File.Delete(_filename);
        }

        public void Log(string message)
        {
            using (StreamWriter sw = File.AppendText(_filename))
            {
                sw.WriteLine(message);
            }
        }

        public void SendSeparator()
        {
            using (StreamWriter sw = File.AppendText(_filename))
            {
                sw.WriteLine(Environment.NewLine);
            }
        }
    }
}
