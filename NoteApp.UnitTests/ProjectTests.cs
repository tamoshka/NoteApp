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
    /// Класс Unit тестов класса <see cref="Project"/>.
    /// </summary>
    [TestFixture]
    public class ProjectTests
    {
        /// <summary>
        /// Тестовый список заметок.
        /// </summary>
        private List<Note> _notes = new List<Note>();

        /// <summary>
        /// Позитивный тест геттера Project.
        /// </summary>
        [Test(Description = "Позитивный тест геттера Project.")]
        public void TestProjectGetCurrentValue()
        {
            List<Note> expected=new List<Note>();
            _notes = expected;
            var actual = _notes;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Позитивный тест сеттера Project
        /// </summary>
        [Test(Description = "Присвоение списка заметок")]
        public void TestnProjectSetCurrentValue()
        {
            List<Note> expected = new List<Note>();
            Assert.Throws<ArgumentException>(
            () => { _notes = expected; },
            "Если всё правильно, не должно возникать исключения");
        }
    }
}
