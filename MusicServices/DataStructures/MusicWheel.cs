using MusicServices.Models;
using MusicServices.Utility;
using System.Diagnostics;
using System.Text;

namespace MusicServices.DataStructures
{
    /// <summary>
    /// The MusicWheel is a Circular Linked List of MusicNode types. The MusicNode type contains note and 
    /// interval data for a chromatic sequence of notes starting from a root note provided to the Initialize 
    /// method.  The MusicWheel simplifies creating chords, creating scales, and harmonizing scales.
    /// Note that if the MusicWheel consructor will throw an exception if there are no notes/intervals to 
    /// add to the wheel, so MusicWheel.First should never be null.
    /// </summary>
    public class MusicWheel
    {
        public MusicNode? First { get; set; }

        public MusicWheel(string rootNoteName)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            List<Interval> intervalList = StaticData.IntervalList;
            List<Note> noteListFromRoot = GetNoteListStartingFromRoot(rootNoteName);

            if (!noteListFromRoot.Any()) throw new InvalidDataException($"The MusicWheel generated with Root Note Name {rootNoteName} is empty.");

            for (int i = 0; i < noteListFromRoot.Count; i++)
            {
                MusicNode node = new MusicNode() { Interval = intervalList[i], Note = noteListFromRoot[i] };
                node.Note.Position = i; // Reset the position of the note in the wheel based on root note
                AddNode(node);
            }
            sw.Stop();
            Console.WriteLine($"Wheel successfully initialized with Root Note {rootNoteName} in {sw.ElapsedMilliseconds} ms at {DateTime.Now}.");
        }

        public NoteInterval? GetNoteInterval(MusicNode node)
        {
            // When adding a NoteInterval to a harmonized scale chord, the position of the note is mutable so need to clone it (has no reference type properties)
            if (node is null) return null;
            return new NoteInterval() { Interval = node.Interval, Note = node.Note.Clone() };
        }

        private void AddNode(MusicNode node)
        {
            if (First is null) First = node;
            else
            {
                MusicNode? last = First.Previous;
                if (last is null) First.Next = node;
                else last.Next = node;
                First.Previous = node;
                node.Next = First;
            }
        }

        public MusicNode? GetNodeAtSemitoneInterval(MusicNode node, int semitones)
        {
            while (semitones > 0)
            {
                node = node.Next!;
                if (node is null) return null;
                semitones--;
            }
            return node;
        }

        public MusicNode? GetNextMinorThird(MusicNode node)
        {
            int semitones = 1;
            while (semitones <= 3)
            {
                node = node.Next!;
                if (node is null) return null;
                semitones++;
            }
            return node;
        }

        public MusicNode? GetNextMajorThird(MusicNode node)
        {
            int semitones = 1;
            while (semitones <= 4)
            {
                node = node.Next!;
                if (node is null) return null;
                semitones++;
            }
            return node;
        }

        private List<Note> GetNoteListStartingFromRoot(string rootNoteName)
        {
            List<Note> noteList = StaticData.NoteList;
            Note rootNote = noteList.First(n => n.Name == rootNoteName);
            int rootIndex = noteList.IndexOf(rootNote);

            List<Note> notesFromRoot = new List<Note>();
            int index = rootIndex;
            int position = 0;

            while (index < noteList.Count)
            {
                Note note = noteList[index];
                note.Position = position;
                notesFromRoot.Add(note);
                index++;
                position++;
            }

            if (notesFromRoot.Count < 12)
            {
                index = 0;
                while (index < rootIndex)
                {
                    Note note = noteList[index];
                    note.Position = position;
                    notesFromRoot.Add(note);
                    index++;
                    position++;
                }
            }

            return notesFromRoot;
        }

        public void PrintNodes()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Music Wheel Nodes: ");
            if (First is null) sb.Append($"  The wheel is empty.");
            else
            {
                int counter = 0;
                sb.AppendLine($"    {counter}: {First}");

                MusicNode? current = First.Next;
                if (current is not null)
                {
                    while (current != First)
                    {
                        counter++;
                        sb.AppendLine($"    {counter}: {current}");
                        current = current?.Next;
                    }
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}

