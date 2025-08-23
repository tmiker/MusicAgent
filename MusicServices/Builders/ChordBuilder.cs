using MusicServices.Abstraction;
using MusicServices.DataStructures;
using MusicServices.Enums;
using MusicServices.Models;
using MusicServices.Utility;
using System.Xml.Linq;

namespace MusicServices.Builders
{
    public class ChordBuilder : IChordBuilder
    {
        // take a root note name and intervals to include and build a collection of ChordNotes using
        // a single instance of a MusicWheel.  The Chord's ChordNotes get Note and Interval from a MusicNode 
        // in the MusicWheel populate other Chord metadata, e.g. name, type, etc.
        // Note that if the MusicWheel consructor will throw an exception if there are no notes/intervals to 
        // add to the wheel, so MusicWheel.First should never be null.

        private readonly IMusicTheoryHelper _theoryHelper;
        public ChordBuilder(IMusicTheoryHelper theoryHelper)
        {
            _theoryHelper = theoryHelper;
        }

        public Chord CreateChordByType(string rootNoteName, ChordTypeEnum chordType)
        {
            List<int> chordSignature = _theoryHelper.GetChordSignature(chordType);
            if (!chordSignature.Contains(0)) chordSignature.Insert(0, 0);
            MusicWheel wheel = new MusicWheel(rootNoteName);

            Chord chord = new Chord() { Name = chordType.ToString(), RootNoteName = rootNoteName, ChordType = chordType.ToString() };
            int position = 0;
            for (int i = 0; i < chordSignature.Count; i++)
            {
                position += chordSignature[i];
                MusicNode? node = wheel.GetNodeAtSemitoneInterval(wheel.First!, position);
                if (node is not null) chord.ChordNotes.Add(new NoteInterval() { Interval = node.Interval, Note = node.Note.Clone() });
            }

            return chord;
        }

        public Chord CreateChordFromSignature(string rootNoteName, List<int> chordSignature)
        {
            if (!chordSignature.Contains(0)) chordSignature.Insert(0, 0);
            MusicWheel wheel = new MusicWheel(rootNoteName);

            Chord chord = new Chord() { RootNoteName = rootNoteName };
            Console.WriteLine($"ChordBuilder.CreateChordFromSignature: Creaded chord with root note name {rootNoteName}...");
            int position = 0;
            for (int i = 0; i < chordSignature.Count; i++)
            {
                position += chordSignature[i];
                MusicNode? node = wheel.GetNodeAtSemitoneInterval(wheel.First!, position);
                if (node is not null) chord.ChordNotes.Add(new NoteInterval() { Interval = node.Interval, Note = node.Note.Clone() });
                Console.WriteLine($" --- ChordBuilder.CreateChordFromSignature: Added ChordNote with note name {node?.Note.Name} as interval {node?.Interval.Symbol}");
            }

            return chord;
        }
    }
}
