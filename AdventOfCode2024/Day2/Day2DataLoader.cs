namespace AdventOfCode2024.Day2
{
    public class Day2DataLoader
    {
        public List<Report> LoadData(string filePath)
        {
            var fileLines = File.ReadAllLines(filePath);
            var reports = new List<Report>();

            foreach (var line in fileLines)
            {
                var splitLevels = line.Split(" ");

                var levels = new List<int>();
                foreach (var level in splitLevels)
                {
                    var parsed = int.TryParse(level, out var parsedLevel);

                    if (!parsed)
                    {
                        throw new ArgumentException("Incorrect data format");
                    }

                    levels.Add(parsedLevel);
                }

                reports.Add(new Report(levels));
            }

            return reports;
        }

        public List<Report> LoadLocalFileData(string fileName)
        {
            var projectFolderName = "Day2";
            var filePath = $"DataFiles/{fileName}";
            var fileTestPath = $"{Directory.GetCurrentDirectory()}/{projectFolderName}/{filePath}";
            return LoadData(fileTestPath);
        }
    }
}