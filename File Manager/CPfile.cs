using System;
using System.IO;

namespace File_Manager
{
    internal class CPfile : IManager
    {
        public string Name => "cp";

        public string Description => "7.Для копирования файла введите: cp";
        /// <summary>
        /// заглушка
        /// </summary>
        public void Demo()
        {
            string dirName = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            Console.WriteLine("Введите имя файла с его расширением");
            string to = @"\" + Console.ReadLine();
            string path = dirName + to;
            Console.WriteLine("Введите имя папки в которую вы хотите скопировать файл");
            string toto = dirName + @"\" + Console.ReadLine() + to;
            Console.WriteLine(path + " * " + toto);
            Console.ReadKey();
            FileInfo fileInf = new(path);
            if (fileInf.Exists)
            {
                File.Copy(path, toto, true);
            }
            else
            {
                Console.Write("Ошибка! Для возврата нажмите любую кнопку... ");
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine($"Файл успешно скопирован в: {toto}");
            Console.ReadKey();
            Console.Clear();

        }
    }
}