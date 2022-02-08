using System;

namespace File_Manager
{
    internal class CD : IManager
    {
        public string Name => "cd";

        public string Description => "1.Для перехода к папке введите: cd; затем её имя";
        /// <summary>
        /// заглушка
        /// </summary>
        public void Demo()
        {
            Console.WriteLine("Пустой");

        }
    }
}