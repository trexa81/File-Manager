using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Manager
{
    public static class StructureHelper
    {
        public static void DirName()
        {
            string dirName = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string[] entries = Directory.GetFileSystemEntries(dirName, "" /*, SearchOption.AllDirectories*/);
            for (int i = 0; i < entries.Length; i++)
            {
                Console.WriteLine(entries[i]);  // вывод папок и файлов дериктории (по умолчанию) \Documents\
            }
        }
    }
}
