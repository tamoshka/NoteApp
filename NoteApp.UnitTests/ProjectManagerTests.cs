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
    /// Класс Unit тестов класса <see cref="ProjectManager"/>.
    /// </summary>
    [TestFixture]
    public class ProjectManagerTests
    {
        /// <summary>
        /// Тестовый список заметок.
        /// </summary>
        private List<Note> _notes = new List<Note>();

        /// <summary>
        /// Начальный метод создания тестового списка заметок.
        /// </summary>
        [SetUp]
        public void CreateTestList()
        {
            _notes.Clear();
            _notes.Add(new Note(
                "Название",
                NoteCategories.Документы,
                "пзавзпвазпхыпхаыхпзавзпхыахпыа",
                new DateTime(2000, 1, 1),
                new DateTime(2000, 1, 1)));
        }

        /// <summary>
        /// Метод удаления файла после теста.
        /// </summary>
        [TearDown]
        public void DeleteTestFile()
        {
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "test.json");
            File.Delete(path);
        }

        /// <summary>
        /// Положительный тест сериализации.
        /// </summary>
        [Test]
        public void TestSerialize()
        {
            ProjectManager.SaveToFile(_notes, Paths.PathToFilesTest);
            var expected = File.ReadAllText(Paths.PathToStandard);
            var actual = File.ReadAllText(Paths.PathToFilesTest);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Положительный тест десериализации.
        /// </summary>
        [Test]
        public void TestDeserialize()
        {
            ProjectManager.SaveToFile(_notes, Paths.PathToFilesTest);
            var actual = ProjectManager.LoadFromFile(Paths.PathToFilesTest);
            var expected = _notes;
            Assert.IsTrue(actual[0].Equals(actual[0]));
        }

    }
}
