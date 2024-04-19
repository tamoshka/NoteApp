using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;

namespace NoteApp
{
    public static class ProjectManager
    {
        /// <summary>
        /// Метод сериализации данных объектов класса <see cref="Note"/>.
        /// </summary>
        /// <param name="data">Список объектов класса <see cref="Note"/>.</param>
        /// <param name="path">Путь для сохранения файлов.</param>
        public static void SaveToFile(List<Note> data, string path)
        {
            path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), path);
            var serialized = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(path, serialized);
        }

        /// <summary>
        /// Метод десериализации данных объектов класса <see cref="Note"/>.
        /// </summary>
        /// <param name="path">Путь до файла, который надо десереализовать.</param>
        /// <returns>Список объектов класса <see cref="Note"/>.</returns>
        public static List<Note> LoadFromFile(string path)
        {
            path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), path);
            var data = new List<Note>();
            if (File.Exists(path))
            {
                var jsonConvert = File.ReadAllText(path);
                data = JsonConvert.DeserializeObject<List<Note>>(jsonConvert);
            }
            return data;
        }
    }
}