using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NoteAppUI
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Обращение к форме AboutForm
        /// </summary>
        private AboutForm AboutForm { get; set; }

        /// <summary>
        /// Список заметок
        /// </summary>
        private List<Note> Notes { get; set; }

        private Note CurrentNote {get; set;}

        private List<Note> ListCurrentNote { get; set; }

        /// <summary>
        /// Список контактов по категории
        /// </summary>
        private List<Note> CategoriesedNotes { get; set; }

        public MainForm()
        {
            InitializeComponent();
            ShowCategoryCombo.Items.Add(NoteCategories.Документы);
            ShowCategoryCombo.Items.Add(NoteCategories.Работа);
            ShowCategoryCombo.Items.Add(NoteCategories.Разное);
            ShowCategoryCombo.Items.Add(NoteCategories.Люди);
            ShowCategoryCombo.Items.Add(NoteCategories.ЗдоровьеИСпорт);
            ShowCategoryCombo.Items.Add(NoteCategories.Дом);
            ShowCategoryCombo.Items.Add(NoteCategories.Финансы);
            ShowCategoryCombo.Items.Add("All");
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "notes.json");
            Notes = ProjectManager.LoadFromFile(path);
            CategoriesedNotes = Categoriesed.CategoriesedNotes(Notes);
            UpdateNotes(CategoriesedNotes);
            ShowCategoryCombo.Text = "All";
            path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "current.json");
            ListCurrentNote = ProjectManager.LoadFromFile(path);
            try
            {
                CurrentNote = ListCurrentNote[0];
                UpdateNoteInformation(ListCurrentNote[0]);
            }
            catch
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Реализация паттерна Singleton для формы AboutForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["AboutForm"] == null)
            {
                AboutForm = new AboutForm();
                AboutForm.Show();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Обработчик нажатия на добавление заметки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNote_Click(object sender, EventArgs e)
        {
            TransferNote.Data = new Note();
            var addForm = new AddEditNoteForm();
            addForm.ShowDialog();
            if (addForm.DialogResult == DialogResult.OK)
            {
                Notes.Add(TransferNote.Data);
                var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "notes.json");
                ProjectManager.SaveToFile(Notes, path);
                UpdateNotes(CategoriesedNotes);
            }
        }

        /// <summary>
        /// Обновляет список заметок
        /// </summary>
        /// <param name="notes"></param>
        private void UpdateNotes(List<Note> notes)
        {
            NotesListBox.Items.Clear();

            foreach (var note in notes)
            {
                NotesListBox.Items.Add(note.Name);
            }
        }

        /// <summary>
        /// Обновляет значения заметки на форме
        /// </summary>
        /// <param name="note"></param>
        private void UpdateNoteInformation(Note note)
        {
            labelName.Text = note.Name;
            labelCurentCategory.Text = note.Category.ToString();
            dateTimePickerCreated.Value = note.Created;
            dateTimePickerModified.Value = note.LastUpdated;
            textBoxText.Text = note.Text;
        }

        /// <summary>
        /// Меняет отображаемую справа заметку на выбранную
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = NotesListBox.SelectedIndex;
            if (index >= 0)
            {
                UpdateNoteInformation(CategoriesedNotes[index]);
                CurrentNote = CategoriesedNotes[index];
            }
        }

        /// <summary>
        /// Обработчик попытки изменения даты создания заметки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePickerCreated_ValueChanged(object sender, EventArgs e)
        {
            var index = NotesListBox.SelectedIndex;
            if (index >= 0)
            {
                dateTimePickerCreated.Value = CategoriesedNotes[index].Created;
            }
            else
            {
                dateTimePickerCreated.Value = DateTime.Now;
            }
        }

        /// <summary>
        /// Обработчик попытки изменения даты последнего изменения заметки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePickerModified_ValueChanged(object sender, EventArgs e)
        {
            var index = NotesListBox.SelectedIndex;
            if (index >= 0)
            {
                dateTimePickerModified.Value = CategoriesedNotes[index].LastUpdated;
            }
            else
            {
                dateTimePickerModified.Value = DateTime.Now;
            }
        }

        /// <summary>
        /// Изменение уже созданной заметки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditNote_Click(object sender, EventArgs e)
        {
            var index = NotesListBox.SelectedIndex;
            if (index >= 0)
            {
                TransferNote.Data = (Note)Notes[index].Clone();
                var addForm = new AddEditNoteForm();
                addForm.ShowDialog();
                if (addForm.DialogResult == DialogResult.OK)
                {
                    Notes[index] = TransferNote.Data;
                    var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "notes.json");
                    ProjectManager.SaveToFile(Notes, path);
                    UpdateNotes(CategoriesedNotes);
                    NotesListBox.SelectedIndex = index;
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать заметку для редактирования",
                    "Ошибка",
                    MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Удаление заметки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteNote_Click(object sender, EventArgs e)
        {
            var index = NotesListBox.SelectedIndex;
            if (index >= 0)
            {
                DialogResult warning = MessageBox.Show(
                    $"Do you really want to remove this note: {Notes[index].Name}",
                    "Warning",
                    MessageBoxButtons.YesNo);
                if (warning == DialogResult.Yes)
                {
                    Notes.RemoveAt(index);
                    var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "notes.json");
                    ProjectManager.SaveToFile(Notes, path);
                    UpdateNotes(CategoriesedNotes);
                    NotesListBox.SelectedIndex = -1;
                    labelName.Text = String.Empty;
                    labelCurentCategory.Text = String.Empty;
                    dateTimePickerCreated.Value = DateTime.Now;
                    dateTimePickerModified.Value = DateTime.Now;
                    textBoxText.Text = String.Empty;
                }
                var path2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "current.json");
                File.Delete(path2);
                CurrentNote = null;
            }
            else
            {
                MessageBox.Show("Необходимо выбрать заметку, которую хотите удалить",
                    "Ошибка",
                    MessageBoxButtons.OK);
            }
        }

        private void ShowCategoryCombo_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowCategoryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mask = ShowCategoryCombo.Text;
            if (mask == "All")
            {
                CategoriesedNotes = Categoriesed.CategoriesedNotes(Notes);
                UpdateNotes(CategoriesedNotes);
            }
            else
            {
                CategoriesedNotes = Categoriesed.CategoriesedNotes(Notes, mask);
                UpdateNotes(CategoriesedNotes);
            }
        }

        private void textBoxText_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<Note> currentNote = new List<Note>();
            currentNote.Add(CurrentNote);
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "current.json");
            ProjectManager.SaveToFile(currentNote, path);
        }
    }
}
