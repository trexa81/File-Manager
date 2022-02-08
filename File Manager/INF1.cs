using System;

namespace File_Manager
{
    internal class INF : IManager
    {
        public string Name => "inf";

        public string Description => "3.Для получение данных о файле введите: inf ";
        /// <summary>
        /// команда inf
        /// </summary>
        public void Demo()
        {
            Console.WriteLine("Пустой");

        }
    }
}