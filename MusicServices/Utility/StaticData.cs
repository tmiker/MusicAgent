using MusicServices.Models;

namespace MusicServices.Utility
{
    public class StaticData
    {
        public static List<Interval> IntervalList = new List<Interval>()
        {
            new Interval { Id = 1, Name = "1st", SemiTones = 0, FullName = "Unison", Symbol = "I", Degree = "Tonic", Sound = "Open Consonance" },
                new Interval { Id = 2, Name = "b 2nd", SemiTones = 1, FullName = "Minor Second", Symbol = "ii", Degree = "Supertonic", Sound = "Sharp Dissonance"  },
                new Interval { Id = 3, Name = "2nd", SemiTones = 2, FullName = "Major Second", Symbol = "II", Degree = "Supertonic", Sound = "Mild Dissonance"  },
                new Interval { Id = 4, Name = "b 3rd", SemiTones = 3, FullName = "Minor Third", Symbol = "iii", Degree = "Mediant", Sound = "Soft Consonance"  },
                new Interval { Id = 5, Name = "3rd", SemiTones = 4, FullName = "Major Third", Symbol = "III", Degree = "Mediant", Sound = "Soft Consonance"  },
                new Interval { Id = 6, Name = "4th", SemiTones = 5, FullName = "Perfect Fourth", Symbol = "IV", Degree = "Sub-Dominant", Sound = "Consonance or Dissonance"  },
                new Interval { Id = 7, Name = "# 4th / b 5th", SemiTones = 6, FullName = "Augmented Fourth / Diminished Fifth", Symbol = "IV + / V °", Degree = "Tritone", Sound = "Neutral / Restless"  },
                // new Interval { Id = 8, Name = "♭ 5th", SemiTones = 6, FullName = "Diminished Fifth", Symbol = "V °", Degree = "Tritone", Sound = "Restless"  },
                new Interval { Id = 8, Name = "5th", SemiTones = 7, FullName = "Perfect Fifth", Symbol = "V", Degree = "Dominant", Sound = "Open Consonance"  },
                new Interval { Id = 9, Name = "# 5th / b 6th", SemiTones = 8, FullName = "Augmented Fifth / Minor Sixth", Symbol = "V + / vi", Degree = "Sub-Mediant", Sound = "Soft Consonance"  },
                // new Interval { Id = 11, Name = "♭ 6th", SemiTones = 8, FullName = "Minor Sixth", Symbol = "vi", Degree = "Sub-Mediant", Sound = "Soft Consonance"  },
                new Interval { Id = 10, Name = "6th / bb 7th", SemiTones = 9, FullName = "Major Sixth / Diminished Seventh", Symbol = "VI / vii °", Degree = "Sub-Mediant", Sound = "Soft Consonance"  },
                // new Interval { Id = 13, Name = "♭♭ 7th", SemiTones = 9, FullName = "Diminished Seventh", Symbol = "vii °", Degree = "Sub-Mediant", Sound = "Soft Consonance"  },
                new Interval { Id = 11, Name = "b 7th", SemiTones = 10, FullName = "Minor Seventh", Symbol = "vii", Degree = "Sub-Tonic", Sound = "Mild Dissonance"  },
                new Interval { Id = 12, Name = "7th", SemiTones = 11, FullName = "Major Seventh", Symbol = "VII", Degree = "Leading Note", Sound = "Sharp Dissonance"  }
        };

        public static List<Note> NoteList = new List<Note>()
        {
            new Note { Id = 1, Name = "C", Position = 0 },
                new Note { Id = 2, Name = "C# / Db", Position = 1 },
                new Note { Id = 3, Name = "D", Position = 2 },
                new Note { Id = 4, Name = "D# / Eb", Position = 3 },
                new Note { Id = 5, Name = "E", Position = 4 },
                new Note { Id = 6, Name = "F", Position = 5 },
                new Note { Id = 7, Name = "F# / Gb", Position = 6 },
                new Note { Id = 8, Name = "G", Position = 7 },
                new Note { Id = 9, Name = "G# / Ab", Position = 8 },
                new Note { Id = 10, Name = "A", Position = 9 },
                new Note { Id = 11, Name = "A# / Bb", Position = 10 },
                new Note { Id = 12, Name = "B", Position = 11 }
        };
    }
}
