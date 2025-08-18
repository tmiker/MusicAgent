using MusicServices.Enums;
using MusicServices.Models;

namespace MusicServices.Abstraction
{
    public interface IChordBuilder
    {
        Chord CreateChordByType(string rootNoteName, ChordTypeEnum chordType);
        Chord CreateChordFromSignature(string rootNoteName, List<int> chordSignature);
    }
}
