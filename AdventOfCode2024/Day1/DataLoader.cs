// <copyright file="DataLodader.cs" company="Equiniti">
// Copyright (c) Equiniti 2022. All Rights Reserved
// </copyright>

namespace AdventOfCode2024.Day1
{
    public class DataLoader
    {
        public Locations LoadData(string filePath)
        {
            var fileLines = File.ReadAllLines(filePath);
            var leftLocations = new List<int>();
            var rightLocations = new List<int>();

            foreach (var line in fileLines)
            {
                var splitLine = line.Split("   ");

                if (splitLine.Length != 2)
                {
                    throw new ArgumentException("Wrong file format");
                }

                var leftLocationParsed = int.TryParse(splitLine[0], out var leftLocation);
                var rightLocationParsed = int.TryParse(splitLine[1], out var rightLocation);

                if (!leftLocationParsed || !rightLocationParsed)
                {
                    throw new ArgumentException("Wrong data format");
                }

                leftLocations.Add(leftLocation);
                rightLocations.Add(rightLocation);
            }

            return new Locations(leftLocations, rightLocations);
        }
    }
}