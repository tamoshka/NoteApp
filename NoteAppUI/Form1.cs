using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text; // Получение данных из nameBox
            
            // Проверка, хранились ли в nameBox данные
            if (!string.IsNullOrEmpty(name))
            {
                Note note = new Note();
                note.Name = name;

                // Сохранение данных в файл
                Project.Notes.Add(note);
                ProjectManager.SaveToFile(Project.Notes, "notes.json");

                MessageBox.Show("Данные успешно сериализованы и сохранены в notes.json");
            }
            else
            {
                MessageBox.Show("Введите название в nameBox");
            }
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            // Загрузка данных из файла
            Project.Notes = ProjectManager.LoadFromFile("notes.json");

            if (Project.Notes.Count > 0)
            {
                Note loadedNote = Project.Notes[0];
                MessageBox.Show($"Название из загруженного объекта: {loadedNote.Name}");
            }
            else
            {
                MessageBox.Show("Отсутствуют данные для десериализации");
            }
        }
    }
}
