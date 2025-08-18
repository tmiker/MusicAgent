using MusicServices.Models;

namespace MusicServices
{
    public class ChordComparer : IComparer<Chord>
    {
        public int Compare(Chord? x, Chord? y)
        {
            if (x is null && y is null) return 0;
            if (x is null) return -1; // nulls are less than any non-null
            if (y is null) return 1; // any non-null is greater than null
            int rootNoteComparison = string.Compare(x.RootNoteName, y.RootNoteName, StringComparison.OrdinalIgnoreCase);
            if (rootNoteComparison != 0) return rootNoteComparison; // compare by root note name first
            int chordTypeComparison = string.Compare(x.ChordType, y.ChordType, StringComparison.OrdinalIgnoreCase);
            if (chordTypeComparison != 0) return chordTypeComparison; // compare by chord type
            return 0;
        }
    }
}
