using MudicAgent.Console.ClassTestData;
using MusicServices.Abstraction;
using MusicServices.Builders;
using MusicServices.Enums;
using MusicServices.Helpers;
using MusicServices.Models;

IMusicTheoryHelper musicTheoryHelper = new MusicTheoryHelper();
IScaleBuilder  scaleBuilder = new ScaleBuilder(musicTheoryHelper);
IChordBuilder chordBuilder = new ChordBuilder(musicTheoryHelper);
IHarmonizer harmonizer = new Harmonizer(musicTheoryHelper);

Chord cMajor = chordBuilder.CreateChordFromSignature("C", new List<int> { 0, 4, 3 });

// Scale scale = scaleBuilder.CreateScaleByType("G", ScaleTypeEnum.Minor);

//List<Chord> harmonizerChords = harmonizer.HarmonizeScale(scale);

//foreach (var chord in harmonizerChords)
//{
//    Console.WriteLine(chord);
//}

//ScaleClassData scaleClassData = new ScaleClassData();
//List<Chord> testDataGMinorChords = scaleClassData.GetGMinorHarmonyChords();

//foreach (var chord in testDataGMinorChords)
//{
//    Console.WriteLine(chord);
//}
