using System;
using System.IO;

namespace File_Manager
{
    internal class CP : IManager
    {
        public string Name => "CP";

        public string Description => "7.Для перемещения каталога введите: CP";
        /// <summary>
        /// заглушка
        /// </summary>
        public void Demo()
        {
            string dirName = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            Console.WriteLine("Введите имя папки");
            string to = @"\" + Console.ReadLine();
            string path = dirName + to;
            Console.WriteLine("Введите имя папки в которую вы хотите переместить:" + to);
            string toto = dirName + @"\" + Console.ReadLine() + to;
            DirectoryInfo dirInfo = new(dirName);
            if (dirInfo.Exists && Directory.Exists(toto) == false)
            {
                dirInfo.MoveTo(toto);
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