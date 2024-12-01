// See https://aka.ms/new-console-template for more information

using AdventOfCode2024.Day1;

var dataLoader = new DataLoader();
var locations1 = dataLoader.LoadLocalFileData("1 - input.txt");
Console.WriteLine($"Day 1, part 1 results. Total distances: {locations1.GetTotalDistance()}");

var locations2 = dataLoader.LoadLocalFileData("2 - input.txt");
Console.WriteLine($"Day 1, part 2 results. Total similarity: {locations2.GetTotalSimilarity()}");
Console.ReadKey();