using System;
using System.IO;

namespace File_Manager
{
    /// <summary>
    /// Общий интерфейс менеджера
    /// </summary>
    internal interface IManager
    {
        /// <summary>
        /// Код урока.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Описание.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Вывод тестовых данных.
        /// </summary>
        void Demo();

        void DirName()
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