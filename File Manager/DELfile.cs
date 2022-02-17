using System;
using System.IO;

namespace File_Manager
{
    internal class DELfile : IManager
    {
        public string Name => "del";

        public string Description => "6.Для удаления файла введите: del";
        /// <summary>
        /// заглушка
        /// </summary>
        public void Demo()
        {
            string dirName = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            Console.WriteLine("Введите имя файла с его расширением");
            string to = Console.ReadLine();
            string path = dirName + @"\" + to;
            FileInfo fileInf = new(path);
            if (fileInf.Exists)
            {
                File.Delete(path);
                Console.Write("Файл {0} удален", to);
            }
            else
            {
                Console.Write("Файла не существует! Для возврата нажмите любую кнопку... ");
                Console.ReadKey();
                Console.Clear();
            }

            Console.ReadKey();
            Console.Clear();

        }
    }
}