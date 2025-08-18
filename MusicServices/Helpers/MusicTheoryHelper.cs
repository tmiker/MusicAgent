using MusicServices.Abstraction;
using MusicServices.Enums;
using MusicServices.Models;
using System.Text;

namespace MusicServices.Helpers
{
    public class MusicTheoryHelper : IMusicTheoryHelper
    {
        public List<int> GetChordSignature(ChordTypeEnum chordType)
        {
            List<int> signature = chordType switch
            {
                ChordTypeEnum.MajorTriad => new List<int> { 0, 4, 3 },
                ChordTypeEnum.MinorTriad => new List<int> { 0, 3, 4 },
                ChordTypeEnum.MajorSeventh => new List<int> { 0, 4, 3, 4 },
                ChordTypeEnum.MinorSeventh => new List<int> { 0, 3, 4, 3 },
                _ => new List<int>()
            };

            return signature;
        }

        public List<int> GetScaleSignature(ScaleTypeEnum scaleType)
        {
            List<int> signature = scaleType switch
            {
                ScaleTypeEnum.Major => new List<int> { 0, 2, 2, 1, 2, 2, 2, 1 },
                ScaleTypeEnum.Minor => new List<int> { 0, 2, 1, 2, 2, 1, 2, 2 },
                _ => new List<int>()
            };

            return signature;
        }

        public string GetChordType(Chord chord)
        {
            List<int> semitones = chord.ChordNotes.Select(cn => cn.Interval!.SemiTones).ToList();
            string semitoneString = string.Join(", ", semitones);
            string chordType = semitoneString switch
            {
                "0, 4, 7, 11" => "Major Seventh",
                "0, 4, 7, 10" => "Dominant Seventh",
                "0, 3, 7, 10" => "Minor Seventh",
                "0, 3, 6, 10" => "Minor Seven Flat Five",
                _ => "Unknown"
            };
            return chordType;
        }

        public bool CheckScaleIsDiatonicByType(ScaleTypeEnum scaleType)
        {
            bool isDiatonic = false;

            List<int> signature = GetScaleSignature(scaleType);
            signature.Remove(0);

            if (signature.Count != 7) Console.WriteLine($"The scale is not diatonic as it does not have exactly 7 intervals.");
            else Console.WriteLine($"The scale has 7 intervals and may be diatonic.");

            string stepString = string.Join("", signature);

            if (stepString.Contains("1221") || stepString.Contains("12221")) isDiatonic = true;

            return isDiatonic;
        }

        public bool CheckScaleIsDiatonicFromIntervalPositions(Scale scale)
        {
            List<Interval> scaleIntervals = scale.ScaleNotes.Select(s => s.Interval).ToList();

            bool IsDiatonic = false;
            int wholeStepCounter = 0;
            int halfStepCounter = 0;
            string stepString = "";

            for (int x = 0; x < scaleIntervals.Count(); x++)
            {
                int y = x + 1;
                if (y >= scaleIntervals.Count())
                {
                    y = y - scaleIntervals.Count();
                }

                int intervalSemiTones = scaleIntervals[x].SemiTones;
                int nextIntervalSemiTones = scaleIntervals[y].SemiTones;

                int stepsBetween = nextIntervalSemiTones - intervalSemiTones;
                if (stepsBetween < 0)
                {
                    stepsBetween = stepsBetween + 12;
                }
                if (stepsBetween == 2)
                {
                    wholeStepCounter++;
                }
                if (stepsBetween == 1)
                {
                    halfStepCounter++;
                }
                stepString = $"{stepString}{stepsBetween}";
                //stepList.Add(stepsBetween);
            }

            StringBuilder sb = new StringBuilder($"Diatonic Check: \n");
            sb.AppendLine($" - Scale Step String: {stepString}");
            sb.AppendLine($" - Scale Whole Step Counter: {wholeStepCounter}");
            sb.AppendLine($" - Scale Half Step Counter: {halfStepCounter}");
            Console.WriteLine(sb.ToString());

            if (wholeStepCounter == 5 && halfStepCounter == 2)
            {
                if (stepString.Contains("1221") || stepString.Contains("12221"))
                {
                    IsDiatonic = true;
                }
            }

            Console.WriteLine($"Is Diatonic: {IsDiatonic}");

            return IsDiatonic;
        }
    }
}
