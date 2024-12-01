// <copyright file="DataLoaderTests.cs" company="Equiniti">
// Copyright (c) Equiniti 2022. All Rights Reserved
// </copyright>

namespace AdventOfCode2024.Tests.Day1
{
    using AdventOfCode2024.Day1;

    public class DataLoaderTests
    {
        [Theory]
        [InlineData("DataFiles/1 - example input1.txt", 11)]
        [InlineData("DataFiles/1 - my input1.txt", 88)]
        [InlineData("DataFiles/1 - my input2.txt", 59)]
        public void Should_CalculateTotalDistanceFromFileData(string filePath, int expectedTotalDistance)
        {
            var projectFolderName = "Day1";
            var fileTestPath = $"{Directory.GetCurrentDirectory()}/{projectFolderName}/{filePath}";
            var dataLoader = new DataLoader();
            var locations = dataLoader.LoadData(fileTestPath);

            Assert.True(expectedTotalDistance == locations.GetTotalDistance());
        }
    }
}