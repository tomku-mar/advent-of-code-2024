namespace AdventOfCode2024.Day2
{
    public class Report
    {
        public List<int> Levels { get; }

        public Report(List<int> levels)
        {
            Levels = levels;
        }

        public bool IsSafe()
        {
            return !AreContainEquals() && !AreDifferencesBiggerThanThree() && (AreAllDecreasing() || AreAllIncreasing());
        }

        private bool AreAllDecreasing()
        {
            for (var i = 1; i < Levels.Count; i++)
            {
                if (Levels[i] >= Levels[i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        private bool AreAllIncreasing()
        {
            for (var i = 1; i < Levels.Count; i++)
            {
                if (Levels[i] <= Levels[i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        private bool AreContainEquals()
        {
            for (var i = 1; i < Levels.Count; i++)
            {
                if (Levels[i] == Levels[i - 1])
                {
                    return true;
                }
            }

            return false;
        }

        private bool AreDifferencesBiggerThanThree()
        {
            for (var i = 1; i < Levels.Count; i++)
            {
                if (Math.Abs(Levels[i] - Levels[i - 1]) > 3)
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsSafeWithoutOneLevel()
        {
            if (IsSafe())
            {
                return true;
            }

            var reportsWithoutOneLevel = new List<Report>();

            for (var i = 0; i < Levels.Count; i++)
            {
                reportsWithoutOneLevel.Add(new Report(Levels[..Levels.Count]));
                reportsWithoutOneLevel[i].Levels.RemoveAt(i);
            }

            return reportsWithoutOneLevel.Any(x => x.IsSafe());
        }
    }
}