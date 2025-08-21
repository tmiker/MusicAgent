using MusicServices.Models;

namespace MusicServices.Utility
{
    public class AltData
    {
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
                    chordSymbol = "m7b5";
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
                                        chordSymbol = "maj7#5";
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
                chordTypeIntervals.Add("b 3rd");
                chordTypeIntervals.Add("b 5th");
                chordTypeIntervals.Add("bb 7th");
            }
            else
            {
                if (chordTypeSignature.Contains("0,3,3,4"))
                {
                    chordTypeIntervals.Add("1st");
                    chordTypeIntervals.Add("b 3rd");
                    chordTypeIntervals.Add("b 5th");
                    chordTypeIntervals.Add("b 7th");
                }
                else
                {
                    if (chordTypeSignature.Contains("0,3,4,3"))
                    {
                        chordTypeIntervals.Add("1st");
                        chordTypeIntervals.Add("b 3rd");
                        chordTypeIntervals.Add("5th");
                        chordTypeIntervals.Add("♭ 7th");
                    }
                    else
                    {
                        if (chordTypeSignature.Contains("0,3,4,4"))
                        {
                            chordTypeIntervals.Add("1st");
                            chordTypeIntervals.Add("b 3rd");
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
                                chordTypeIntervals.Add("b 7th");
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
                                        chordTypeIntervals.Add("# 5th");
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
