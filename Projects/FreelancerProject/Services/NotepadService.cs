using FreelancerProject.Abstract;
using FreelancerProject.Constant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FreelancerProject.Services
{
    public class NotepadService
    {
        public void SaveToNotepad(ICsvConvertible data)
        {
            string path = $"{FileLocations.ProjectFolder}\\Database";
            string type = data.GetType().ToString().Split(".").LastOrDefault();
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string filePath = $"{path}\\{type}s.txt";

            File.AppendAllText(filePath, $"{data.GetValuesCSV()}\n");
        }

        public string GetOnNotepad(string path)
        {
            if (File.Exists(path))
                return File.ReadAllText(path);

            throw new Exception("Dosya mevcut değil");
        }
    }
}


/**
 * AppendAllText methodu, dosyanın sonuna ekleme yapar.
*/