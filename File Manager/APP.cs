using System;
using System.IO;

namespace File_Manager
{
    internal class APP : IManager
    {
        public string Name => "app";

        public string Description => "2.Для перехода к предыдущей папке введите: app ";
        /// <summary>
        /// команда app
        /// </summary>
        public void Demo()
        {
            string dirName = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            DirectoryInfo di = new(dirName);
            dirName = di.Parent.FullName;
            string[] entriesTo = Directory.GetFileSystemEntries(dirName, "*" /*, SearchOption.AllDirectories*/);
            Console.Clear();
            for (int i = 0; i < entriesTo.Length; i++)
            {
                Console.WriteLine(entriesTo[i]);
            }

            Console.ReadKey();

        }
    }
}