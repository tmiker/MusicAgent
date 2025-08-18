using MusicServices.Models;

namespace MusicServices.Utility
{
    public class StaticData
    {
        public static List<Interval> IntervalList = new List<Interval>()
        {
            new Interval() { Name = "Unison", SemiTones = 0, Symbol = "1" },
            new Interval() { Name = "Minor Second", SemiTones = 1, Symbol = "b2" },
            new Interval() { Name = "Major Second", SemiTones = 2, Symbol = "2" },
            new Interval() { Name = "Minor Third", SemiTones = 3, Symbol = "b3" },
            new Interval() { Name = "Major Third", SemiTones = 4, Symbol = "3" },
            new Interval() { Name = "Perfect Fourth", SemiTones = 5, Symbol = "4" },
            new Interval() { Name = "Flat Fifth", SemiTones = 6, Symbol = "b5" },
            new Interval() { Name = "Perfect Fifth", SemiTones = 7, Symbol = "5" },
            new Interval() { Name = "Minor Sixth", SemiTones = 8, Symbol = "b6" },
            new Interval() { Name = "Major Sixth", SemiTones = 9, Symbol = "6" },
            new Interval() { Name = "Minor Seventh", SemiTones = 10, Symbol = "b7" },
            new Interval() { Name = "Major Seventh", SemiTones = 11, Symbol = "7" }
        };

        public static List<Note> NoteList = new List<Note>()
        {
            new Note() { Name = "A"},
            new Note() { Name = "A#"},
            new Note() { Name = "B"},
            new Note() { Name = "C" },
            new Note() { Name = "C#"},
            new Note() { Name = "D" },
            new Note() { Name = "D#" },
            new Note() { Name = "E"},
            new Note() { Name = "F"},
            new Note() { Name = "F#" },
            new Note() { Name = "G"},
            new Note() { Name = "G#" }
        };
    }
}
