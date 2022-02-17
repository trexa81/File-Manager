using System;
using System.IO;

namespace File_Manager
{
    internal class DEL : IManager
    {
        public string Name => "DEL";

        public string Description => "5.Для удаления каталога введите: DEL";
        /// <summary>
        /// удаления каталога
        /// </summary>
        public void Demo()
        {
            string dirName = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            Console.WriteLine("Введите имя каталога");
            string to = @"\" + Console.ReadLine();
            string path = dirName + to;
            Directory.Delete(path, true);
            Console.ReadKey();
            Console.Clear();

        }
    }
}