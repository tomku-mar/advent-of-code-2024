namespace AdventOfCode2024.Tests.Day2
{
    using AdventOfCode2024.Day2;

    public class Day2DataLoaderTests
    {
        [Theory]
        [InlineData("DataFiles/1 - example input1.txt", 2)]
        [InlineData("DataFiles/1 - my input1.txt", 4)]
        public void Should_CalculateTotalDistanceFromFileData(string filePath, int expectedSafeLevels)
        {
            var projectFolderName = "Day2";
            var fileTestPath = $"{Directory.GetCurrentDirectory()}/{projectFolderName}/{filePath}";
            var dataLoader = new Day2DataLoader();
            var reports = dataLoader.LoadData(fileTestPath);

            var safeLevels = reports.Count(x => x.IsSafe());

            Assert.True(expectedSafeLevels == safeLevels);
        }
    }
}