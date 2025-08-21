using MudicAgent.Console.ClassTestData;
using MusicServices.Abstraction;
using MusicServices.Builders;
using MusicServices.DataStructures;
using MusicServices.Enums;
using MusicServices.Helpers;
using MusicServices.Models;
using MusicServices.Utility;
using System.Text;
using System.Text.Json;

//MusicWheel wheel = new MusicWheel("C");
//wheel.PrintNodes();

//Console.WriteLine();

IMusicTheoryHelper musicTheoryHelper = new MusicTheoryHelper();
IScaleBuilder scaleBuilder = new ScaleBuilder(musicTheoryHelper);
//IChordBuilder chordBuilder = new ChordBuilder(musicTheoryHelper);
//IHarmonizer harmonizer = new Harmonizer(musicTheoryHelper);

//Interval i = AltData.GetIntervals().First(interval => interval.SemiTones == 7);
//string jsonInterval = JsonSerializer.Serialize(i);
//int bytes = Encoding.UTF8.GetByteCount(jsonInterval);
//Console.WriteLine($"A Perfect Fifth Interval has {bytes} bytes");

// Chord cMajor = chordBuilder.CreateChordFromSignature("C", new List<int> { 0, 4, 3 });

Scale scale = scaleBuilder.CreateScaleByType("G", ScaleTypeEnum.Minor);
Console.WriteLine(scale);

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
