using System;

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
            Console.WriteLine("Пустой");

        }
    }
}