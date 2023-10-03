﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMaster.Infastructure.Services
{
    public class DirectoryService
    {
        public static string GetNotepadDirectory()
        {
            return $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}/Database";
        }

        public static void DirectoryCreateIfNotExist(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
    }
}
