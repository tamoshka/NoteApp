using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return categoriesedNotes;
        }
    }
}
