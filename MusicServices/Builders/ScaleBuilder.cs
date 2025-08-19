using MusicServices.Abstraction;
using MusicServices.DataStructures;
using MusicServices.Enums;
using MusicServices.Models;
using MusicServices.Utility;

namespace MusicServices.Builders
{
    public class ScaleBuilder : IScaleBuilder
    {
        // take a root note name and intervals to include and build a collection of ScaleNotes using
        // a single instance of a MusicWheel. The Scale's ScaleNotes get Note and Interval from a MusicNode 
        // in the MusicWheel populate other Chord metadata, e.g. name, type, etc.
        // Note that if the MusicWheel consructor will throw an exception if there are no notes/intervals to 
        // add to the wheel, so MusicWheel.First should never be null.

        private readonly IMusicTheoryHelper _theoryHelper;
        public ScaleBuilder(IMusicTheoryHelper theoryHelper)
        {
            _theoryHelper = theoryHelper;
        }

        public Scale CreateScaleByType(string rootNoteName, ScaleTypeEnum scaleType)
        {
            List<int> scaleSignature = _theoryHelper.GetScaleSignature(scaleType);
            if (!scaleSignature.Contains(0)) scaleSignature.Insert(0, 0);

            MusicWheel wheel = new MusicWheel(rootNoteName);

            Scale scale = new Scale() { Name = scaleType.ToString(), RootNoteName = rootNoteName, ScaleType = scaleType.ToString() };
            int position = 0;
            // will skip the last scaleSignature member as it takes us back to the Root note
            for (int i = 0; i < scaleSignature.Count - 1; i++)
            {
                position += scaleSignature[i];
                MusicNode? node = wheel.GetNodeAtSemitoneInterval(wheel.First!, position);
                if (node?.Interval is not null && node.Note is not null) scale.ScaleNotes.Add(new ScaleNote() { Interval = node.Interval, Note = node.Note });
            }

            return scale;
        }
    }
}
