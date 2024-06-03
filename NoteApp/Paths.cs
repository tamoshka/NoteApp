using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Класс путей сохранения файлов сериалайзера.
    /// </summary>
    public static class Paths
    {
        /// <summary>
        /// Путь к файлу для сохранения рабочих данных.
        /// </summary>
        public static readonly string PathToFiles =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "notes.json");

        /// <summary>
        /// Путь к файлу для сохранения тестовых данных.
        /// </summary>
        public static readonly string PathToFilesTest =
            Path.Combine(AppContext.BaseDirectory, "notesTest.json");

        /// <summary>
        /// Путь к файлу для сохранения тестовых данных.
        /// </summary>
        public static readonly string PathToStandard =
            Path.Combine(AppContext.BaseDirectory, "Эталон.json");
    }
}
