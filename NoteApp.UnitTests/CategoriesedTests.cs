using NoteApp;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Runtime.Remoting.Contexts;

namespace NoteApp.UnitTests
{
    /// <summary>
    /// Класс Unit тестов класса <see cref="Categoriesed"/>.
    /// </summary>
    [TestFixture]
    public class CategoriesedTests
    {
        /// <summary>
        /// Тестовый список заметок.
        /// </summary>
        private List<Note> _notes = new List<Note>();

        /// <summary>
        /// Поле заметка для тестирования.
        /// </summary>
        private Note _note;

        /// <summary>
        /// Метод создания объекта класса перед запуском каждого тестирования.
        /// </summary>
        [SetUp]
        public void InitNote()
        {
            _note = new Note();
        }

        /// <summary>
        /// Положительный тест поиска по маске списка заметок.
        /// </summary>
        [Test]
        public void TestCategoriesed()
        {
            var categoriesedNotes = new List<Note>();
            var expected = NoteCategories.Разное;
            _notes.Add(_note);
            var actual = _notes[0].Category;
            Assert.AreEqual(expected, actual);
        }

    }
}
