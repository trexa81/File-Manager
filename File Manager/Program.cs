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
            new CD(),
            new APP(),
            new Inf(),
            new DEL(),
            new CP(),
            new INF(),
            new END()
        };

        static void Main()  //new branch
        {
            string dirName = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string duplicate = new('=', 119);
            
            string[] entries = Directory.GetFileSystemEntries(dirName, "" /*, SearchOption.AllDirectories*/);
            for (int i = 0; i < entries.Length; i++)
            {
                Console.WriteLine(entries[i]);  // вывод папок и файлов дериктории (по умолчанию) \Documents\
            }

            Console.WriteLine(duplicate);

            Console.WriteLine("Список команд:");
            foreach (IManager lesson in _lessons)
            {
                Console.WriteLine($"Код:{lesson.Name} ({lesson.Description})");
            }
            Console.WriteLine("для завершения введите: end");
            Console.Write("для запуска команды введите её код: ");
            while (true)
            {
                string userInput = Console.ReadLine();
                if (userInput != "end")
                {
                    List<T>(userInput);
                }
                break;
            }

            /// <summary>
            /// выбор задания из списка
            /// </summary>
            /// <typeparam name="T"></typeparam>
            /// <param name="userInput"></param>
            /*private*/ static void List<T>(string userInput)
            {
                Console.Clear();
                foreach (IManager myLesson in _lessons)
                {
                    if (myLesson.Name == userInput)
                    {
                        myLesson.Demo();
                    }
                }
                Main();
            }
        }
    }
}
