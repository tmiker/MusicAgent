using MusicServices.Models;
using System.Collections;

namespace MusicServices.ClassTestData
{
    public class ScaleClassData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return [GetCMajorScale(), GetCMajorHarmonyChords()];
            yield return [GetGMinorScale(), GetGMinorHarmonyChords()];
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        private Scale GetCMajorScale()
        {
            return new Scale()
            {
                Name = "Major",
                RootNoteName = "C",
                ScaleType = "Major",
                ScaleNotes = new List<ScaleNote>()
                {
                    new ScaleNote() {
                        Interval = new Interval() {
                            FullName = "Unison",
                            SemiTones = 0,
                            Name = "1st",
                            Symbol = "I",
                            Degree = "Tonic"
                        },
                        Note = new Note() {
                            Name = "C",
                            Position = 0
                        }
                    },
                    new ScaleNote() {
                        Interval = new Interval() {
                            FullName = "Major Second",
                            SemiTones = 2,
                            Name = "2nd",
                            Symbol = "II",
                            Degree = "Supertonic"
                        },
                        Note = new Note() {
                            Name = "D",
                            Position = 2
                        }
                    },
            new ScaleNote() {
                Interval = new Interval() {
                    FullName = "Major Third",
                    SemiTones = 4,
                    Name = "3rd",
                    Symbol = "III",
                    Degree = "Mediant"
                },
                Note = new Note() {
                    Name = "E",
                    Position = 4
                }
            },
            new ScaleNote() {
                Interval = new Interval() {
                    FullName = "Perfect Fourth",
                    SemiTones = 5,
                    Name = "4th",
                    Symbol = "IV",
                    Degree = "Sub-Dominant"
                },
                Note = new Note() {
                    Name = "F",
                    Position = 5
                }
            },
            new ScaleNote() {
                Interval = new Interval() {
                    FullName = "Perfect Fifth",
                    SemiTones = 7,
                    Name = "5th",
                    Symbol = "V",
                    Degree = "Dominant"
                },
                Note = new Note() {
                    Name = "G",
                    Position = 7
                }
            },
            new ScaleNote() {
                Interval = new Interval() {
                    FullName = "Major Sixth / Diminished Seventh",
                    SemiTones = 9,
                    Name = "6th / bb 7th",
                    Symbol = "VI / vii °",
                    Degree = "Sub-Mediant"
                },
                Note = new Note() {
                    Name = "A",
                    Position = 9
                }
            },
                    new ScaleNote() {
                        Interval = new Interval() {
                            FullName = "Major Seventh",
                            SemiTones = 11,
                            Name = "7th",
                            Symbol = "VII",
                            Degree = "Leading Note"
                        },
                        Note = new Note() {
                            Name = "B",
                            Position = 11
                        }
                    }
                }
            };
        }

        private Scale GetGMinorScale()
        {
            return new Scale()
            {
                Name = "Minor",
                RootNoteName = "G",
                ScaleType = "Minor",
                ScaleNotes = new List<ScaleNote>()
                {
                    new ScaleNote() {
                        Interval = new Interval() {
                            FullName = "Unison",
                            SemiTones = 0,
                            Name = "1st",
                            Symbol = "I",
                            Degree = "Tonic"
                        },
                        Note = new Note() {
                            Name = "G",
                            Position = 0
                        }
                    },
                new ScaleNote() {
                    Interval = new Interval() {
                        FullName = "Major Second",
                        SemiTones = 2,
                        Name = "2nd",
                        Symbol = "II",
                        Degree = null
                    },
                    Note = new Note() {
                        Name = "A",
                        Position = 2
                    }
                },
                new ScaleNote() {
                    Interval = new Interval() {
                        FullName = "Minor Third",
                        SemiTones = 3,
                        Name = "b 3rd",
                        Symbol = "iii",
                        Degree = "Mediant"
                    },
                    Note = new Note() {
                        Name = "A# / Bb",
                        Position = 3
                    }
                },
                new ScaleNote() {
                    Interval = new Interval() {
                        FullName = "Perfect Fourth",
                        SemiTones = 5,
                        Name = "4th",
                        Symbol = "IV",
                        Degree = "Sub-Dominant"
                    },
                    Note = new Note() {
                        Name = "C",
                        Position = 5
                    }
                },
                new ScaleNote() {
                    Interval = new Interval() {
                        FullName = "Perfect Fifth",
                        SemiTones = 7,
                        Name = "5th",
                        Symbol = "V",
                        Degree = "Dominant"
                    },
                    Note = new Note() {
                        Name = "D",
                        Position = 7
                    }
                },
                new ScaleNote() {
                    Interval = new Interval() {
                        FullName = "Augmented Fifth / Minor Sixth",
                        SemiTones = 8,
                        Name = "# 5th / b 6th",
                        Symbol = "V + / vi",
                        Degree = "Sub-Mediant"
                    },
                    Note = new Note() {
                        Name = "D# / Eb",
                        Position = 8
                    }
                },
                new ScaleNote() {
                    Interval = new Interval() {
                        FullName = "Minor Seventh",
                        SemiTones = 10,
                        Name = "b 7th",
                        Symbol = "vii",
                        Degree = "Sub-Tonic"
                    },
                    Note = new Note() {
                        Name = "F",
                        Position = 10
                    }
                }
                }
            };
        }

        private List<Chord> GetCMajorHarmonyChords()
        {
            return new List<Chord>()
            {
                new Chord()
                {
                    Name = "Major Harmony 1", RootNoteName =  "C", ChordType = "Major Seventh",
                    ChordNotes = new List<ChordNote>()
                    {
                        new ChordNote() { Interval = new Interval() { Name = "1st", FullName = "Unison", SemiTones = 0, Symbol = "I" }, Note = new Note() { Name = "C", Position = 1 } },
                        new ChordNote() { Interval = new Interval() { Name = "3rd", FullName = "Major Third", SemiTones = 4, Symbol = "III" }, Note = new Note() { Name = "E", Position = 5 } },
                        new ChordNote() { Interval = new Interval() { Name = "5th", FullName = "Perfect Fifth", SemiTones = 7, Symbol = "V" }, Note = new Note() { Name = "G", Position = 8 } },
                        new ChordNote() { Interval = new Interval() { Name = "7th", FullName = "Major Seventh", SemiTones = 11, Symbol = "VII" }, Note = new Note() { Name = "B", Position = 0 } }
                    }
                },
                new Chord()
                {
                    Name = "Major Harmony 2", RootNoteName = "D", ChordType = "Minor Seventh",
                    ChordNotes = new List<ChordNote>()
                    {
                        new ChordNote() { Interval = new Interval() { Name = "1st", FullName = "Unison", SemiTones = 0, Symbol = "I" }, Note = new Note() { Name = "D", Position = 3 } },
                        new ChordNote() { Interval = new Interval() { Name = "b 3rd", FullName = "Minor Third", SemiTones = 3, Symbol = "iii" }, Note = new Note() { Name = "F", Position = 6 } },
                        new ChordNote() { Interval = new Interval() { Name = "5th", FullName = "Perfect Fifth", SemiTones = 7, Symbol = "V" }, Note = new Note() { Name = "A", Position = 10 } },
                        new ChordNote() { Interval = new Interval() { Name = "b 7th", FullName = "Minor Seventh", SemiTones = 10, Symbol = "vii" }, Note = new Note() { Name = "C", Position = 1 } }
                    }
                },
                new Chord()
                {
                    Name = "Major Harmony 3", RootNoteName = "E", ChordType = "Minor Seventh",
                    ChordNotes = new List<ChordNote>()
                    {   new ChordNote() { Interval = new Interval() { Name = "1st", FullName = "Unison", SemiTones = 0, Symbol = "I" }, Note = new Note() { Name = "E", Position = 5 } },
                        new ChordNote() { Interval = new Interval() { Name = "b 3rd", FullName = "Minor Third", SemiTones = 3, Symbol = "iii" }, Note = new Note() { Name = "G", Position = 8 } },
                        new ChordNote() { Interval = new Interval() { Name = "5th", FullName = "Perfect Fifth", SemiTones = 7, Symbol = "V" }, Note = new Note() { Name = "B", Position = 0 } },
                        new ChordNote() { Interval = new Interval() { Name = "b 7th", FullName = "Minor Seventh", SemiTones = 10, Symbol = "vii" }, Note = new Note() { Name = "D", Position = 3 } }
                    }
                },
                new Chord()
                {
                    Name = "Major Harmony 4", RootNoteName = "F", ChordType = "Major Seventh",
                    ChordNotes = new List<ChordNote>()
                    {
                        new ChordNote() { Interval = new Interval() { Name = "1st", FullName = "Unison", SemiTones = 0, Symbol = "I" }, Note = new Note() { Name = "F", Position = 6 } },
                        new ChordNote() { Interval = new Interval() { Name = "3rd", FullName = "Major Third", SemiTones = 4, Symbol = "III" }, Note = new Note() { Name = "A", Position = 10 } },
                        new ChordNote() { Interval = new Interval() { Name = "5th", FullName = "Perfect Fifth", SemiTones = 7, Symbol = "V" }, Note = new Note() { Name = "C", Position = 1 } },
                        new ChordNote() { Interval = new Interval() { Name = "7th", FullName = "Major Seventh", SemiTones = 11, Symbol = "VII" }, Note = new Note() { Name = "E", Position = 5 } }
                    }
                },
                new Chord()
                                {
                    Name = "Major Harmony 5", RootNoteName = "G", ChordType = "Dominant Seventh",
                    ChordNotes = new List<ChordNote>()
                    {
                        new ChordNote() { Interval = new Interval() { Name = "1st", FullName = "Unison", SemiTones = 0, Symbol = "I" }, Note = new Note() { Name = "G", Position = 8 } },
                        new ChordNote() { Interval = new Interval() { Name = "3rd", FullName = "Major Third", SemiTones = 4, Symbol = "III" }, Note = new Note() { Name = "B", Position = 0 } },
                        new ChordNote() { Interval = new Interval() { Name = "5th", FullName = "Perfect Fifth", SemiTones = 7, Symbol = "V" }, Note = new Note() { Name = "D", Position = 3 } },
                        new ChordNote() { Interval = new Interval() { Name = "b 7th", FullName = "Minor Seventh", SemiTones = 10, Symbol = "vii" }, Note = new Note() { Name = "F", Position = 6 } }
                    }
                },
                new Chord()
                {
                    Name = "Major Harmony 6", RootNoteName = "A", ChordType = "Minor Seventh",
                    ChordNotes = new List<ChordNote>()
                    {
                        new ChordNote() { Interval = new Interval() { Name = "1st", FullName = "Unison", SemiTones = 0, Symbol = "I" }, Note = new Note() { Name = "A", Position = 10 } },
                        new ChordNote() { Interval = new Interval() { Name = "b 3rd", FullName = "Minor Third", SemiTones = 3, Symbol = "iii" }, Note = new Note() { Name = "C", Position = 1 } },
                        new ChordNote() { Interval = new Interval() { Name = "5th", FullName = "Perfect Fifth", SemiTones = 7, Symbol = "V" }, Note = new Note() { Name = "E", Position = 5 } },
                        new ChordNote() { Interval = new Interval() { Name = "b 7th", FullName = "Minor Seventh", SemiTones = 10, Symbol = "vii" }, Note = new Note() { Name = "G", Position = 8 } }
                    }
                },
                new Chord()
                {
                    Name = "Major Harmony 7", RootNoteName = "B", ChordType = "Minor Seven Flat Five",
                    ChordNotes = new List<ChordNote>()
                    {
                        new ChordNote() { Interval = new Interval() { Name = "1st", FullName = "Unison", SemiTones = 0, Symbol = "I" }, Note = new Note() { Name = "B", Position = 0 } },
                        new ChordNote() { Interval = new Interval() { Name = "b 3rd", FullName = "Minor Third", SemiTones = 3, Symbol = "iii" }, Note = new Note() { Name = "D", Position = 3 } },
                        new ChordNote() { Interval = new Interval() { Name = "# 4th / b 5th", FullName = "Augmented Fourth / Diminished Fifth", SemiTones = 6, Symbol = "IV + / V °" }, Note = new Note() { Name = "F", Position = 6 } },
                        new ChordNote() { Interval = new Interval() { Name = "b 7th", FullName = "Minor Seventh", SemiTones = 10, Symbol = "vii" }, Note = new Note() { Name = "A", Position = 10 } }
                    }
                }
            };
        }

        private List<Chord> GetGMinorHarmonyChords()
        {
            return new List<Chord>()
            {
                new Chord()
                {
                    Name = "Minor Harmony 1", RootNoteName = "G", ChordType = "Minor Seventh",
                    ChordNotes = new List<ChordNote>()
                    {
                        new ChordNote() { Interval = new Interval() { Name = "1st", FullName = "Unison", SemiTones = 0, Symbol = "I" }, Note = new Note() { Name = "G", Position = 2 } },
                        new ChordNote() { Interval = new Interval() { Name = "b 3rd", FullName = "Minor Third", SemiTones = 3, Symbol = "iii" }, Note = new Note() { Name = "A# / Bb", Position = 5 } },
                        new ChordNote() { Interval = new Interval() { Name = "5th", FullName = "Perfect Fifth", SemiTones = 7, Symbol = "V" }, Note = new Note() { Name = "D", Position = 9 } },
                        new ChordNote() { Interval = new Interval() { Name = "b 7th", FullName = "Minor Seventh", SemiTones = 10, Symbol = "b7" }, Note = new Note() { Name = "F", Position = 0 } }
                    }
                },
                new Chord()
                {
                    Name = "Minor Harmony 2", RootNoteName = "A", ChordType = "Minor Seven Flat Five",
                    ChordNotes = new List<ChordNote>()
                    {
                        new ChordNote() { Interval = new Interval() { Name = "1st", FullName = "Unison", SemiTones = 0, Symbol = "I" }, Note = new Note() { Name = "A", Position = 4 } },
                        new ChordNote() { Interval = new Interval() { Name = "b 3rd", FullName = "Minor Third", SemiTones = 3, Symbol = "iii" }, Note = new Note() { Name = "C", Position = 7 } },
                        new ChordNote() { Interval = new Interval() { Name = "# 4th / b 5th", FullName = "Augmented Fourth / Diminished Fifth", SemiTones = 6, Symbol = "IV + / V °" }, Note = new Note() { Name = "D# / Eb", Position = 10 } },
                        new ChordNote() { Interval = new Interval() { Name = "b 7th", FullName = "Minor Seventh", SemiTones = 10, Symbol = "vii" }, Note = new Note() { Name = "G", Position = 2 } }
                    }
                },
                new Chord()
                {
                    Name = "Minor Harmony 3", RootNoteName = "A# / Bb", ChordType = "Major Seventh",
                    ChordNotes = new List<ChordNote>()
                    {
                        new ChordNote() { Interval = new Interval() { Name = "1st", FullName = "Unison", SemiTones = 0, Symbol = "I" }, Note = new Note() { Name = "A# / Bb", Position = 5 } },
                        new ChordNote() { Interval = new Interval() { Name = "3rd", FullName = "Major Third", SemiTones = 4, Symbol = "III" }, Note = new Note() { Name = "D", Position = 9 } },
                        new ChordNote() { Interval = new Interval() { Name = "5th", FullName = "Perfect Fifth", SemiTones = 7, Symbol = "V" }, Note = new Note() { Name = "F", Position = 0 } },
                        new ChordNote() { Interval = new Interval() { Name = "7th", FullName = "Major Seventh", SemiTones = 11, Symbol = "VII" }, Note = new Note() { Name = "A", Position = 4 } }
                    }
                },
                new Chord()
                {
                    Name = "Minor Harmony 4", RootNoteName = "C", ChordType = "Minor Seventh",
                    ChordNotes = new List<ChordNote>()
                    {
                        new ChordNote() { Interval = new Interval() { Name = "1st", FullName = "Unison", SemiTones = 0, Symbol = "I" }, Note = new Note() { Name = "C", Position = 7 } },
                        new ChordNote() { Interval = new Interval() { Name = "b 3rd", FullName = "Minor Third", SemiTones = 3, Symbol = "iii" }, Note = new Note() { Name = "D# / Eb", Position = 10 } },
                        new ChordNote() { Interval = new Interval() { Name = "5th", FullName = "Perfect Fifth", SemiTones = 7, Symbol = "V" }, Note = new Note() { Name = "G", Position = 2 } },
                        new ChordNote() { Interval = new Interval() { Name = "b 7th", FullName = "Minor Seventh", SemiTones = 10, Symbol = "vii" }, Note = new Note() { Name = "A# / Bb", Position = 5 } }
                    }
                },
                new Chord()
                                {
                    Name = "Minor Harmony 5", RootNoteName = "D", ChordType = "Minor Seventh",
                    ChordNotes = new List<ChordNote>()
                    {
                        new ChordNote() { Interval = new Interval() { Name = "1st", FullName = "Unison", SemiTones = 0, Symbol = "I" }, Note = new Note() { Name = "D", Position = 9 } },
                        new ChordNote() { Interval = new Interval() { Name = "b 3rd", FullName = "Minor Third", SemiTones = 3, Symbol = "iii" }, Note = new Note() { Name = "F", Position = 0 } },
                        new ChordNote() { Interval = new Interval() { Name = "5th", FullName = "Perfect Fifth", SemiTones = 7, Symbol = "V" }, Note = new Note() { Name = "A", Position = 4 } },
                        new ChordNote() { Interval = new Interval() { Name = "b 7th", FullName = "Minor Seventh", SemiTones = 10, Symbol = "vii" }, Note = new Note() { Name = "C", Position = 7 } }
                    }
                },
                new Chord()
                {
                    Name = "Minor Harmony 6", RootNoteName = "D# / Eb", ChordType = "Major Seventh",
                    ChordNotes = new List<ChordNote>()
                    {
                        new ChordNote() { Interval = new Interval() { Name = "1st", FullName = "Unison", SemiTones = 0, Symbol = "I" }, Note = new Note() { Name = "D# / Eb", Position = 10 } },
                        new ChordNote() { Interval = new Interval() { Name = "3rd", FullName = "Major Third", SemiTones = 4, Symbol = "III" }, Note = new Note() { Name = "G", Position = 2 } },
                        new ChordNote() { Interval = new Interval() { Name = "5th", FullName = "Perfect Fifth", SemiTones = 7, Symbol = "V" }, Note = new Note() { Name = "A# / Bb", Position = 5 } },
                        new ChordNote() { Interval = new Interval() { Name = "7th", FullName = "Major Seventh", SemiTones = 11, Symbol = "VII" }, Note = new Note() { Name = "D", Position = 9 } }
                    }
                },
                new Chord()
                {
                    Name = "Minor Harmony 7", RootNoteName = "F", ChordType = "Dominant Seventh",
                    ChordNotes = new List<ChordNote>()
                    {
                        new ChordNote() { Interval = new Interval() { Name = "1st", FullName = "Unison", SemiTones = 0, Symbol = "I" }, Note = new Note() { Name = "F", Position = 0 } },
                        new ChordNote() { Interval = new Interval() { Name = "3rd", FullName = "Major Third", SemiTones = 4, Symbol = "III" }, Note = new Note() { Name = "A", Position = 4 } },
                        new ChordNote() { Interval = new Interval() { Name = "5th", FullName = "Perfect Fifth", SemiTones = 7, Symbol = "V" }, Note = new Note() { Name = "C", Position = 7 } },
                        new ChordNote() { Interval = new Interval() { Name = "b 7th", FullName = "Minor Seventh", SemiTones = 10, Symbol = "vii" }, Note = new Note() { Name = "D# / Eb", Position = 10 } }
                    }
                }
            };
        }
    }
}
