using MusicServices.Enums;
using MusicServices.Models;

namespace MusicServices.Abstraction
{
    public interface IScaleBuilder
    {
        Scale CreateScaleByType(string rootNoteName, ScaleTypeEnum scaleType);
    }
}
