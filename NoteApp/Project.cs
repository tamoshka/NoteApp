using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    public static class Project
    {
        private static List<Note> _notes = new List<Note>();

        private static Note _currentNote;
        public static List<Note> Notes
        {
            get
            {
                return _notes;
            }
            set
            {
                _notes = value;
            }
        }
        public static Note CurrentNote
        {
            get
            {
                return _currentNote;
            }
            set
            {
                _currentNote = value;
            }
        }
    }
}
