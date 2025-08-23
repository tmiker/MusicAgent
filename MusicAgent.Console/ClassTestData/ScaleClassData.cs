using MusicServices.Models;
using System.Collections;

namespace MudicAgent.Console.ClassTestData
{
    public class ScaleClassData
    {
        public Scale GetCMajorScale()
        {
            return new Scale()
            {
                Name = "Major",
                RootNoteName = "C",
                ScaleType = "Major",
                ScaleNotes = new List<NoteInterval>()
                {
                    new NoteInterval() {
                        Interval = new Interval() {
                            Name = "Unison",
                            SemiTones = 0,
                            FullName = null,
                            Symbol = "1",
                            Degree = null
                        },
                        Note = new Note() {
                            Name = "C",
                            Position = 0
                        }
                    },
                    new NoteInterval() {
                        Interval = new Interval() {
                            Name = "Major Second",
                            SemiTones = 2,
                            FullName = null,
                            Symbol = "2",
                            Degree = null
                        },
                        Note = new Note() {
                            Name = "D",
                            Position = 2
                        }
                    },
            new NoteInterval() {
                Interval = new Interval() {
                    Name = "Major Third",
                    SemiTones = 4,
                    FullName = null,
                    Symbol = "3",
                    Degree = null
                },
                Note = new Note() {
                    Name = "E",
                    Position = 4
                }
            },
            new NoteInterval() {
                Interval = new Interval() {
                    Name = "Perfect Fourth",
                    SemiTones = 5,
                    FullName = null,
                    Symbol = "4",
                    Degree = null
                },
                Note = new Note() {
                    Name = "F",
                    Position = 5
                }
            },
            new NoteInterval() {
                Interval = new Interval() {
                    Name = "Perfect Fifth",
                    SemiTones = 7,
                    FullName = null,
                    Symbol = "5",
                    Degree = null
                },
                Note = new Note() {
                    Name = "G",
                    Position = 7
                }
            },
            new NoteInterval() {
                Interval = new Interval() {
                    Name = "Major Sixth",
                    SemiTones = 9,
                    FullName = null,
                    Symbol = "6",
                    Degree = null
                },
                Note = new Note() {
                    Name = "A",
                    Position = 9
                }
            },
                    new NoteInterval() {
                        Interval = new Interval() {
                            Name = "Major Seventh",
                            SemiTones = 11,
                            FullName = null,
                            Symbol = "7",
                            Degree = null
                        },
                        Note = new Note() {
                            Name = "B",
                            Position = 11
                        }
                    }
                }
            };
        }

        public Scale GetGMinorScale()
        {
            return new Scale()
            {
                Name = "Minor",
                RootNoteName = "G",
                ScaleType = "Minor",
                ScaleNotes = new List<NoteInterval>()
                {
                    new NoteInterval() {
                        Interval = new Interval() {
                            Name = "Unison",
                            SemiTones = 0,
                            FullName = null,
                            Symbol = "1",
                            Degree = null
                        },
                        Note = new Note() {
                            Name = "G",
                            Position = 0
                        }
                    },
                new NoteInterval() {
                    Interval = new Interval() {
                        Name = "Major Second",
                        SemiTones = 2,
                        FullName = null,
                        Symbol = "2",
                        Degree = null
                    },
                    Note = new Note() {
                        Name = "A",
                        Position = 2
                    }
                },
                new NoteInterval() {
                    Interval = new Interval() {
                        Name = "Minor Third",
                        SemiTones = 3,
                        FullName = null,
                        Symbol = "b3",
                        Degree = null
                    },
                    Note = new Note() {
                        Name = "A#",
                        Position = 3
                    }
                },
                new NoteInterval() {
                    Interval = new Interval() {
                        Name = "Perfect Fourth",
                        SemiTones = 5,
                        FullName = null,
                        Symbol = "4",
                        Degree = null
                    },
                    Note = new Note() {
                        Name = "C",
                        Position = 5
                    }
                },
                new NoteInterval() {
                    Interval = new Interval() {
                        Name = "Perfect Fifth",
                        SemiTones = 7,
                        FullName = null,
                        Symbol = "5",
                        Degree = null
                    },
                    Note = new Note() {
                        Name = "D",
                        Position = 7
                    }
                },
                new NoteInterval() {
                    Interval = new Interval() {
                        Name = "Minor Sixth",
                        SemiTones = 8,
                        FullName = null,
                        Symbol = "b6",
                        Degree = null
                    },
                    Note = new Note() {
                        Name = "D#",
                        Position = 8
                    }
                },
                new NoteInterval() {
                    Interval = new Interval() {
                        Name = "Minor Seventh",
                        SemiTones = 10,
                        FullName = null,
                        Symbol = "b7",
                        Degree = null
                    },
                    Note = new Note() {
                        Name = "F",
                        Position = 10
                    }
                }
                }
            };
        }

        public List<Chord> GetCMajorHarmonyChords()
        {
            return new List<Chord>()
            {
                new Chord()
                {
                    Name = "Major Harmony 1", RootNoteName =  "C", ChordType = "Major Seventh",
                    ChordNotes = new List<NoteInterval>()
                    {
                        new NoteInterval() { Interval = new Interval() { Name = "Unison", SemiTones = 0, Symbol = "1" }, Note = new Note() { Name = "C", Position = 1 } },
                        new NoteInterval() { Interval = new Interval() { Name = "Major Third", SemiTones = 4, Symbol = "3" }, Note = new Note() { Name = "E", Position = 5 } },
                        new NoteInterval() { Interval = new Interval() { Name = "Perfect Fifth", SemiTones = 7, Symbol = "5" }, Note = new Note() { Name = "G", Position = 8 } },
                        new NoteInterval() { Interval = new Interval() { Name = "Major Seventh", SemiTones = 11, Symbol = "7" }, Note = new Note() { Name = "B", Position = 0 } }
                    }
                },
                new Chord()
                {
                    Name = "Major Harmony 2", RootNoteName = "D", ChordType = "Minor Seventh",
                    ChordNotes = new List<NoteInterval>()
                    {
                        new NoteInterval() { Interval = new Interval() { Name = "Unison", SemiTones = 0, Symbol = "1" }, Note = new Note() { Name = "D", Position = 3 } },
                        new NoteInterval() { Interval = new Interval() { Name = "Minor Third", SemiTones = 3, Symbol = "b3" }, Note = new Note() { Name = "F", Position = 6 } },
                        new NoteInterval() { Interval = new Interval() { Name = "Perfect Fifth", SemiTones = 7, Symbol = "5" }, Note = new Note() { Name = "A", Position = 10 } },
                        new NoteInterval() { Interval = new Interval() { Name = "Minor Seventh", SemiTones = 10, Symbol = "b7" }, Note = new Note() { Name = "C", Position = 1 } }
                    }
                },
                new Chord()
                {
                    Name = "Major Harmony 3", RootNoteName = "E", ChordType = "Minor Seventh",
                    ChordNotes = new List<NoteInterval>()
                    {   new NoteInterval() { Interval = new Interval() { Name = "Unison", SemiTones = 0, Symbol = "1" }, Note = new Note() { Name = "E", Position = 5 } },
                        new NoteInterval() { Interval = new Interval() { Name = "Minor Third", SemiTones = 3, Symbol = "b3" }, Note = new Note() { Name = "G", Position = 8 } },
                        new NoteInterval() { Interval = new Interval() { Name = "Perfect Fifth", SemiTones = 7, Symbol = "5" }, Note = new Note() { Name = "B", Position = 0 } },
                        new NoteInterval() { Interval = new Interval() { Name = "Minor Seventh", SemiTones = 10, Symbol = "b7" }, Note = new Note() { Name = "D", Position = 3 } }
                    }
                },
                new Chord()
                {
                    Name = "Major Harmony 4", RootNoteName = "F", ChordType = "Major Seventh",
                    ChordNotes = new List<NoteInterval>()
                    {
                        new NoteInterval() { Interval = new Interval() { Name = "Unison", SemiTones = 0, Symbol = "1" }, Note = new Note() { Name = "F", Position = 6 } },
                        new NoteInterval() { Interval = new Interval() { Name = "Major Third", SemiTones = 4, Symbol = "3" }, Note = new Note() { Name = "A", Position = 10 } },
                        new NoteInterval() { Interval = new Interval() { Name = "Perfect Fifth", SemiTones = 7, Symbol = "5" }, Note = new Note() { Name = "C", Position = 1 } },
                        new NoteInterval() { Interval = new Interval() { Name = "Major Seventh", SemiTones = 11, Symbol = "7" }, Note = new Note() { Name = "E", Position = 5 } }
                    }
                },
                new Chord()
                                {
                    Name = "Major Harmony 5", RootNoteName = "G", ChordType = "Dominant Seventh",
                    ChordNotes = new List<NoteInterval>()
                    {
                        new NoteInterval() { Interval = new Interval() { Name = "Unison", SemiTones = 0, Symbol = "1" }, Note = new Note() { Name = "G", Position = 8 } },
                        new NoteInterval() { Interval = new Interval() { Name = "Major Third", SemiTones = 4, Symbol = "3" }, Note = new Note() { Name = "B", Position = 0 } },
                        new NoteInterval() { Interval = new Interval() { Name = "Perfect Fifth", SemiTones = 7, Symbol = "5" }, Note = new Note() { Name = "D", Position = 3 } },
                        new NoteInterval() { Interval = new Interval() { Name = "Minor Seventh", SemiTones = 10, Symbol = "b7" }, Note = new Note() { Name = "F", Position = 6 } }
                    }
                },
                new Chord()
                {
                    Name = "Major Harmony 6", RootNoteName = "A", ChordType = "Minor Seventh",
                    ChordNotes = new List<NoteInterval>()
                    {
                        new NoteInterval() { Interval = new Interval() { Name = "Unison", SemiTones = 0, Symbol = "1" }, Note = new Note() { Name = "A", Position = 10 } },
                        new NoteInterval() { Interval = new Interval() { Name = "Minor Third", SemiTones = 3, Symbol = "b3" }, Note = new Note() { Name = "C", Position = 1 } },
                        new NoteInterval() { Interval = new Interval() { Name = "Perfect Fifth", SemiTones = 7, Symbol = "5" }, Note = new Note() { Name = "E", Position = 5 } },
                        new NoteInterval() { Interval = new Interval() { Name = "Minor Seventh", SemiTones = 10, Symbol = "b7" }, Note = new Note() { Name = "G", Position = 8 } }
                    }
                },
                new Chord()
                {
                    Name = "Major Harmony 7", RootNoteName = "B", ChordType = "Minor Seven Flat Five",
                    ChordNotes = new List<NoteInterval>()
                    {
                        new NoteInterval() { Interval = new Interval() { Name = "Unison", SemiTones = 0, Symbol = "1" }, Note = new Note() { Name = "B", Position = 0 } },
                        new NoteInterval() { Interval = new Interval() { Name = "Minor Third", SemiTones = 3, Symbol = "b3" }, Note = new Note() { Name = "D", Position = 3 } },
                        new NoteInterval() { Interval = new Interval() { Name = "Flat Fifth", SemiTones = 6, Symbol = "b5" }, Note = new Note() { Name = "F", Position = 6 } },
                        new NoteInterval() { Interval = new Interval() { Name = "Minor Seventh", SemiTones = 10, Symbol = "b7" }, Note = new Note() { Name = "A", Position = 10 } }
                    }
                }
            };
        }

        public List<Chord> GetGMinorHarmonyChords()
        {
            return new List<Chord>()
            {
                new Chord()
                {
                    Name = "Minor Harmony 1", RootNoteName = "G", ChordType = "Minor Seventh",
                    ChordNotes = new List<NoteInterval>()
                    {
                        new NoteInterval() { Interval = new Interval() { Name = "Unison", SemiTones = 0, Symbol = "1" }, Note = new Note() { Name = "G", Position = 2 } },
                        new NoteInterval() { Interval = new Interval() { Name = "Minor Third", SemiTones = 3, Symbol = "b3" }, Note = new Note() { Name = "A#", Position = 5 } },
                        new NoteInterval() { Interval = new Interval() { Name = "Perfect Fifth", SemiTones = 7, Symbol = "5" }, Note = new Note() { Name = "D", Position = 9 } },
                        new NoteInterval() { Interval = new Interval() { Name = "Minor Seventh", SemiTones = 10, Symbol = "b7" }, Note = new Note() { Name = "F", Position = 0 } }
                    }
                },
                new Chord()
                {
                    Name = "Minor Harmony 2", RootNoteName = "A", ChordType = "Minor Seven Flat Five",
                    ChordNotes = new List<NoteInterval>()
                    {
                        new NoteInterval() { Interval = new Interval() { Name = "Unison", SemiTones = 0, Symbol = "1" }, Note = new Note() { Name = "A", Position = 4 } },
                        new NoteInterval() { Interval = new Interval() { Name = "Minor Third", SemiTones = 3, Symbol = "b3" }, Note = new Note() { Name = "C", Position = 7 } },
                        new NoteInterval() { Interval = new Interval() { Name = "Flat Fifth", SemiTones = 6, Symbol = "b5" }, Note = new Note() { Name = "D#", Position = 10 } },
                        new NoteInterval() { Interval = new Interval() { Name = "Minor Seventh", SemiTones = 10, Symbol = "b7" }, Note = new Note() { Name = "G", Position = 2 } }
                    }
                },
                new Chord()
                {
                    Name = "Minor Harmony 3", RootNoteName = "A#", ChordType = "Major Seventh",
                    ChordNotes = new List<NoteInterval>()
                    {
                        new NoteInterval() { Interval = new Interval() { Name = "Unison", SemiTones = 0, Symbol = "1" }, Note = new Note() { Name = "A#", Position = 5 } },
                        new NoteInterval() { Interval = new Interval() { Name = "Major Third", SemiTones = 4, Symbol = "3" }, Note = new Note() { Name = "D", Position = 9 } },
                        new NoteInterval() { Interval = new Interval() { Name = "Perfect Fifth", SemiTones = 7, Symbol = "5" }, Note = new Note() { Name = "F", Position = 0 } },
                        new NoteInterval() { Interval = new Interval() { Name = "Major Seventh", SemiTones = 11, Symbol = "7" }, Note = new Note() { Name = "A", Position = 4 } }
                    }
                },
                new Chord()
                {
                    Name = "Minor Harmony 4", RootNoteName = "C", ChordType = "Minor Seventh",
                    ChordNotes = new List<NoteInterval>()
                    {
                        new NoteInterval() { Interval = new Interval() { Name = "Unison", SemiTones = 0, Symbol = "1" }, Note = new Note() { Name = "C", Position = 7 } },
                        new NoteInterval() { Interval = new Interval() { Name = "Minor Third", SemiTones = 3, Symbol = "b3" }, Note = new Note() { Name = "D#", Position = 10 } },
                        new NoteInterval() { Interval = new Interval() { Name = "Perfect Fifth", SemiTones = 7, Symbol = "5" }, Note = new Note() { Name = "G", Position = 2 } },
                        new NoteInterval() { Interval = new Interval() { Name = "Minor Seventh", SemiTones = 10, Symbol = "b7" }, Note = new Note() { Name = "A#", Position = 5 } }
                    }
                },
                new Chord()
                                {
                    Name = "Minor Harmony 5", RootNoteName = "D", ChordType = "Minor Seventh",
                    ChordNotes = new List<NoteInterval>()
                    {
                        new NoteInterval() { Interval = new Interval() { Name = "Unison", SemiTones = 0, Symbol = "1" }, Note = new Note() { Name = "D", Position = 9 } },
                        new NoteInterval() { Interval = new Interval() { Name = "Minor Third", SemiTones = 3, Symbol = "b3" }, Note = new Note() { Name = "F", Position = 0 } },
                        new NoteInterval() { Interval = new Interval() { Name = "Perfect Fifth", SemiTones = 7, Symbol = "5" }, Note = new Note() { Name = "A", Position = 4 } },
                        new NoteInterval() { Interval = new Interval() { Name = "Minor Seventh", SemiTones = 10, Symbol = "b7" }, Note = new Note() { Name = "C", Position = 7 } }
                    }
                },
                new Chord()
                {
                    Name = "Minor Harmony 6", RootNoteName = "D#", ChordType = "Major Seventh",
                    ChordNotes = new List<NoteInterval>()
                    {
                        new NoteInterval() { Interval = new Interval() { Name = "Unison", SemiTones = 0, Symbol = "1" }, Note = new Note() { Name = "D#", Position = 10 } },
                        new NoteInterval() { Interval = new Interval() { Name = "Major Third", SemiTones = 4, Symbol = "3" }, Note = new Note() { Name = "G", Position = 2 } },
                        new NoteInterval() { Interval = new Interval() { Name = "Perfect Fifth", SemiTones = 7, Symbol = "5" }, Note = new Note() { Name = "A#", Position = 5 } },
                        new NoteInterval() { Interval = new Interval() { Name = "Major Seventh", SemiTones = 11, Symbol = "7" }, Note = new Note() { Name = "D", Position = 9 } }
                    }
                },
                new Chord()
                {
                    Name = "Minor Harmony 7", RootNoteName = "F", ChordType = "Dominant Seventh",
                    ChordNotes = new List<NoteInterval>()
                    {
                        new NoteInterval() { Interval = new Interval() { Name = "Unison", SemiTones = 0, Symbol = "1" }, Note = new Note() { Name = "F", Position = 0 } },
                        new NoteInterval() { Interval = new Interval() { Name = "Major Third", SemiTones = 4, Symbol = "3" }, Note = new Note() { Name = "A", Position = 4 } },
                        new NoteInterval() { Interval = new Interval() { Name = "Perfect Fifth", SemiTones = 7, Symbol = "5" }, Note = new Note() { Name = "C", Position = 7 } },
                        new NoteInterval() { Interval = new Interval() { Name = "Minor Seventh", SemiTones = 10, Symbol = "b7" }, Note = new Note() { Name = "D#", Position = 10 } }
                    }
                }
            };
        }
    }
}
