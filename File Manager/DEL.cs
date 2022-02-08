using System;

namespace File_Manager
{
    internal class DEL : IManager
    {
        public string Name => "stab";

        public string Description => "0.Пустое задание";
        /// <summary>
        /// заглушка
        /// </summary>
        public void Demo()
        {
            Console.WriteLine("Пустой");

        }
    }
}