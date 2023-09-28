using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YetGenAkbankJumpOOPConsole.Services
{
    public abstract class LoggerBase
    {
        protected internal abstract void Log(string message);
    }
}

/**
 * Abstract base newlenemez.
 * protected ile erişim belirleyicisi kullanıldığında sadece kalıtım yoluyla erişilebilir. 
 */
