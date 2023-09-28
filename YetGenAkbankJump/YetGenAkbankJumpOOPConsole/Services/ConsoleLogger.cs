﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YetGenAkbankJumpOOPConsole.Services
{
    public class ConsoleLogger : LoggerBase
    {
        protected internal override void Log(string message) => Console.WriteLine($"{message} - {DateTime.Now:g}");
    }
}

/** 
 * 
 * => ile tek satırlık metotlar yazılabilir.
 */
