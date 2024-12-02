namespace AdventOfCode2024.Day1
{
    public class Day1DataLoader
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

        public Locations LoadLocalFileData(string fileName)
        {
            var projectFolderName = "Day1";
            var filePath = $"DataFiles/{fileName}";
            var fileTestPath = $"{Directory.GetCurrentDirectory()}/{projectFolderName}/{filePath}";
            return LoadData(fileTestPath);
        }
    }
}