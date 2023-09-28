using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YetGenAkbankJumpOOPConsole.Services
{
    public class ConsoleLogger : LoggerBase
    {
        protected internal override void Log(string message) => Console.WriteLine($"{message} - {DateTime.Now:g}");

        protected internal override void LogError(string message)
        {
            Console.WriteLine($"Hata oluştu => {message} - {DateTime.Now:g}");
        }

        protected internal override void LogInfo(string message)
        {
            Console.WriteLine($"Bilgi => {message} - {DateTime.Now:g}");
        }

        protected internal override void LogSuccess(string message)
        {
            Console.WriteLine($"Başarılı => {message} - {DateTime.Now:g}");
        }

        protected internal override void LogWarning(string message)
        {
            Console.WriteLine($"Uyarı => {message} - {DateTime.Now:g}");
        }

        protected internal ConsoleLogger(string name) : base(name)
        {
        }

        protected internal ConsoleLogger()
        {
        }
    }
}

/** 
 * 
 * => ile tek satırlık metotlar yazılabilir.
 */
