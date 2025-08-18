using MusicServices.Abstraction;
using MusicServices.DataStructures;
using MusicServices.Models;
using MusicServices.Utility;

namespace MusicServices.Builders
{
    public class Harmonizer : IHarmonizer
    {
        private readonly IMusicTheoryHelper _theoryHelper;
        public Harmonizer(IMusicTheoryHelper theoryHelper)
        {
            _theoryHelper = theoryHelper;
        }

        public List<Chord> HarmonizeScale(Scale scale)
        {
            // verify scale is diatonic
            bool isDiatonic = _theoryHelper.CheckScaleIsDiatonicFromIntervalPositions(scale);
            if (!isDiatonic) throw new InvalidDataException($"Attempting to Harmonize a scale that is not diatonic.");

            // initialize chord list
            List<Chord> chords = new List<Chord>();

            // get list of scale note names for later use in creating MusicWheels
            List<string> scaleNotes = scale.ScaleNotes.Select(s => s.Note.Name).ToList();
            int harmonyPosition = 0;

            // foreach note in the scale, create a chord by stacking thirds and add it to the chord list
            // note that the third added is major or minor depending on which results in a note in the scale
            foreach (var note in scaleNotes)
            {
                harmonyPosition++;

                Chord chord = BuildChordForCurrentScaleNode(scaleNotes, note);

                chord.Name = $"{scale.Name} Harmony {harmonyPosition}";
                chord.ChordType = _theoryHelper.GetChordType(chord);
                chords.Add(chord);
            }

            return chords;
        }

        private Chord BuildChordForCurrentScaleNode(List<string> scaleNotes, string note)
        {
            // initialize MusicWheel and get first scale node
            MusicWheel wheel = new MusicWheel(note);
            MusicNode currentNode = wheel.First!;   // note wheel constructor will throw if wheel.First is null

            // initailize first chord and add first chord note which is the chord root
            Chord chord = new Chord() { RootNoteName = currentNode.Note.Name };
            chord.ChordNotes.Add(new ChordNote() { Interval = currentNode.Interval, Note = currentNode.Note });

            // add 3 more chord notes by stacking thirds for which the note is in the scale
            for (int i = 0; i < 3; i++)
            {
                MusicNode? nextThird = wheel.GetNextMinorThird(currentNode);

                if (nextThird is null || !scaleNotes.Contains(nextThird.Note.Name)) nextThird = wheel.GetNextMajorThird(currentNode);
                if (nextThird is null || !scaleNotes.Contains(nextThird.Note.Name)) throw new InvalidDataException($"Attempting to Harmonize a scale that is not diatonic.");

                chord.ChordNotes.Add(new ChordNote() { Interval = nextThird.Interval, Note = nextThird.Note });

                currentNode = nextThird;
            }

            return chord;
        }

        // OBSOLETE PRIVATE METHODS
        private List<int> BuildChordSignature(List<string> scaleNotes, MusicNode currentNode, MusicWheel wheel)
        {
            List<int> chordSignature = new List<int> { 0 };
            for (int i = 0; i < 3; i++)
            {
                MusicNode? nextThird = wheel.GetNextMinorThird(currentNode);

                if (nextThird is not null && scaleNotes.Contains(nextThird.Note.Name)) chordSignature.Add(3);
                else
                {
                    nextThird = wheel.GetNextMajorThird(currentNode);
                    if (nextThird is not null && scaleNotes.Contains(nextThird.Note.Name)) chordSignature.Add(4);
                    else
                    {
                        Console.WriteLine($"The scale is not diatonic and cannot be harmonized to thirds.");
                        throw new InvalidDataException($"Attempting to Harmonize a scale that is not diatonic.");
                    }
                }
                currentNode = nextThird;
            }
            return chordSignature;
        }

        private Chord BuildChordFromSignature(List<int> chordSignature, MusicWheel wheel)
        {
            if (!chordSignature.Contains(0)) chordSignature.Insert(0, 0);
            int position = 0;
            Chord chord = new Chord();
            for (int i = 0; i < chordSignature.Count; i++)
            {
                position += chordSignature[i];
                MusicNode? node = wheel.GetNodeAtSemitoneInterval(wheel.First!, position);
                if (node is not null) chord.ChordNotes.Add(new ChordNote() { Interval = node.Interval, Note = node.Note });
            }
            return chord;
        }
    }
}
