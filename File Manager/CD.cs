using System;
using System.IO;

namespace File_Manager
{
    internal class CD : IManager
    {
        public string Name => "cd";

        public string Description => "1.Для перехода к папке введите: cd; затем её имя";
        /// <summary>
        /// команда cd
        /// </summary>
        public void Demo()
        {
            string dirName = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            Console.Write("Введите имя папки: ");
            string to = Console.ReadLine();
            string[] entries = Directory.GetFileSystemEntries(dirName + @"\" + to, "*");
            //Console.Clear();
            for (int i = 0; i < entries.Length; i++)
            {
                Console.WriteLine(entries[i]);
            }
            Console.ReadKey();

        }
    }
}