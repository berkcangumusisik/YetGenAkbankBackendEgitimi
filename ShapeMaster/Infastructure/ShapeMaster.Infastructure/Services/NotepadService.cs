using ShapeMaster.Domain.Abstract;
using ShapeMaster.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMaster.Infastructure.Services
{
    public class NotepadService
    {
        public void SaveToNotepad(ISaveableShape saveableShape)
        {
            string path = DirectoryService.GetNotepadDirectory();

            DirectoryService.DirectoryCreateIfNotExist(path);

            File.AppendAllText($"{path}/{saveableShape.GetType()}.txt", saveableShape.GetInfos());
        }


    }
}
