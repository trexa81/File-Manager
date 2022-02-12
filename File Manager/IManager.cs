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

    }
}