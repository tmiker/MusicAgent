using MudicAgent.Console.ClassTestData;
using MusicServices.Abstraction;
using MusicServices.Builders;
using MusicServices.Enums;
using MusicServices.Helpers;
using MusicServices.Models;

IMusicTheoryHelper musicTheoryHelper = new MusicTheoryHelper();
IScaleBuilder  scaleBuilder = new ScaleBuilder(musicTheoryHelper);
IHarmonizer harmonizer = new Harmonizer(musicTheoryHelper);

Scale scale = scaleBuilder.CreateScaleByType("G", ScaleTypeEnum.Minor);

//List<Chord> harmonizerChords = harmonizer.HarmonizeScale(scale);

//foreach (var chord in harmonizerChords)
//{
//    Console.WriteLine(chord);
//}

ScaleClassData scaleClassData = new ScaleClassData();
List<Chord> testDataGMinorChords = scaleClassData.GetGMinorHarmonyChords();

foreach (var chord in testDataGMinorChords)
{
    Console.WriteLine(chord);
}
