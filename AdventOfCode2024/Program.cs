﻿// See https://aka.ms/new-console-template for more information

using AdventOfCode2024.Day1;
using AdventOfCode2024.Day2;

Console.WriteLine("--== DAY 1 ==--");

var day1DataLoader = new Day1DataLoader();
var locations1 = day1DataLoader.LoadLocalFileData("1 - input.txt");
Console.WriteLine($"Part 1. Total distances: {locations1.GetTotalDistance()}");

var locations2 = day1DataLoader.LoadLocalFileData("2 - input.txt");
Console.WriteLine($"Part 2. Total similarity: {locations2.GetTotalSimilarity()}");

Console.WriteLine("--== DAY 2 ==--");
var day2DataLoader = new Day2DataLoader();
var reports = day2DataLoader.LoadLocalFileData("Day 2 - 1 - input.txt");
var safeLevels = reports.Count(x => x.IsSafe());
Console.WriteLine($"Part 1. Total safe levels: {safeLevels}");

Console.ReadKey();