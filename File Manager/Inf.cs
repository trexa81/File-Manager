using System;
using System.IO;

namespace File_Manager
{
    internal class Inf : IManager
    {
        public string Name => "inf";

        public string Description => "4.Для получение данных о файле введите: inf";
        /// <summary>
        /// команда inf
        /// </summary>
        public void Demo()
        {
            string dirName = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            Console.WriteLine("Введите имя файла с его расширением");
            string to = @"\" + Console.ReadLine();
            string path = dirName + to;
            FileInfo fileInf = new(path);
            if (fileInf.Exists)
            {
                Console.WriteLine("Имя файла: {0}", fileInf.Name);
                Console.WriteLine("Время создания: {0}", fileInf.CreationTime);
                Console.WriteLine("Размер: {0} Байт", fileInf.Length);
            }
            else
            {
                Console.Write("Файла не существует! Для возврата нажмите любую кнопку... ");
                Console.ReadKey();
                }
            Console.ReadKey();
            Console.Clear();

        }
    }
}