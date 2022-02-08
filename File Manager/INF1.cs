using System;
using System.IO;

namespace File_Manager
{
    internal class INF : IManager
    {
        public string Name => "INF";

        public string Description => "3.Для получение данных о каталоге введите: INF";
        /// <summary>
        /// команда INF
        /// </summary>
        public void Demo()
        {
            string dirName = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            Console.Write("Введите имя каталога : ");
            string to = @"\" + Console.ReadLine();
            DirectoryInfo dirInfo = new(dirName + to);
            Console.WriteLine($"Название каталога: {dirInfo.Name}");
            Console.WriteLine($"Полное название каталога: {dirInfo.FullName}");
            Console.WriteLine($"Время создания каталога: {dirInfo.CreationTime}");
            Console.ReadKey();
            Console.Clear();

        }
    }
}