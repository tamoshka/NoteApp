using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Класс заметок
    /// </summary>
    public class Note : ICloneable
    {
        /// <summary>
        /// Название заметки
        /// </summary>
        private string _name;

        /// <summary>
        /// Категория заметки
        /// </summary>
        private NoteCategories _category;

        /// <summary>
        /// Текст заметки   
        /// </summary>
        private string _text;

        /// <summary>
        /// Время создания заметки
        /// </summary>
        private DateTime _created;

        /// <summary>
        /// Время последнего обновления
        /// </summary>
        private DateTime _lastUpdated;

        /// <summary>
        /// Конструктор класса <see cref="Note"/> без параметров.
        /// </summary>
        public Note()
        {
            Name = "Без названия";
            Category = NoteCategories.Разное;
            Text = String.Empty;
            Created = DateTime.Now;
            LastUpdated= DateTime.Now;
        }

        /// <summary>
        /// Конструктор класса <see cref="Note"/> с параметрами.
        /// </summary>
        /// <param name="name">Название.</param>
        /// <param name="category">Категория.</param>
        /// <param name="text">Текст.</param>
        public Note(string name, NoteCategories category, string text)
        {
            Name = name;
            Category = category;
            Text = text;
            Created = DateTime.Now;
            LastUpdated = DateTime.Now;
        }

        /// <summary>
        /// Конструктор класса <see cref="Note"/> с параметрами (Для Clone).
        /// </summary>
        /// <param name="name"></param>
        /// <param name="category"></param>
        /// <param name="text"></param>
        /// <param name="created"></param>
        /// <param name="lastUpdated"></param>
        public Note(string name, NoteCategories category, string text, DateTime created, DateTime lastUpdated)
        {
            Name = name;
            Category = category;
            Text = text;
            Created = created;
            LastUpdated = lastUpdated;
        }

        /// <summary>
        /// Возвращает и задаёт название заметки, а также производит валидацию входного паараметра.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length > 50||value.Length==0)
                {
                    throw new ArgumentException();
                }

                _name = value;
                Updated();
            }
        }

        /// <summary>
        ///  Возвращает и задаёт категорию заметки.
        /// </summary>
        public NoteCategories Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
                Updated();
            }
        }

        /// <summary>
        /// Возвращает и задаёт текст заметки.
        /// </summary>
        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                _text=value;
                Updated();
            }
        }

        /// <summary>
        /// Возвращает и задаёт время создания заметки.
        /// </summary>
        public DateTime Created
        {
            get
            {
                return _created;
            }
            set
            {
                _created=value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт время последнего обновления заметки.
        /// </summary>
        public DateTime LastUpdated
        {
            get
            {
                return _lastUpdated;
            }
            set
            {
                _lastUpdated = value;
            }
        }

        /// <summary>
        /// Метод, обновляющий время последнего изменения заметки.
        /// </summary>
        private void Updated()
        {
            LastUpdated=DateTime.Now;
        }

        /// <summary>
        /// Метод создания клона объекта заметки
        /// </summary>
        /// <returns>Заметка.</returns>
        public object Clone()
        {
            return new Note
            (
                Name,
                Category,
                Text,
                Created,
                LastUpdated
            );
        }
    }
}
