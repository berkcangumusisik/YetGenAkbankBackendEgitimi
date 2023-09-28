using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YetGenAkbankJumpOOPConsole.Services
{
    public abstract class LoggerBase
    {
        protected internal virtual string? Name { get; set; }
        protected internal abstract void Log(string message);
        protected internal abstract void LogSuccess(string message);
        protected internal abstract void LogError(string message);
        protected internal abstract void LogInfo(string message);
        protected internal abstract void LogWarning(string message);
        protected internal virtual void LogFatal(string message)
        {
            Console.WriteLine($"Fatal => {message} - {DateTime.Now:g}");
        }
 

        protected internal LoggerBase(string name)
        {
            Name = name;
        }

        protected internal LoggerBase()
        {
        }


    }
}

/**
 * Abstract base newlenemez.
 * protected ile erişim belirleyicisi kullanıldığında sadece kalıtım yoluyla erişilebilir. 
 * 
 * Virtual metotlar override edilebilir.
 * Virtual metotlar override edilmezse base sınıfın metodu çalışır.
 * virtual içi dolu gelir abstract bizim doldurmamız gerekiyor .
 */
