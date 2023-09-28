using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace YetGenAkbankJumpOOPConsole.Services
{
    public class WebLogger : LoggerBase
    {
        private readonly HttpClient _httpClient;

        public WebLogger()
        {
            
        }

        protected internal override void Log(string message)
        {
            _httpClient.PostAsJsonAsync("https://localhost:44300/api/Log", message);
        }
    }
}
