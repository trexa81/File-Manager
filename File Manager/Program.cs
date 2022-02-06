using System;
using NPOI.SS.Formula.Functions;
using System.IO;
using System.Collections.Generic;

namespace File_Manager
{
    internal class Program
    {
        /// <summary>
        /// команды
        /// </summary>
        private static List<IManager> _lessons = new List<IManager>()
        {
            new CD (),
            new APP (),
            new Inf(),
            new DEL(),
            new CP(),
            new INF(),
            new END()
        };

        static void Main(string[] args)  //new branch
        {
            string dirName = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string duplicate = new('=', 119);
            
            string[] entries = Directory.GetFileSystemEntries(dirName, "" /*, SearchOption.AllDirectories*/);
            for (int i = 0; i < entries.Length; i++)
            {
                Console.WriteLine(entries[i]);  // вывод папок и файлов дериктории (по умолчанию) \Documents\
            }

            Console.WriteLine(duplicate); 

        }
    }
}
