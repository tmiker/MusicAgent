using MusicServices.DataStructures;
using MusicServices.Models;

namespace MusicServices.Abstraction
{
    public interface IHarmonizer
    {
        List<Chord> HarmonizeScale(Scale scale);
    }
}
