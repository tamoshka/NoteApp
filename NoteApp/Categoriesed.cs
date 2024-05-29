using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace NoteApp
{
    /// <summary>
    /// Класс поиска заметок по категории
    /// </summary>
    public static class Categoriesed
    {
        public static List<Note> CategoriesedNotes(List<Note> notes, string mask)
        {
            var categoriesedNotes= new List<Note>();
            foreach (var note in notes)
            {
                if (note.Category.ToString()==mask)
                {
                    categoriesedNotes.Add(note);
                }
            }
            for (int i = 1; i < categoriesedNotes.Count; i++)
            {
                for (int j = 0; j < categoriesedNotes.Count - i; j++)
                {
                    if (categoriesedNotes[j].LastUpdated < categoriesedNotes[j + 1].LastUpdated)
                    {
                        var temp = categoriesedNotes[j];
                        categoriesedNotes[j] = categoriesedNotes[j + 1];
                        categoriesedNotes[j + 1] = temp;
                    }
                }
            }
            return categoriesedNotes;
        }

        public static List<Note> CategoriesedNotes(List<Note> notes)
        {
            var categoriesedNotes = notes;
            for (int i = 1; i < categoriesedNotes.Count; i++)
            {
                for (int j = 0;j< categoriesedNotes.Count-i;j++)
                {
                    if (categoriesedNotes[j].LastUpdated < categoriesedNotes[j+1].LastUpdated)
                    {
                        var temp = categoriesedNotes[j];
                        categoriesedNotes[j] = categoriesedNotes[j + 1];
                        categoriesedNotes[j + 1] = temp;
                    }
                }
            }
            return categoriesedNotes;
        }
    }
}
