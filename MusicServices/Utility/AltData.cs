using MusicServices.Models;

namespace MusicServices.Utility
{
    public class AltData
    {
        private static List<Note> _notes { get; set; } = new List<Note>()
        {
            new Note { Id = 1, Name = "C", Position = 0 },
                new Note { Id = 2, Name = "C ♯ / D ♭", Position = 1 },
                new Note { Id = 3, Name = "D", Position = 2 },
                new Note { Id = 4, Name = "D ♯ / E ♭", Position = 3 },
                new Note { Id = 5, Name = "E", Position = 4 },
                new Note { Id = 6, Name = "F", Position = 5 },
                new Note { Id = 7, Name = "F ♯ / G ♭", Position = 6 },
                new Note { Id = 8, Name = "G", Position = 7 },
                new Note { Id = 9, Name = "G ♯ / A ♭", Position = 8 },
                new Note { Id = 10, Name = "A", Position = 9 },
                new Note { Id = 11, Name = "A ♯ / B ♭", Position = 10 },
                new Note { Id = 12, Name = "B", Position = 11 }
        };

        public static List<Note> GetNotes() => _notes.ToList();

        private static List<Interval> _intervals { get; set; } = new List<Interval>()
        {
            new Interval { Id = 1, Name = "1st", SemiTones = 0, FullName = "Unison", Symbol = "I", Degree = "Tonic", Sound = "Open Consonance" },
                new Interval { Id = 2, Name = "♭ 2nd", SemiTones = 1, FullName = "Minor Second", Symbol = "ii", Degree = "Supertonic", Sound = "Sharp Dissonance"  },
                new Interval { Id = 3, Name = "2nd", SemiTones = 2, FullName = "Major Second", Symbol = "II", Degree = "Supertonic", Sound = "Mild Dissonance"  },
                new Interval { Id = 4, Name = "♭ 3rd", SemiTones = 3, FullName = "Minor Third", Symbol = "iii", Degree = "Mediant", Sound = "Soft Consonance"  },
                new Interval { Id = 5, Name = "3rd", SemiTones = 4, FullName = "Major Third", Symbol = "III", Degree = "Mediant", Sound = "Soft Consonance"  },
                new Interval { Id = 6, Name = "4th", SemiTones = 5, FullName = "Perfect Fourth", Symbol = "IV", Degree = "Sub-Dominant", Sound = "Consonance or Dissonance"  },
                new Interval { Id = 7, Name = "♯ 4th", SemiTones = 6, FullName = "Augmented Fourth", Symbol = "IV +", Degree = "Tritone", Sound = "Neutral"  },
                new Interval { Id = 8, Name = "♭ 5th", SemiTones = 6, FullName = "Diminished Fifth", Symbol = "V °", Degree = "Tritone", Sound = "Restless"  },
                new Interval { Id = 9, Name = "5th", SemiTones = 7, FullName = "Perfect Fifth", Symbol = "V", Degree = "Dominant", Sound = "Open Consonance"  },
                new Interval { Id = 10, Name = "♯ 5th", SemiTones = 8, FullName = "Augmented Fifth", Symbol = "V +", Degree = "Sub-Mediant", Sound = "Soft Consonance"  },
                new Interval { Id = 11, Name = "♭ 6th", SemiTones = 8, FullName = "Minor Sixth", Symbol = "vi", Degree = "Sub-Mediant", Sound = "Soft Consonance"  },
                new Interval { Id = 12, Name = "6th", SemiTones = 9, FullName = "Major Sixth", Symbol = "VI", Degree = "Sub-Mediant", Sound = "Soft Consonance"  },
                new Interval { Id = 13, Name = "♭♭ 7th", SemiTones = 9, FullName = "Diminished Seventh", Symbol = "vii °", Degree = "Sub-Mediant", Sound = "Soft Consonance"  },
                new Interval { Id = 14, Name = "♭ 7th", SemiTones = 10, FullName = "Minor Seventh", Symbol = "vii", Degree = "Sub-Tonic", Sound = "Mild Dissonance"  },
                new Interval { Id = 15, Name = "7th", SemiTones = 11, FullName = "Major Seventh", Symbol = "VII", Degree = "Leading Note", Sound = "Sharp Dissonance"  }

        };

        public static List<Interval> GetIntervals() => _intervals.ToList();

        public static ChordType GetChordTypeFromChordSignature(string chordTypeSignature)
        {
            string chordType = "";
            string chordSymbol = "";

            if (chordTypeSignature.Contains("0,3,3,3"))
            {
                chordType = "diminished seventh";
                chordSymbol = "°7";
            }
            else
            {
                if (chordTypeSignature.Contains("0,3,3,4"))
                {
                    chordType = "minor seventh flat five";
                    chordSymbol = "m7♭5";
                }
                else
                {
                    if (chordTypeSignature.Contains("0,3,4,3"))
                    {
                        chordType = "minor seventh";
                        chordSymbol = "m7";
                    }
                    else
                    {
                        if (chordTypeSignature.Contains("0,3,4,4"))
                        {
                            chordType = "minor/major seventh";
                            chordSymbol = "min/maj7";
                        }
                        else
                        {
                            if (chordTypeSignature.Contains("0,4,3,3"))
                            {
                                chordType = "dominant seventh";
                                chordSymbol = "7";
                            }
                            else
                            {
                                if (chordTypeSignature.Contains("0,4,3,4"))
                                {
                                    chordType = "major seventh";
                                    chordSymbol = "maj7";
                                }
                                else
                                {
                                    if (chordTypeSignature.Contains("0,4,4,3"))
                                    {
                                        chordType = "major seventh sharp five";
                                        chordSymbol = "maj7♯5";
                                    }
                                }
                            }
                        }
                    }
                }
            }

            ChordType newChordType = new ChordType()
            {
                Name = chordType,
                Symbol = chordSymbol,
                ThirdsSignature = chordTypeSignature,
                Description = "Created by Harmonizer"
            };
            return newChordType;
        }

        public static List<string> GetChordIntervalsFromSignature(string chordTypeSignature)
        {
            List<string> chordTypeIntervals = new List<string>();
            if (chordTypeSignature.Contains("0,3,3,3"))
            {
                chordTypeIntervals.Add("1st");
                chordTypeIntervals.Add("♭ 3rd");
                chordTypeIntervals.Add("♭ 5th");
                chordTypeIntervals.Add("♭♭ 7th");
            }
            else
            {
                if (chordTypeSignature.Contains("0,3,3,4"))
                {
                    chordTypeIntervals.Add("1st");
                    chordTypeIntervals.Add("♭ 3rd");
                    chordTypeIntervals.Add("♭ 5th");
                    chordTypeIntervals.Add("♭ 7th");
                }
                else
                {
                    if (chordTypeSignature.Contains("0,3,4,3"))
                    {
                        chordTypeIntervals.Add("1st");
                        chordTypeIntervals.Add("♭ 3rd");
                        chordTypeIntervals.Add("5th");
                        chordTypeIntervals.Add("♭ 7th");
                    }
                    else
                    {
                        if (chordTypeSignature.Contains("0,3,4,4"))
                        {
                            chordTypeIntervals.Add("1st");
                            chordTypeIntervals.Add("♭ 3rd");
                            chordTypeIntervals.Add("5th");
                            chordTypeIntervals.Add("7th");
                        }
                        else
                        {
                            if (chordTypeSignature.Contains("0,4,3,3"))
                            {
                                chordTypeIntervals.Add("1st");
                                chordTypeIntervals.Add("3rd");
                                chordTypeIntervals.Add("5th");
                                chordTypeIntervals.Add("♭ 7th");
                            }
                            else
                            {
                                if (chordTypeSignature.Contains("0,4,3,4"))
                                {
                                    chordTypeIntervals.Add("1st");
                                    chordTypeIntervals.Add("3rd");
                                    chordTypeIntervals.Add("5th");
                                    chordTypeIntervals.Add("7th");
                                }
                                else
                                {
                                    if (chordTypeSignature.Contains("0,4,4,3"))
                                    {
                                        chordTypeIntervals.Add("1st");
                                        chordTypeIntervals.Add("3rd");
                                        chordTypeIntervals.Add("♯ 5th");
                                        chordTypeIntervals.Add("7th");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return chordTypeIntervals;
        }

        public static string GetChordSignature(int scaleIntervalSemiTones, HashSet<int> scaleSemiTonesSet)
        {
            // ********** get chord's unique thirds signature as a string of a list of integers, e.g. "0,3,3,3" ****************** //
            string chordSignature = "0";
            int thisIntervalSemiTones = scaleIntervalSemiTones;
            int thisIntervalPlus3 = 0;
            int thisIntervalPlus4 = 0;

            for (int x = 1; x < 4; x++)
            {
                // determine correct minor third value
                if ((thisIntervalSemiTones + 3) > 11)
                {
                    thisIntervalPlus3 = (thisIntervalSemiTones + 3) - 12;
                }
                else
                {
                    thisIntervalPlus3 = thisIntervalSemiTones + 3;
                }
                // determine correct major third value
                if ((thisIntervalSemiTones + 4) > 11)
                {
                    thisIntervalPlus4 = (thisIntervalSemiTones + 4) - 12;
                }
                else
                {
                    thisIntervalPlus4 = thisIntervalSemiTones + 4;
                }
                // add either a major or minor third based on whether the resulting note is in the scale
                if (scaleSemiTonesSet.Contains((thisIntervalPlus3)))
                {
                    chordSignature = $"{chordSignature},3";
                    thisIntervalSemiTones = thisIntervalPlus3;
                }
                else
                {
                    if (scaleSemiTonesSet.Contains((thisIntervalPlus4)))
                    {
                        chordSignature = $"{chordSignature},4";
                        thisIntervalSemiTones = thisIntervalPlus4;
                    }
                }
            }
            return chordSignature;
        }


    }
}
