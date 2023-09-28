using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YetGenAkbankJumpOOPConsole.Services
{
    public class FileLogger : LoggerBase
    {

        private readonly string _filePath;
        public FileLogger(string filePath) { 
            _filePath = filePath;
        }
        protected internal override void Log(string message)
        {
            File.AppendAllText(_filePath, message);
        }
    }
}
