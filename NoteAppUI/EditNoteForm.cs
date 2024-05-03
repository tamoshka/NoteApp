using NoteApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NoteAppUI
{
    public partial class AddEditNoteForm : Form
    {
        /// <summary>
        /// Текущая заметка для редактирования/создания.
        /// </summary>
        public Note CurrentNote { get; set; } 

        /// <summary>
        /// Инициализация формы
        /// </summary>
        public AddEditNoteForm()
        {
            InitializeComponent();
            CategoryComboBox.Items.Add(NoteCategories.Документы);
            CategoryComboBox.Items.Add(NoteCategories.Работа);
            CategoryComboBox.Items.Add(NoteCategories.Разное);
            CategoryComboBox.Items.Add(NoteCategories.Люди);
            CategoryComboBox.Items.Add(NoteCategories.ЗдоровьеИСпорт);
            CategoryComboBox.Items.Add(NoteCategories.Дом);
            CategoryComboBox.Items.Add(NoteCategories.Финансы);
            CurrentNote = TransferNote.Data;
            if (CurrentNote.Name == null)
            {
                BlockCreateButton();
                СolorizeTextBoxes();
                CurrentNote.Created = dateTimePickerCreated.Value;
                CurrentNote.LastUpdated = dateTimePickerModified.Value;
            }
            else
            {
                UpdateNoteInformation(CurrentNote);
            }
        }

        /// <summary>
        /// Метод отмены создания/редактирования заметки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Выключение кнопки подтверждения
        /// </summary>
        private void BlockCreateButton()
        {
            OKButton.Enabled = false;
        }

        /// <summary>
        /// Метод проверяет, можно ли разблокировать кнопку для принятия изменений.
        /// </summary>
        private void TryUnlockCreateButton()
        {
            if (CheckCorrectnessFields())
            {
                OKButton.Enabled = true;
            }
        }

        /// <summary>
        /// Обработчик попытки изменения даты создания заметки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePickerCreated_ValueChanged(object sender, EventArgs e)
        {
            if (CurrentNote.Name != null)
            {
                dateTimePickerCreated.Value = CurrentNote.Created;
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
            if (CurrentNote.Name != null)
            {
                dateTimePickerModified.Value = CurrentNote.LastUpdated;
            }
            else
            {
                dateTimePickerModified.Value = DateTime.Now;
            }
        }

        private void UpdateNoteInformation(Note note)
        {
            NameTextBox.Text = note.Name;
            CategoryComboBox.Text = note.Category.ToString();
            dateTimePickerCreated.Value = note.Created;
            dateTimePickerModified.Value = note.LastUpdated;
            TextTextBox.Text = note.Text;
        }

        /// <summary>
        /// Окрашивает пустые поля в красный цвет при создании новой заметки
        /// </summary>
        private void СolorizeTextBoxes()
        {
            NameTextBox.BackColor = Color.LightCoral;
            CategoryComboBox.BackColor = Color.LightCoral;
            TextTextBox.BackColor = Color.LightCoral;
        }

        /// <summary>
        /// Проверка, что все поля прошли валидацию.
        /// </summary>
        /// <returns>True, если все поля прошли валидацию, иначе False.</returns>
        private bool CheckCorrectnessFields()
        {
            if (NameTextBox.BackColor == CategoryComboBox.BackColor &&
                CategoryComboBox.BackColor == TextTextBox.BackColor &&
                TextTextBox.BackColor == Color.White)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Событие изменения названия заметки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CurrentNote.Name = NameTextBox.Text;
                NameTextBox.BackColor = Color.White;
                TryUnlockCreateButton();
            }
            catch
            {
                NameTextBox.BackColor = Color.LightCoral;
                BlockCreateButton();
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CategoryComboBox.Text)
            {
                case "Документы":
                    CurrentNote.Category = NoteCategories.Документы;
                    CategoryComboBox.BackColor = Color.White;
                    TryUnlockCreateButton();
                    break;
                case "Дом":
                    CurrentNote.Category = NoteCategories.Дом;
                    CategoryComboBox.BackColor = Color.White;
                    TryUnlockCreateButton();
                    break;
                case "Работа":
                    CurrentNote.Category = NoteCategories.Работа;
                    CategoryComboBox.BackColor = Color.White;
                    TryUnlockCreateButton();
                    break;
                case "Разное":
                    CurrentNote.Category = NoteCategories.Разное;
                    CategoryComboBox.BackColor = Color.White;
                    TryUnlockCreateButton();
                    break;
                case "Люди":
                    CurrentNote.Category = NoteCategories.Люди;
                    CategoryComboBox.BackColor = Color.White;
                    TryUnlockCreateButton();
                    break;
                case "ЗдоровьеИСпорт":
                    CurrentNote.Category = NoteCategories.ЗдоровьеИСпорт;
                    CategoryComboBox.BackColor = Color.White;
                    TryUnlockCreateButton();
                    break;
                case "Финансы":
                    CurrentNote.Category = NoteCategories.Финансы;
                    CategoryComboBox.BackColor = Color.White;
                    TryUnlockCreateButton();
                    break;
                default:
                    break;
            }
        }

        private void TextTextBox_TextChanged(object sender, EventArgs e)
        {
            CurrentNote.Text= TextTextBox.Text;
            TextTextBox.BackColor = Color.White;
            TryUnlockCreateButton();
        }
    }
}
