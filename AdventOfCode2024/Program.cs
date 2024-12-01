// See https://aka.ms/new-console-template for more information

using AdventOfCode2024.Day1;

var dataLoader = new DataLoader();
var projectFolderName = "Day1";
var filePath = "DataFiles/1 - input.txt";
var fileTestPath = $"{Directory.GetCurrentDirectory()}/{projectFolderName}/{filePath}";
var locations = dataLoader.LoadData(fileTestPath);
Console.WriteLine($"Day 1 result. Total distances: {locations.GetTotalDistance()}");
Console.ReadKey();