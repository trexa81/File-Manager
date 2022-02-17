using System;
using NPOI.SS.Formula.Functions;
using System.IO;
using System.Collections.Generic;

namespace File_Manager
{
    public class Program
    {
        /// <summary>
        /// команды
        /// </summary>
        private static List<IManager> _lessons = new List<IManager>()
        {
            new CD(),
            new APP(),
            new INF(),
            new Inf(),
            new DEL(),
            new DELfile(),
            new CP(),
            new CPfile()
            //new END()  // заглушка
        };

        static void Main()  //new branch 
        {
            string duplicate = new('=', 119);
            Console.Clear();
            StructureHelper.DirName();

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
                //Console.Clear();
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
