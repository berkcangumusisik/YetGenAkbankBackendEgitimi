using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.Services
{
    public class NotepadService
    {
        public string ReadFromNotepad(string path)
        {
            if(File.Exists(path))
                return File.ReadAllText(path);
            
            throw new Exception("Dosya Bulunamadı");
        }
    }
}
