using MusicServices.Enums;
using MusicServices.Models;

namespace MusicServices.Abstraction
{
    public interface IMusicTheoryHelper
    {
        List<int> GetChordSignature(ChordTypeEnum chordType);
        List<int> GetScaleSignature(ScaleTypeEnum scaleType);
        string GetChordType(Chord chord);
        bool CheckScaleIsDiatonicByType(ScaleTypeEnum scaleType);
        bool CheckScaleIsDiatonicFromIntervalPositions(Scale scale);
    }
}
